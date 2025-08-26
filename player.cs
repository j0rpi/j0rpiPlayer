using j0rpiPlayer.Properties;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Formats.Tar;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using TagLib.Mpeg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace j0rpiPlayer
{

    public partial class player : Form
    {
        const int WM_VSCROLL = 0x0115;
        const int SB_THUMBPOSITION = 4;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private System.Windows.Forms.Timer progressTimer;
        private string[] mp3Files;
        private int currentTrackIndex = -1;
        private int currentPlayingIndex = -1;
        private int hoveredIndex = -1;
        private MeteringSampleProvider meter;
        private PanningSampleProvider panningProvider;
        private VolumeSampleProvider volProvider;
        private AudioFileReader audioFileReader;
        private WaveOutEvent waveOut;


        public player()
        {
            InitializeComponent();
        }

        private void player_Load(object sender, EventArgs e)
        {
            listView1.Visible = false;
            aevionProgressBar1.Text = "00:00 / 00:00";
            label2.AutoSize = true;
            scrollingTitle.Interval = 1500;
            scrollingTitle.Start();
            txtArtist.Text = "Artist:   N/A";
            txtTitle.Text = "Title:   N/A";
            txtAlbum.Text = "Album:     N/A";
            lblTotal.Text = "Duration:  N/A";
            txtBitrate.Text = "Bitrate:   N/A";
            txtFreq.Text = "Frequency: N/A";
            pictureBox1.Image = Resources.nodisc;
            pictureBox2.Image = Resources.nodiscsmall;
            this.DoubleBuffered = true;
            timer1.Enabled = true;
            timer1.Interval = 16;
            label6.Text = "made with ❤️ by j0rpi";
            progressTimer = new System.Windows.Forms.Timer();
            progressTimer.Interval = 1;
            progressTimer.Tick += ProgressTimer_Tick;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            listView1.DrawColumnHeader += listView1_DrawColumnHeader;
            listView1.DrawItem += listView1_DrawItem;
            listView1.MouseMove += listView1_MouseMove;
            listView1.MouseLeave += listView1_MouseLeave;
            listView1.View = View.Details;
            listView1.OwnerDraw = true;
            listView1.Scrollable = true;
            listView1.Columns.Add("#", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("artist", 170, HorizontalAlignment.Left);
            listView1.Columns.Add("title", 188, HorizontalAlignment.Left);
            listView1.Columns.Add("dur", 50, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;
            lblMediaAdd.Cursor = Cursors.Hand;

            volumeSlider1.VolumeChanged += volumeSlider1_VolumeChanged;
            panSlider1.Scroll += panSlider1_Scroll;

            btnPlay.Click += (s, e) => PlaySelected();
            btnPause.Click += (s, e) => waveOut?.Pause();
            btnStop.Click += (s, e) => Stop();
            btnNext.Click += (s, e) => NextTrack();
            btnPrev.Click += (s, e) => PrevTrack();
            btnLoadFolder.Click += (s, e) =>
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        LoadFolder(fbd.SelectedPath);
                    }
                }
            };
            lblMediaAdd.Click += (s, e) =>
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        LoadFolder(fbd.SelectedPath);
                    }
                }
            };
            btnEject.Click += (s, e) =>
            {
                if (MessageBox.Show("Are you sure you want to clear the current playlist?" + Environment.NewLine + "This will stop playback of your current media.", "Confirm Eject", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Stop();
                    listView1.Items.Clear();
                    mp3Files = null;
                    lblMediaAdd.Visible = true;
                    label8.Visible = true;
                    this.Text = "j0rpiPlayer :: no files loaded ...";
                    Stop();

                    txtArtist.Text = "Artist:   N/A";
                    txtTitle.Text = "Title:   N/A";
                    txtAlbum.Text = "Album:     N/A";
                    lblTotal.Text = "Duration:  N/A";
                    txtBitrate.Text = "Bitrate:   N/A";
                    txtFreq.Text = "Frequency: N/A";
                    pictureBox1.Image = Resources.nodisc;
                    pictureBox2.Image = Resources.nodiscsmall;

                    label2.Text = "no track currently playing ...";
                    lblBitrate.Text = "N/A";
                    lblChannels.Text = "N/A";
                }
            };
            volumeSlider1.Volume = 1;
        } 
        private async void LoadFolder(string folderPath)
        {
            listView1.Items.Clear();
            listView1.BeginUpdate();
            lblMediaAdd.Visible = false;
            label8.Visible = false;
            int index = 1;
            this.Text = "j0rpiPlayer :: loading tracks...";

            var files = await Task.Run(() =>
                Directory.GetFiles(folderPath, "*.mp3", SearchOption.AllDirectories)
            );

            await Task.Run(() =>
            {
                foreach (var file in files)
                {
                    try
                    {
                        var tagFile = TagLib.File.Create(file);
                        var item = new ListViewItem(index.ToString());

                        item.SubItems.Add(tagFile.Tag.FirstPerformer ?? "Unknown");
                        item.SubItems.Add(tagFile.Tag.Title ?? Path.GetFileNameWithoutExtension(file));
                        item.SubItems.Add(tagFile.Properties.Duration.ToString(@"mm\:ss"));
                        item.Tag = file;

                        int rowIndex = index;
                        index++;

                        listView1.BeginInvoke(new Action(() =>
                        {
                            listView1.Items.Add(item);
                            if (rowIndex % 50 == 0)
                                this.Text = $"j0rpiPlayer :: loading tracks... {rowIndex}/{files.Length}";
                        }));
                    }
                    catch
                    {
                        MessageBox.Show("There was a problem loading files from selected directory." + Environment.NewLine + "Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblMediaAdd.Visible = true;
                        label8.Visible = true;
                    }
                }

            });
            this.BeginInvoke(new Action(() =>
            {
                this.Text = $"j0rpiPlayer :: {listView1.Items.Count} tracks loaded";
                listView1.Visible = true;
            }));

            mp3Files = files;
            listView1.EndUpdate();
        }

        private void PlaySelected()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                currentTrackIndex = listView1.SelectedItems[0].Index;
                PlayTrack(mp3Files[currentTrackIndex]);
            }
        }


        private void PlayTrack(string filePath)
        {
            Stop();

            audioFileReader = new AudioFileReader(filePath);
            volProvider = new VolumeSampleProvider(audioFileReader);
            volProvider.Volume = volumeSlider1.Volume;

            ISampleProvider currentProvider;
            if (audioFileReader.WaveFormat.Channels == 2)
            {
                var monoProvider = new StereoToMonoSampleProvider(volProvider);
                panningProvider = new PanningSampleProvider(monoProvider);
                panningProvider.Pan = panSlider1.Pan;
                currentProvider = panningProvider;
            }
            else
            {
                panningProvider = new PanningSampleProvider(volProvider);
                panningProvider.Pan = panSlider1.Pan;
                currentProvider = panningProvider;
            }

            meter = new MeteringSampleProvider(currentProvider);
            meter.StreamVolume += OnStreamVolume;

            waveOut = new WaveOutEvent();
            waveOut.Init(meter);
            waveOut.Play();
            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;

            var duration = audioFileReader.TotalTime;
            trackBar1.Maximum = (int)duration.TotalSeconds;
            trackBar1.Value = 0;

            lblElapsed.Text = "00:00";
            lblTotal.Text = duration.ToString(@"mm\:ss");
            var tagFile = TagLib.File.Create(filePath);

            label2.Text = (tagFile.Tag.FirstPerformer ?? "Unknown") + " - " + (tagFile.Tag.Title ?? "Unknown");
            lblBitrate.Text = tagFile.Properties.AudioBitrate + " kbps";

            txtArtist.Text = "Artist:    " + (tagFile.Tag.FirstPerformer ?? "Unknown");
            txtTitle.Text = "Title:     " + (tagFile.Tag.Title ?? "Unknown");
            txtAlbum.Text = "Album:     " + (tagFile.Tag.Album ?? "Unknown") + " (" + (tagFile.Tag.Year > 0 ? tagFile.Tag.Year.ToString() : "Unknown Year") + ")";
            lblTotal.Text = "Duration:  " + tagFile.Properties.Duration.ToString(@"mm\:ss");
            txtBitrate.Text = "Bitrate:   " + tagFile.Properties.AudioBitrate + " kbps";
            txtFreq.Text = "Frequency: " + tagFile.Properties.AudioSampleRate + " Hz";
            pictureBox1.Image = tagFile.Tag.Pictures.Length > 0 ? Image.FromStream(new MemoryStream(tagFile.Tag.Pictures[0].Data.Data)) : Resources.nodisc;
            pictureBox2.Image = tagFile.Tag.Pictures.Length > 0 ? Image.FromStream(new MemoryStream(tagFile.Tag.Pictures[0].Data.Data)) : Resources.nodiscsmall;


            if (tagFile.Properties.AudioChannels == 2)
            {
                lblChannels.Text = "Stereo";
            }
            else if (tagFile.Properties.AudioChannels == 1)
            {
                lblChannels.Text = "Mono";
            }
            else
            {
                lblChannels.Text = "Unknown";
            }

            progressTimer.Start();
            listView1.Invalidate();
            currentPlayingIndex = listView1.SelectedIndices[0];
        }
        private void PlayInternetTrack(string filePath)
        {

            Stop();

            audioFileReader = new AudioFileReader(filePath);
            volProvider = new VolumeSampleProvider(audioFileReader);
            meter = new MeteringSampleProvider(volProvider);
            meter.StreamVolume += OnStreamVolume;

            waveOut = new WaveOutEvent();
            waveOut.Init(meter);
            waveOut.Play();
            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;
            var duration = audioFileReader.TotalTime;
            trackBar1.Maximum = (int)

            duration.TotalSeconds;
            trackBar1.Value = 0;

            label2.Text = "internet stream: " + filePath;
            txtArtist.Text = "Artist:   N/A";
            txtTitle.Text = "Title:   N/A";
            txtAlbum.Text = "Album:     N/A";
            lblTotal.Text = "Duration:  N/A (internet stream)";
            txtBitrate.Text = "Bitrate:   N/A";
            txtFreq.Text = "Frequency: N/A";

            pictureBox1.Image = Resources.nodisc;
            pictureBox2.Image = Resources.nodiscsmall;

            progressTimer.Start();
            listView1.Invalidate();

        }
        private void OnStreamVolume(object sender, StreamVolumeEventArgs e)
        {
            leftLevel = e.MaxSampleValues[0];
            rightLevel = e.MaxSampleValues[1];
            volumeMeter1.ForeColor = Color.White;
            volumeMeter1.Amplitude = e.MaxSampleValues[0];
            volumeMeter2.Amplitude = e.MaxSampleValues[1];
        }
        private void Stop()
        {
            progressTimer.Stop();
            waveOut?.Stop();
            waveOut?.Dispose();
            audioFileReader?.Dispose();
            waveOut = null;
            audioFileReader = null;
            trackBar1.Value = 0;
            lblElapsed.Text = "00:00";
        }

        private void volumeSlider1_VolumeChanged(object sender, EventArgs e)
        {
            if (volProvider != null)
            {
                volProvider.Volume = volumeSlider1.Volume;
            }
        }

        // Update pan handler
        private void panSlider1_Scroll(object sender, EventArgs e)
        {
            if (panningProvider != null)
            {
                panningProvider.Pan = panSlider1.Pan;
            }
        }
        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (audioFileReader != null && waveOut.PlaybackState == PlaybackState.Stopped)
            {
                this.BeginInvoke(new Action(() => NextTrack()));
            }
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                var current = audioFileReader.CurrentTime;
                trackBar1.Value = Math.Min((int)current.TotalSeconds, trackBar1.Maximum);
                lblElapsed.Text = current.ToString(@"mm\:ss");
                aevionProgressBar1.Text = lblElapsed.Text + " / " + audioFileReader.TotalTime.ToString(@"mm\:ss");
                aevionProgressBar1.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
                aevionProgressBar1.Value = Math.Min((int)current.TotalSeconds, trackBar1.Maximum);
                panningProvider.Pan = panSlider1.Pan;
            }

        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(trackBar1.Value);
                lblElapsed.Text = audioFileReader.CurrentTime.ToString(@"mm\:ss");
            }
        }

        private void NextTrack()
        {
            if (mp3Files == null || mp3Files.Length == 0) return;
            currentTrackIndex = (currentTrackIndex + 1) % mp3Files.Length;
            PlayTrack(mp3Files[currentTrackIndex]);
            listView1.Items[currentTrackIndex].Selected = true;
        }

        private void PrevTrack()
        {
            if (mp3Files == null || mp3Files.Length == 0) return;
            currentTrackIndex = (currentTrackIndex - 1 + mp3Files.Length) % mp3Files.Length;
            PlayTrack(mp3Files[currentTrackIndex]);
            listView1.Items[currentTrackIndex].Selected = true;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string filePath = (string)listView1.SelectedItems[0].Tag;
                var tagFile = TagLib.File.Create(filePath);

                label2.Text = tagFile.Tag.Title ?? "";
                txtArtist.Text = tagFile.Tag.FirstPerformer ?? "";
                txtAlbum.Text = tagFile.Tag.Album ?? "";
            }
        }

        private void SaveTagsFromUI()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string filePath = (string)listView1.SelectedItems[0].Tag;
                var tagFile = TagLib.File.Create(filePath);

                tagFile.Tag.Title = txtTitle.Text;
                tagFile.Tag.Performers = new[] { txtArtist.Text };
                tagFile.Tag.Album = txtAlbum.Text;
                tagFile.Save();

                listView1.SelectedItems[0].SubItems[0].Text = txtTitle.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtArtist.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtAlbum.Text;
            }
        }
        private float leftLevel, rightLevel;

        private void panelVisualizer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelVisualizer_Paint_1(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.Black);

            int barWidth = 5;
            int barHeightLeft = (int)(leftLevel * panelVisualizer.Height);
            int barHeightRight = (int)(rightLevel * panelVisualizer.Height);

            g.FillRectangle(Brushes.Green, 0, 48 - barHeightLeft, barWidth, barHeightLeft);
            g.FillRectangle(Brushes.Blue, 5, panelVisualizer.Height - barHeightRight, barWidth, barHeightRight);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panelVisualizer.Visible = false;
            }
            else
            {
                panelVisualizer.Visible = true;
            }
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // --- Step 1: Draw the full row background ---
            Color backColor;
            if (e.Item.Selected)
                backColor = Color.FromArgb(70, 130, 180); // Selected color
            else if (e.Item.Index == hoveredIndex)
                backColor = Color.FromArgb(60, 60, 60); // Hovered color
            else
                // Alternating row colors
                backColor = e.Item.Index % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(45, 45, 45);

            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Set text colors based on state
            Color textColor = Color.LightGray;
            if (e.Item.Selected)
                textColor = Color.White;
            if (e.Item.Index == currentPlayingIndex)
                textColor = Color.LimeGreen;

            // --- Step 2: Draw the text for each subitem (column) ---
            // The first subitem is the main item itself
            // We get the bounds for each subitem to ensure correct positioning
            for (int i = 0; i < e.Item.SubItems.Count; i++)
            {
                var subItem = e.Item.SubItems[i];
                var subItemBounds = e.Item.SubItems[i].Bounds;

                TextRenderer.DrawText(
                    e.Graphics,
                    subItem.Text,
                    e.Item.Font,
                    subItemBounds,
                    textColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis
                );
            }

            // Prevents the default rendering from overriding our custom drawing
            e.DrawDefault = false;
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // This method remains unchanged and is correctly implemented
            using (var backBrush = new SolidBrush(Color.FromArgb(50, 50, 50)))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using (var pen = new Pen(Color.Black))
            {
                e.Graphics.DrawRectangle(pen, e.Bounds);
            }

            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis;

            TextRenderer.DrawText(
                e.Graphics,
                e.Header.Text,
                listView1.Font,
                e.Bounds,
                Color.White,
                flags
            );
        }



        private void listView1_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.GetItemAt(e.X, e.Y);
            int newIndex = item?.Index ?? -1;
            if (hoveredIndex != newIndex)
            {
                int oldIndex = hoveredIndex;
                hoveredIndex = newIndex;
                if (oldIndex >= 0) listView1.Invalidate(listView1.GetItemRect(oldIndex));
                if (hoveredIndex >= 0) listView1.Invalidate(listView1.GetItemRect(hoveredIndex));
            }
        }

        private void listView1_MouseLeave(object? sender, EventArgs e)
        {
            if (hoveredIndex >= 0)
            {
                listView1.Invalidate(listView1.GetItemRect(hoveredIndex));
                hoveredIndex = -1;
            }
        }

        private void panelProgress_Paint(object sender, PaintEventArgs e)
        {
            float progress = (float)trackBar1.Value / trackBar1.Maximum;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, 0, panelProgress.Width, panelProgress.Height);
            e.Graphics.FillRectangle(Brushes.LimeGreen, 0, 0, (int)(panelProgress.Width * progress), panelProgress.Height);
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, panelProgress.Width - 1, panelProgress.Height - 1);
        }

        private void panelVolume_Paint(object sender, PaintEventArgs e)
        {
            float volume = (float)volumeSlider1.Volume;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, 0, panelVolume.Width, panelVolume.Height);
            e.Graphics.FillRectangle(Brushes.Orange, 0, 0, (int)(panelVolume.Width * volume), panelVolume.Height);
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, panelVolume.Width - 1, panelVolume.Height - 1);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlaySelected();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (groupBox1.Height == 244)
            {
                groupBox1.Height = 53;
                label3.Visible = false;
            }
            else
            {
                groupBox1.Height = 244;
                label3.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelProgress.Invalidate();
            panelVolume.Invalidate();
            panelVisualizer.Invalidate();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listView1.Invalidate();
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            PlayInternetTrack("http://s2.cdnradio.ru/ru-mp3-128");
        }

        private void scrollingTitle_Tick(object sender, EventArgs e)
        {
            waitScroll.Interval = 250;
            waitScroll.Start();
        }

        private void waitScroll_Tick(object sender, EventArgs e)
        {
            if (label2.Text.Length > 40)
            {
                label2.Text = label2.Text.Substring(1) + label2.Text.Substring(0, 1);

            }
            else if (label2.Text.Length == 20)
            {
                label2.Text += " ";
                waitScroll.Stop();
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void aevionProgressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            if (audioFileReader != null && audioFileReader.TotalTime.TotalSeconds > 0)
            {
                // Calculate the new position as a fraction of the progress bar's width
                double fraction = (double)e.X / aevionProgressBar1.Width;

                // Calculate the new time in seconds
                double newTimeInSeconds = audioFileReader.TotalTime.TotalSeconds * fraction;

                // Update the current time of the audio file
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(newTimeInSeconds);
            }
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.TopItem = listView1.Items[e.NewValue];
            }
        }
    }
}
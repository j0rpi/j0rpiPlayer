//
//
//       _  ___             _ ____  _                       
//      (_)/ _ \ _ __ _ __ (_)  _ \| | __ _ _   _  ___ _ __ 
//      | | | | | '__| '_ \| | |_) | |/ _` | | | |/ _ \ '__|
//      | | |_| | |  | |_) | |  __/| | (_| | |_| |  __/ |   
//     _/ |\___/|_|  |.__/ |_|_|   |_|\__,_|\__, |\___|_|   
//    |__/           |_|                    |___/           
//
//    File: player.cs
//    Purpose: Main Player
//    Last Updated: 2025-08-30
//
//

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
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using static j0rpiPlayer.player;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;



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
        private float previousVolume = 1.0f;
        private WaveOutEvent waveOut;
        private SpotifyClient spotify;
        private EmbedIOAuthServer _server;
        private string clientId = "4eff2b0c284342e183dfe3dc215bbc1f";
        private string clientSecret = "4c452b953e274e3c8d808b444169fbcc";


        public enum PlayerMode
        {
            Local,
            Spotify
        }

        private PlayerMode currentMode = PlayerMode.Local;


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
            listView1.Columns.Add("", 360, HorizontalAlignment.Left);
            listView1.Columns.Add("", 50, HorizontalAlignment.Left);
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

            if (System.IO.File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.ini")))
            {

                IniFile ini = new IniFile();
                if (ini.GetValue("spotify", "authorized") == "0")

                {
                    InitSpotifyAuth();
                }

                string folderPath = ini.GetValue("settings", "lastfolder");
                lblMediaAdd.Visible = false;
                label8.Visible = false;
                LoadFolder(folderPath);
            }



        }

        private async Task InitSpotify()
        {
            var config = SpotifyClientConfig.CreateDefault();
            var request = new ClientCredentialsRequest(clientId, clientSecret);
            var response = await new OAuthClient(config).RequestToken(request);

            spotify = new SpotifyClient(config.WithToken(response.AccessToken));
            currentMode = PlayerMode.Spotify;

            IniFile ini = new IniFile();
            if (ini.GetValue("spotify", "authorized") == "0")
            {
                ini.SetValue("spotify", "authorized", "1");
            }
        }

        private async Task SearchSpotify(string query)
        {
            var search = await spotify.Search.Item(
                new SearchRequest(SearchRequest.Types.Track, query));

            listView1.Items.Clear();
            foreach (var track in search.Tracks.Items)
            {
                var item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(track.Artists[0].Name + " - " + track.Name);
                item.SubItems.Add(TimeSpan.FromMilliseconds(track.DurationMs).ToString(@"mm\:ss"));
                item.Tag = track;
                listView1.Items.Add(item);
            }
        }

        private async Task PlaySpotifyTrack(FullTrack track)
        {
            var devices = await spotify.Player.GetAvailableDevices();
            var activeDevice = devices.Devices.FirstOrDefault();

            if (activeDevice == null)
            {
                MessageBox.Show("No active Spotify device found. Open Spotify on Desktop or Mobile and try again.");
                return;
            }

            var request = new PlayerResumePlaybackRequest
            {
                DeviceId = activeDevice.Id,   // 👈 this is the magic
                Uris = new List<string> { track.Uri }
            };

            await spotify.Player.ResumePlayback(request);

            //lblTitle.Text = $"{track.Artists[0].Name} - {track.Name}";
            //lblDuration.Text = TimeSpan.FromMilliseconds(track.DurationMs).ToString(@"mm\:ss");
        }
        private async void LoadFolder(string folderPath)
        {
            IniFile ini = new IniFile();
            listView1.Items.Clear();
            listView1.BeginUpdate();
            lblMediaAdd.Visible = false;
            label8.Visible = false;
            int index = 1;
            this.Text = "j0rpiPlayer :: loading tracks...";


            if (System.IO.File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.ini")))
            {
                ini.SetValue("settings", "lastfolder", folderPath);
                ini.Save();
            }

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

                        item.SubItems.Add((tagFile.Tag.FirstPerformer ?? "Unknown") + " - " + (tagFile.Tag.Title ?? Path.GetFileNameWithoutExtension(file)));
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
            ini.Save();
        }



        private async void PlaySelected()
        {
            if (currentMode == PlayerMode.Local)
            {
                currentTrackIndex = listView1.SelectedItems[0].Index;
                PlayTrack(mp3Files[currentTrackIndex]);
            }
            else if (currentMode == PlayerMode.Spotify)
            {
                
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
            pictureBox1.Image = tagFile.Tag.Pictures.Length > 0 ? System.Drawing.Image.FromStream(new MemoryStream(tagFile.Tag.Pictures[0].Data.Data)) : Resources.nodisc;
            pictureBox2.Image = tagFile.Tag.Pictures.Length > 0 ? System.Drawing.Image.FromStream(new MemoryStream(tagFile.Tag.Pictures[0].Data.Data)) : Resources.nodiscsmall;


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

            //UpdateSpotifyPlayback();
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
            Color backColor;
            if (e.Item.Selected)
                backColor = Color.FromArgb(70, 130, 180);
            else if (e.Item.Index == hoveredIndex)
                backColor = Color.FromArgb(60, 60, 60);
            else
                backColor = e.Item.Index % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(45, 45, 45);

            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            Color textColor = Color.LightGray;
            if (e.Item.Selected)
                textColor = Color.White;
            if (e.Item.Index == currentPlayingIndex)
                textColor = Color.LimeGreen;

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

            e.DrawDefault = false;
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
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

        private void aevionProgressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            if (audioFileReader != null && audioFileReader.TotalTime.TotalSeconds > 0)
            {
                double fraction = (double)e.X / aevionProgressBar1.Width;
                double newTimeInSeconds = audioFileReader.TotalTime.TotalSeconds * fraction;

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

        private async Task InitSpotifyAuth()
        {

            IniFile ini = new IniFile();
            if (ini.GetValue("spotify", "authorized") == "0")
            {
                ini.SetValue("spotify", "authorized", "1");
                ini.Save();
            }

            var clientId = "4eff2b0c284342e183dfe3dc215bbc1f";
            var clientSecret = "4c452b953e274e3c8d808b444169fbcc";
            var redirectUri = "http://127.0.0.1:5000/callback";

            // Start a local server to catch Spotify callback
            _server = new EmbedIOAuthServer(new Uri(redirectUri), 5000);
            await _server.Start();

            _server.AuthorizationCodeReceived += async (sender, response) =>
            {
                await _server.Stop();

                var config = SpotifyClientConfig.CreateDefault();
                var oauth = new OAuthClient(config);

                // Exchange code for access + refresh token
                var tokenResponse = await oauth.RequestToken(
                    new AuthorizationCodeTokenRequest(
                        clientId,
                        clientSecret,
                        response.Code,
                        new Uri(redirectUri)
                    )
                );

                spotify = new SpotifyClient(tokenResponse.AccessToken);

                // Optional: store refresh token for next launch
                // ini.SetValue("spotify", "refresh_token", tokenResponse.RefreshToken);

                MessageBox.Show("Spotify login successful!");
            };

            // Ask user to login
            var loginRequest = new LoginRequest(
                new Uri(redirectUri),
                clientId,
                LoginRequest.ResponseType.Code
            )
            {
                Scope = new[]
                {
            Scopes.UserReadPlaybackState,
            Scopes.UserModifyPlaybackState,
            Scopes.UserReadCurrentlyPlaying
        }
            };

            var uri = loginRequest.ToUri();
            Process.Start(new ProcessStartInfo(uri.ToString()) { UseShellExecute = true });
        }
        private async Task UpdateSpotifyPlayback()
        {
            var playback = await spotify.Player.GetCurrentPlayback();
            if (playback?.Item is FullTrack track)
            {
                txtTitle.Text = $"{track.Artists[0].Name} - {track.Name}";
                aevionProgressBar1.Text = TimeSpan.FromMilliseconds(track.DurationMs).ToString(@"mm\:ss");
                aevionProgressBar1.Maximum = (int)track.DurationMs;
                aevionProgressBar1.Value = (int)playback.ProgressMs;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (spotifySearchPanel.Visible == true)
            {
                spotifySearchPanel.Visible = false;
            }
            else
            {
                spotifySearchPanel.Visible = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            currentMode = PlayerMode.Spotify;

            listView1.Items.Clear();
            try
            {
                if (spotify == null)
                    await InitSpotify();

                await SearchSpotify(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Spotify Error");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (label12.Text == "Z")
            {
                previousVolume = volumeSlider1.Volume; // save current volume
                volumeSlider1.Volume = 0;
                label12.Text = "-";
            }
            else
            {
                label12.Text = "Z";
                volumeSlider1.Volume = previousVolume; // restore saved volume
            }

        }

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if(currentMode == PlayerMode.Local)
                {
                    currentTrackIndex = listView1.SelectedItems[0].Index;
                    PlayTrack(mp3Files[currentTrackIndex]);
                }
                else if(currentMode == PlayerMode.Spotify)
                {
                var track = (FullTrack)listView1.SelectedItems[0].Tag;
                PlaySpotifyTrack(track);
                }
                    
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
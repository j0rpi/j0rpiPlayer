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
//    Last Updated: 2026-01-08
//
//

using DiscordRPC;
using DiscordRPC.Logging;
using j0rpiPlayer.Properties;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using ManagedBass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Formats.Tar;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using TagLib.Mpeg;
using INI;
using static j0rpiPlayer.player;
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
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private int bassStream = 0;
        private bool isPaused = false;
        private TimeSpan totalTime = TimeSpan.Zero;
        private TimeSpan currentTime = TimeSpan.Zero;
        private float previousVolume = 1.0f;
        public static DiscordRpcClient client;
        private int bassMusic = 0;
        private bool isBassPlaying = false;
        private bool useFractions;
        private bool useDiscordRPC;

        private static readonly HashSet<string> TrackerExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ".mod", ".xm", ".it", ".s3m", ".mtm", ".umx", ".mo3"
        };

        public enum PlayerMode
        {
            Local,
            Web,
            BassTracker
        }

        private PlayerMode currentMode = PlayerMode.Local;


        public player()
        {
            InitializeComponent();
            if (!Bass.Init())
            {
                MessageBox.Show("BASS failed to initialize." + Environment.NewLine + "Make sure bass.dll exists in application directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void player_Load(object sender, EventArgs e)
        {
            client = new DiscordRpcClient("1455005364050464950");
            client.Initialize();

            listView1.Visible = false;
            aevionProgressBar1.Text = "00:00 / 00:00";
            label2.AutoSize = true;
            scrollingTitle.Interval = 1500;
            scrollingTitle.Start();
            pictureBox2.Image = Resources.nodiscsmall;
            this.DoubleBuffered = true;
            timer1.Enabled = true;
            timer1.Interval = 16;
            progressTimer = new System.Windows.Forms.Timer();
            progressTimer.Interval = 1;

            listView1.View = View.Details;
            listView1.OwnerDraw = true;
            listView1.Scrollable = true;
            listView1.Columns.Add("#", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("track", 375, HorizontalAlignment.Left);
            listView1.Columns.Add("duration", 50, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;
            lblMediaAdd.Cursor = Cursors.Hand;

            progressTimer.Tick += ProgressTimer_Tick;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            listView1.DrawColumnHeader += listView1_DrawColumnHeader;
            listView1.DrawItem += listView1_DrawItem;
            listView1.MouseMove += listView1_MouseMove;
            listView1.MouseLeave += listView1_MouseLeave;
            volumeSlider1.VolumeChanged += volumeSlider1_VolumeChanged;
            panSlider1.Scroll += panSlider1_Scroll;

            btnPlay.Click += (s, e) => PlaySelected();
            btnPause.Click += (s, e) => PauseTrack();
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

                    pictureBox2.Image = Resources.nodiscsmall;

                    label2.Text = "no track currently playing ...";
                    lblBitrate.Text = "N/A";
                    lblChannels.Text = "N/A";

                    listView1.Visible = false;
                }
            };
            volumeSlider1.Volume = 1;
            IniFile config = new IniFile("config.ini");

            if (System.IO.File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini")))
            {
                string folderPath = config.IniReadValue("settings", "lastfolder");
                LoadFolder(folderPath);
                lblMediaAdd.Visible = false;
                label8.Visible = false;
            }

            if (config.IniReadValue("settings", "usefractions") == "true")
            {
                useFractions = true;
            }
            else
            {
                useFractions = false;
            }

        }
        private string GetTrackerDuration(string filePath)
        {
            int handle = Bass.MusicLoad(filePath, 0, 0, BassFlags.Prescan | BassFlags.Decode, 0);

            if (handle == 0)
                return "--:--";

            long lengthBytes = Bass.ChannelGetLength(handle, PositionFlags.Bytes);
            double seconds = Bass.ChannelBytes2Seconds(handle, lengthBytes);

            Bass.MusicFree(handle);

            return TimeSpan
                .FromSeconds(seconds)
                .ToString(@"mm\:ss");
        }

        private async void setSkin(string skinPath)
        {
            /*
            if (System.IO.File.Exists(skinPath + "/skin.ini") == true)
            {
                // Main Colors
                string playerBG = ini.GetValue("theme", "playerBG");
                string playerFontColor = ini.GetValue("theme", "playerFontColor");
                string playerFontFamily = ini.GetValue("theme", "playerFontFamily");
                string playerFontSize = ini.GetValue("theme", "playerFontSize");
                string playerBarForegroundColor = ini.GetValue("theme", "playerBarForegroundColor");
                string playerBarBackgroundColor = ini.GetValue("theme", "playerBarBoregroundColor");
                string PlayerbarDisplayBG = ini.GetValue("theme", "playerDisplayBG");
                string PlayerbarDisplayFontColor = ini.GetValue("theme", "PlayerbarDisplayFontColor");

                // Buttons
                string buttonBG = ini.GetValue("theme", "buttonBG");
                string buttonFontColor = ini.GetValue("theme", "buttonFontColor");
                string buttonBorderColor = ini.GetValue("theme", "buttonButtonBorderColor");

                // Playlist
                string playlistBG = ini.GetValue("theme", "playlistBG");
                string playlistCollumnColor = ini.GetValue("theme", "playlistCollumnColor");
                string playlistTrackFirstRow = ini.GetValue("theme", "playlistTrackFirstRow");
                string playlistTrackSecondRow = ini.GetValue("theme", "playlistTrackSecondRow");
                string playlistTrackPlaying = ini.GetValue("theme", "playlistTrackPlaying");
            }
            */
        }
        private async void LoadFolder(string folderPath)
        {
            animLoading.Visible = true;
            listView1.Items.Clear();
            lblMediaAdd.Visible = false;
            label8.Visible = false;
            this.Text = "j0rpiPlayer :: loading tracks...";

            try
            {
                var items = await Task.Run(() =>
                {
                    var list = new List<ListViewItem>();
                    int index = 1;

                    var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
                        .Where(f =>
                        {
                            string ext = Path.GetExtension(f);
                            return ext.Equals(".mp3", StringComparison.OrdinalIgnoreCase)
                                   || TrackerExtensions.Contains(ext);
                        });

                    foreach (var file in files)
                    {
                        try
                        {
                            string ext = Path.GetExtension(file).ToLowerInvariant();
                            string title;
                            string duration = "--:--";

                            if (TrackerExtensions.Contains(ext))
                            {
                                title = Path.GetFileNameWithoutExtension(file);
                                duration = GetTrackerDuration(file);
                            }
                            else
                            {
                                var tag = TagLib.File.Create(file);

                                string artist = tag.Tag.FirstPerformer;
                                string trackTitle = tag.Tag.Title;

                                if (string.IsNullOrWhiteSpace(artist) && string.IsNullOrWhiteSpace(trackTitle))
                                {
                                    title = Path.GetFileNameWithoutExtension(file);
                                }
                                else
                                {
                                    if (string.IsNullOrWhiteSpace(artist))
                                        artist = "Unknown";

                                    if (string.IsNullOrWhiteSpace(trackTitle))
                                        trackTitle = Path.GetFileNameWithoutExtension(file);

                                    title = $"{artist} - {trackTitle}";
                                }

                                duration = tag.Properties.Duration.ToString(@"mm\:ss");
                            }

                            var item = new ListViewItem(index.ToString());
                            item.SubItems.Add(title);
                            item.SubItems.Add(duration);
                            item.Tag = file;

                            list.Add(item);
                            index++;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Failed to load {file}: {ex.Message}");
                        }

                    }

                    return list;
                });

                listView1.BeginUpdate();
                listView1.Items.AddRange(items.ToArray());
                listView1.EndUpdate();

                if (listView1.Items.Count > 16)
                {
                    listView1.Columns[1].Width = 360;
                }
                else
                {
                    listView1.Columns[1].Width = 375;
                }
                string appPath = AppDomain.CurrentDomain.BaseDirectory;
                IniFile config = new IniFile("config.ini");

                config.IniWriteValue("settings", "lastfolder", folderPath);
                this.Text = $"j0rpiPlayer :: {items.Count} tracks loaded";
                animLoading.Visible = false;
                listView1.Visible = true;
            }
            catch
            {
                MessageBox.Show("There was a problem loading media from the last used folder." + Environment.NewLine + "Directory could not be found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMediaAdd.Visible = true;
                label8.Visible = true;
            }
        }
        private async void PlaySelected()
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            string filePath = listView1.SelectedItems[0].Tag as string;
            if (string.IsNullOrEmpty(filePath))
                return;

            string ext = Path.GetExtension(filePath);

            Stop();

            if (TrackerExtensions.Contains(ext))
            {
                PlayTrackerFile(filePath);
            }
            else
            {
                PlayTrack(filePath);
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
            string scannedArtist;
            string scannedTitle;
            meter = new MeteringSampleProvider(currentProvider);
            waveOut = new WaveOutEvent();
            waveOut.Init(meter);
            waveOut.Play();
            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;
            var duration = audioFileReader.TotalTime;
            trackBar1.Maximum = (int)duration.TotalSeconds;
            trackBar1.Value = 0;
            lblElapsed.Text = "00:00";
            var tagFile = TagLib.File.Create(filePath);
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

            if (tagFile.Tag.FirstPerformer == null && tagFile.Tag.Title == null)
            {
                label2.Text = Path.GetFileNameWithoutExtension(filePath);
                this.Text = Path.GetFileNameWithoutExtension(filePath);
                scannedArtist = Path.GetFileNameWithoutExtension(filePath);

            }
            else
            {
                label2.Text = tagFile.Tag.FirstPerformer + " - " + tagFile.Tag.Title;
                this.Text = tagFile.Tag.FirstPerformer + " - " + tagFile.Tag.Title;
                scannedArtist = tagFile.Tag.FirstPerformer;
                scannedTitle = tagFile.Tag.Title;
            }

            client.SetPresence(new RichPresence()
            {
                Details = tagFile.Tag.FirstPerformer ?? "Local",
                State = tagFile.Tag.Title ?? scannedArtist,
                Assets = new Assets()
                {
                    LargeImageKey = "jpicon3",
                    LargeImageText = "j0rpiPlayer",
                    SmallImageKey = "jpicon3"
                },
                Timestamps = Timestamps.Now
            });

            lblBitrate.Text = tagFile.Properties.AudioBitrate + " kbps";
            currentPlayingIndex = listView1.SelectedIndices[0];

        }
        private void PlayTrackerFile(string filePath)
        {
            Stop();
            progressTimer.Start();

            if (bassMusic != 0)
            {
                Bass.ChannelStop(bassMusic);
                Bass.MusicFree(bassMusic);
                bassMusic = 0;
            }

            bassMusic = Bass.MusicLoad(filePath, 0, 0, BassFlags.Loop | BassFlags.MusicRamp | BassFlags.Prescan | BassFlags.Float, 0);

            if (bassMusic == 0)
            {
                MessageBox.Show("Failed to load tracker: " + Bass.LastError);
                return;
            }

            Bass.ChannelSetAttribute(bassMusic, ChannelAttribute.Volume, volumeSlider1.Volume);
            Bass.ChannelPlay(bassMusic);
            label2.Text = Path.GetFileName(filePath);
            lblElapsed.Text = "00:00";
            lblBitrate.Text = "N/A";
            lblChannels.Text = "N/A";
            pictureBox2.Image = Resources.nodiscsmall;

            client.SetPresence(new RichPresence()
            {
                Details = "Tracker Module",
                State = Path.GetFileName(filePath),
                Assets = new Assets()
                {
                    LargeImageKey = "jpicon3",
                    LargeImageText = "j0rpiPlayer",
                    SmallImageKey = "jpicon3"
                },
                Timestamps = Timestamps.Now
            });

            isBassPlaying = true;
            listView1.Invalidate();
            this.Text = Path.GetFileName(filePath);
            currentPlayingIndex = listView1.SelectedIndices[0];
        }

        private void PlayInternetTrack(string filePath)
        {
            Stop();

            audioFileReader = new AudioFileReader(filePath);
            volProvider = new VolumeSampleProvider(audioFileReader);
            meter = new MeteringSampleProvider(volProvider);

            waveOut = new WaveOutEvent();
            waveOut.Init(meter);
            waveOut.Play();
            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;

            label2.Text = "internet stream: " + filePath;
            lblElapsed.Text = "Web";
            aevionProgressBar1.Text = "Internet Radio";

            pictureBox2.Image = Resources.nodiscsmall;

            listView1.Invalidate();

            client.SetPresence(new RichPresence()
            {
                Details = "Internet Stream",
                State = filePath.ToString(),
                Assets = new Assets()
                {
                    LargeImageKey = "jpicon3",
                    LargeImageText = "j0rpiPlayer",
                    SmallImageKey = "jpicon3"
                },
                Timestamps = Timestamps.Now
            });

        }
        private void Stop()
        {
            progressTimer.Stop();

            waveOut?.Stop();
            waveOut?.Dispose();
            audioFileReader?.Dispose();
            waveOut = null;
            audioFileReader = null;

            if (bassMusic != 0)
            {
                Bass.ChannelStop(bassMusic);
                Bass.MusicFree(bassMusic);
                bassMusic = 0;
            }

            trackBar1.Value = 0;
            lblElapsed.Text = "00:00";
        }

        private void volumeSlider1_VolumeChanged(object sender, EventArgs e)
        {
            if (volProvider != null)
            {
                volProvider.Volume = volumeSlider1.Volume;
            }

            if (isBassPlaying && bassMusic != 0)
            {
                Bass.ChannelSetAttribute(bassMusic, ChannelAttribute.Volume, volumeSlider1.Volume);
            }
        }
        private void panSlider1_Scroll(object sender, EventArgs e)
        {
            if (panningProvider != null)
            {
                panningProvider.Pan = panSlider1.Pan;
            }
        }
        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (audioFileReader != null && waveOut.PlaybackState == NAudio.Wave.PlaybackState.Stopped)
            {
                this.BeginInvoke(new Action(() => NextTrack()));
            }
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = TimeSpan.Zero;
            TimeSpan totalTime = TimeSpan.Zero;
            bool isPlaying = false;
            bool isTracker = false;

            if (audioFileReader != null && waveOut.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                currentTime = audioFileReader.CurrentTime;
                totalTime = audioFileReader.TotalTime;
                panningProvider.Pan = panSlider1.Pan;
                isPlaying = true;
            }
            else if (bassStream != 0 && ManagedBass.Bass.ChannelIsActive(bassStream) == ManagedBass.PlaybackState.Playing)
            {
                long pos = ManagedBass.Bass.ChannelGetPosition(bassStream);
                long len = ManagedBass.Bass.ChannelGetLength(bassStream);

                double currentSeconds = ManagedBass.Bass.ChannelBytes2Seconds(bassStream, pos);
                double totalSeconds = ManagedBass.Bass.ChannelBytes2Seconds(bassStream, len);
                if (totalSeconds <= 0) totalSeconds = 1;

                currentTime = TimeSpan.FromSeconds(currentSeconds);
                totalTime = TimeSpan.FromSeconds(totalSeconds);
                isPlaying = true;
            }
            else if (bassMusic != 0 &&
                     ManagedBass.Bass.ChannelIsActive(bassMusic) == ManagedBass.PlaybackState.Playing)
            {
                long pos = ManagedBass.Bass.ChannelGetPosition(bassMusic);
                long len = ManagedBass.Bass.ChannelGetLength(bassMusic);

                double currentSeconds = ManagedBass.Bass.ChannelBytes2Seconds(bassMusic, pos);
                double totalSeconds = ManagedBass.Bass.ChannelBytes2Seconds(bassMusic, len);

                if (totalSeconds <= 0) totalSeconds = 1;

                currentTime = TimeSpan.FromSeconds(currentSeconds);
                totalTime = TimeSpan.FromSeconds(totalSeconds);
                isPlaying = true;
                isTracker = true;
            }

            if (!isPlaying) return;
            double fraction = totalTime.TotalSeconds > 0 ? currentTime.TotalSeconds / totalTime.TotalSeconds : 0;

            if (isTracker)
            {
                fraction %= 1.0;
            }

            trackBar1.Maximum = Math.Max((int)totalTime.TotalSeconds, 1);
            trackBar1.Value = Math.Min((int)(fraction * trackBar1.Maximum), trackBar1.Maximum);

            aevionProgressBar1.Maximum = Math.Max((int)totalTime.TotalSeconds, 1);
            aevionProgressBar1.Value = Math.Min((int)(fraction * aevionProgressBar1.Maximum), aevionProgressBar1.Maximum);

            double percent = fraction * 100;

            lblElapsed.Text = currentTime.ToString(@"mm\:ss");
            if (useFractions == true)
            {
                aevionProgressBar1.Text = $"{lblElapsed.Text} / {totalTime.ToString(@"mm\:ss")} ({percent:0.0}%)";
            }
            else
            {
                aevionProgressBar1.Text = $"{lblElapsed.Text} / {totalTime.ToString(@"mm\:ss")}";
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

        private void PauseTrack()
        {
            var state = ManagedBass.Bass.ChannelIsActive(bassMusic);
            if (state == ManagedBass.PlaybackState.Playing)
            {
                ManagedBass.Bass.ChannelPause(bassMusic);
            }
            else
            {
                ManagedBass.Bass.ChannelPlay(bassMusic, false);
            }

            if (waveOut == null) return;

            if (waveOut.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                waveOut.Pause();
            }
            else
            {
                waveOut.Play();
            }
        }

        private void NextTrack()
        {
            if (listView1.Items.Count == 0) return;

            currentTrackIndex++;
            if (currentTrackIndex >= listView1.Items.Count)
            {
                currentTrackIndex = 0;
            }
            var item = listView1.Items[currentTrackIndex];
            listView1.SelectedItems.Clear();
            item.Selected = true;
            item.EnsureVisible();

            string path = (string)item.Tag;
            PlaySelected();
        }

        private void PrevTrack()
        {
            if (listView1.Items.Count == 0) return;

            currentTrackIndex--;
            if (currentTrackIndex < 0)
            {
                currentTrackIndex = listView1.Items.Count - 1;
            }

            var item = listView1.Items[currentTrackIndex];
            listView1.SelectedItems.Clear();
            item.Selected = true;
            item.EnsureVisible();

            string path = (string)item.Tag;
            PlaySelected();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string filePath = (string)listView1.SelectedItems[0].Tag;
                var tagFile = TagLib.File.Create(filePath);
                label2.Text = tagFile.Tag.Title ?? "";
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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlaySelected();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listView1.Invalidate();
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            if (webRadioPanel.Visible == true)
            {
                webRadioPanel.Visible = false;
                webRadioPanel2.Visible = false;
            }
            else
            {
                webRadioPanel.Visible = true;
                webRadioPanel2.Visible = true;
            }
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
            double fraction = (double)e.X / aevionProgressBar1.Width;

            if (audioFileReader != null && audioFileReader.TotalTime.TotalSeconds > 0)
            {
                double newTimeInSeconds = audioFileReader.TotalTime.TotalSeconds * fraction;
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(newTimeInSeconds);
            }
            else if (bassStream != 0)
            {
                long len = ManagedBass.Bass.ChannelGetLength(bassStream);
                double totalSeconds = ManagedBass.Bass.ChannelBytes2Seconds(bassStream, len);

                if (totalSeconds > 0)
                {
                    double newTimeInSeconds = totalSeconds * fraction;
                    long newPos = ManagedBass.Bass.ChannelSeconds2Bytes(bassStream, newTimeInSeconds);
                    ManagedBass.Bass.ChannelSetPosition(bassStream, newPos);
                }
            }
            else if (bassMusic != 0)
            {
                long len = ManagedBass.Bass.ChannelGetLength(bassMusic);
                double totalSeconds = ManagedBass.Bass.ChannelBytes2Seconds(bassMusic, len);

                if (totalSeconds <= 0) totalSeconds = 1;

                double newTimeInSeconds = totalSeconds * fraction;
                long newPos = ManagedBass.Bass.ChannelSeconds2Bytes(bassMusic, newTimeInSeconds);
                ManagedBass.Bass.ChannelSetPosition(bassMusic, newPos);
            }
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.TopItem = listView1.Items[e.NewValue];
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {
            if (label12.Text == "Z")
            {
                previousVolume = volumeSlider1.Volume;
                volumeSlider1.Volume = 0;
                label12.Text = "-";
            }
            else
            {
                label12.Text = "Z";
                volumeSlider1.Volume = previousVolume;
            }

        }

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            PlaySelected();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form settings = new settings();
            settings.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayInternetTrack(webURL.Text);
            volProvider.Volume = volumeSlider1.Volume;
            webRadioPanel.Visible = false;
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process discordJoin = new Process();

            try
            {
                discordJoin.StartInfo.UseShellExecute = true;
                discordJoin.StartInfo.FileName = "https://discord.com/invite/rwJ8KteJBt";
                discordJoin.Start();
            }
            catch
            {
                // It is highly unlikely the user does not have a browser installed
                // unless the user is a caveman living under a rock
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (trackerPanel1.Visible == true)
            {
                trackerPanel1.Visible = false;
                trackerPanel2.Visible = false;
            }
            else
            {
                trackerPanel1.Visible = true;
                trackerPanel2.Visible = true;
            }
        }

        private void player_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                searchPanel1.Visible = true;
                searchPanel2.Visible = true;
                searchPanelTitle.Visible = true;
                searchBox.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                searchPanel1.Visible = false;
                searchPanel2.Visible = false;
                searchPanelTitle.Visible = false;
            }

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchBox.Text;

            if (string.IsNullOrWhiteSpace(search))
                return;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems.Count > 1 &&
                    item.SubItems[1].Text.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listView1.SelectedItems.Clear();
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                    return;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
        }

        private void nextTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextTrack();
        }

        private void previousTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrevTrack();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PauseTrack();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaySelected();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
        private void openFileInExplorerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string filePath = (string)listView1.SelectedItems[0].Tag;
            string explorer = "/select, \"" + filePath + "\"";

            System.Diagnostics.Process.Start("explorer.exe", explorer);
        }

        private void removeFromPlaylistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }
    }
}
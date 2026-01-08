namespace j0rpiPlayer
{
    partial class player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player));
            btnPlay = new Button();
            btnStop = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            panel1 = new Panel();
            lblElapsed = new Label();
            pictureBox2 = new PictureBox();
            panelVisualizer = new Panel();
            displayShuffleIcon = new PictureBox();
            displayRepeatIcon = new PictureBox();
            displayPlaybackIcon = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            btnPause = new Button();
            btnLoadFolder = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblMediaAdd = new Label();
            label8 = new Label();
            lblBitrate = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            lblChannels = new Label();
            btnEject = new Button();
            btnStream = new Button();
            btnSettings = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            scrollingTitle = new System.Windows.Forms.Timer(components);
            waitScroll = new System.Windows.Forms.Timer(components);
            volumeSlider1 = new NAudio.Gui.VolumeSlider2();
            aevionProgressBar1 = new Aevion_r2.AevionProgressBar();
            aevionCheckBox1 = new Aevion_r2.AevionCheckBox();
            aevionCheckBox2 = new Aevion_r2.AevionCheckBox();
            panSlider1 = new NAudio.Gui.PanSlider2();
            listView1 = new ListView();
            webRadioPanel = new Panel();
            button1 = new Button();
            webURL = new TextBox();
            discordButton = new Button();
            trackerPanel1 = new Panel();
            aevionLabel6 = new Aevion_r2.AevionLabel();
            button3 = new Button();
            button2 = new Button();
            aevionLabel4 = new Aevion_r2.AevionLabel();
            aevionLabel3 = new Aevion_r2.AevionLabel();
            comboBox2 = new ComboBox();
            aevionLabel2 = new Aevion_r2.AevionLabel();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            animLoading = new PictureBox();
            trackerPanel2 = new Panel();
            aevionLabel1 = new Aevion_r2.AevionLabel();
            button4 = new Button();
            webRadioPanel2 = new Panel();
            aevionLabel5 = new Aevion_r2.AevionLabel();
            trackBar1 = new TrackBar();
            searchPanel1 = new Panel();
            searchBox = new TextBox();
            searchPanelTitle = new Aevion_r2.AevionLabel();
            searchPanel2 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            openFileInExplorerToolStripMenuItem1 = new ToolStripMenuItem();
            propertiesToolStripMenuItem1 = new ToolStripMenuItem();
            removeFromPlaylistToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            playToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            previousTrackToolStripMenuItem = new ToolStripMenuItem();
            nextTrackToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            volumeButton = new PictureBox();
            pauseIconTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelVisualizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displayShuffleIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)displayRepeatIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)displayPlaybackIcon).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            webRadioPanel.SuspendLayout();
            trackerPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)animLoading).BeginInit();
            trackerPanel2.SuspendLayout();
            webRadioPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            searchPanel1.SuspendLayout();
            searchPanel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeButton).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(48, 48, 48);
            btnPlay.BackgroundImage = Properties.Resources.icon_play24;
            btnPlay.BackgroundImageLayout = ImageLayout.Center;
            btnPlay.FlatAppearance.BorderColor = Color.DimGray;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Consolas", 9F);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(13, 95);
            btnPlay.Name = "btnPlay";
            btnPlay.Padding = new Padding(2, 0, 0, 0);
            btnPlay.Size = new Size(32, 32);
            btnPlay.TabIndex = 3;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(48, 48, 48);
            btnStop.BackgroundImage = Properties.Resources.icon_stop24;
            btnStop.BackgroundImageLayout = ImageLayout.Center;
            btnStop.FlatAppearance.BorderColor = Color.DimGray;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Consolas", 9F);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(89, 95);
            btnStop.Name = "btnStop";
            btnStop.Padding = new Padding(2, 0, 0, 0);
            btnStop.Size = new Size(32, 32);
            btnStop.TabIndex = 4;
            btnStop.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            btnPrev.AccessibleDescription = "btnPrev";
            btnPrev.BackColor = Color.FromArgb(48, 48, 48);
            btnPrev.BackgroundImage = Properties.Resources.icon_previous24;
            btnPrev.BackgroundImageLayout = ImageLayout.Center;
            btnPrev.FlatAppearance.BorderColor = Color.DimGray;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Consolas", 9F);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(127, 95);
            btnPrev.Name = "btnPrev";
            btnPrev.Padding = new Padding(2, 0, 0, 0);
            btnPrev.Size = new Size(32, 32);
            btnPrev.TabIndex = 5;
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.AccessibleDescription = "btnNext";
            btnNext.BackColor = Color.FromArgb(48, 48, 48);
            btnNext.BackgroundImage = Properties.Resources.icon_next24;
            btnNext.BackgroundImageLayout = ImageLayout.Center;
            btnNext.FlatAppearance.BorderColor = Color.DimGray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Consolas", 9F);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(166, 95);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(2, 0, 0, 0);
            btnNext.Size = new Size(32, 32);
            btnNext.TabIndex = 6;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblElapsed);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panelVisualizer);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(13, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 48);
            panel1.TabIndex = 7;
            // 
            // lblElapsed
            // 
            lblElapsed.AutoSize = true;
            lblElapsed.BackColor = Color.Transparent;
            lblElapsed.FlatStyle = FlatStyle.Flat;
            lblElapsed.Font = new Font("Digital-7", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblElapsed.ForeColor = Color.White;
            lblElapsed.Location = new Point(74, 4);
            lblElapsed.Name = "lblElapsed";
            lblElapsed.Size = new Size(91, 38);
            lblElapsed.TabIndex = 0;
            lblElapsed.Text = "00:00";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.nodiscsmall;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // panelVisualizer
            // 
            panelVisualizer.Controls.Add(displayShuffleIcon);
            panelVisualizer.Controls.Add(displayRepeatIcon);
            panelVisualizer.Controls.Add(displayPlaybackIcon);
            panelVisualizer.Location = new Point(48, 0);
            panelVisualizer.Name = "panelVisualizer";
            panelVisualizer.Size = new Size(23, 48);
            panelVisualizer.TabIndex = 16;
            // 
            // displayShuffleIcon
            // 
            displayShuffleIcon.BackColor = Color.Transparent;
            displayShuffleIcon.BackgroundImage = Properties.Resources.icon_shuffle16;
            displayShuffleIcon.BackgroundImageLayout = ImageLayout.Center;
            displayShuffleIcon.Location = new Point(3, 31);
            displayShuffleIcon.Name = "displayShuffleIcon";
            displayShuffleIcon.Size = new Size(16, 16);
            displayShuffleIcon.TabIndex = 46;
            displayShuffleIcon.TabStop = false;
            displayShuffleIcon.Visible = false;
            // 
            // displayRepeatIcon
            // 
            displayRepeatIcon.BackColor = Color.Transparent;
            displayRepeatIcon.BackgroundImage = Properties.Resources.icon_repeat16;
            displayRepeatIcon.BackgroundImageLayout = ImageLayout.Center;
            displayRepeatIcon.Location = new Point(3, 0);
            displayRepeatIcon.Name = "displayRepeatIcon";
            displayRepeatIcon.Size = new Size(16, 16);
            displayRepeatIcon.TabIndex = 45;
            displayRepeatIcon.TabStop = false;
            displayRepeatIcon.Visible = false;
            // 
            // displayPlaybackIcon
            // 
            displayPlaybackIcon.BackColor = Color.Transparent;
            displayPlaybackIcon.BackgroundImage = Properties.Resources.icon_play16;
            displayPlaybackIcon.BackgroundImageLayout = ImageLayout.Center;
            displayPlaybackIcon.Location = new Point(3, 16);
            displayPlaybackIcon.Name = "displayPlaybackIcon";
            displayPlaybackIcon.Size = new Size(16, 16);
            displayPlaybackIcon.TabIndex = 44;
            displayPlaybackIcon.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(191, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 21);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(271, 15);
            label2.TabIndex = 0;
            label2.Text = "j0rpiPlayer 0.815";
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.FromArgb(48, 48, 48);
            btnPause.BackgroundImage = Properties.Resources.icon_pause24;
            btnPause.BackgroundImageLayout = ImageLayout.Center;
            btnPause.FlatAppearance.BorderColor = Color.DimGray;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Consolas", 9F);
            btnPause.ForeColor = Color.White;
            btnPause.Location = new Point(51, 95);
            btnPause.Name = "btnPause";
            btnPause.Padding = new Padding(2, 0, 0, 0);
            btnPause.Size = new Size(32, 32);
            btnPause.TabIndex = 9;
            btnPause.Tag = "";
            btnPause.UseVisualStyleBackColor = false;
            // 
            // btnLoadFolder
            // 
            btnLoadFolder.BackColor = Color.FromArgb(48, 48, 48);
            btnLoadFolder.BackgroundImage = Properties.Resources.icon_addfolder24;
            btnLoadFolder.BackgroundImageLayout = ImageLayout.Center;
            btnLoadFolder.FlatAppearance.BorderColor = Color.DimGray;
            btnLoadFolder.FlatStyle = FlatStyle.Flat;
            btnLoadFolder.Font = new Font("Font 90 Icons", 14.25F);
            btnLoadFolder.ForeColor = Color.White;
            btnLoadFolder.Location = new Point(438, 474);
            btnLoadFolder.Name = "btnLoadFolder";
            btnLoadFolder.Padding = new Padding(3, 0, 0, 0);
            btnLoadFolder.Size = new Size(32, 32);
            btnLoadFolder.TabIndex = 10;
            btnLoadFolder.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblMediaAdd
            // 
            lblMediaAdd.AutoSize = true;
            lblMediaAdd.BackColor = Color.Transparent;
            lblMediaAdd.FlatStyle = FlatStyle.Flat;
            lblMediaAdd.Font = new Font("Font 90 Icons", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMediaAdd.ForeColor = Color.White;
            lblMediaAdd.Location = new Point(207, 260);
            lblMediaAdd.Name = "lblMediaAdd";
            lblMediaAdd.Size = new Size(70, 50);
            lblMediaAdd.TabIndex = 25;
            lblMediaAdd.Text = ";";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(207, 328);
            label8.Name = "label8";
            label8.Size = new Size(70, 14);
            label8.TabIndex = 24;
            label8.Text = "add media";
            // 
            // lblBitrate
            // 
            lblBitrate.AutoSize = true;
            lblBitrate.ForeColor = Color.White;
            lblBitrate.Location = new Point(6, 3);
            lblBitrate.Name = "lblBitrate";
            lblBitrate.Size = new Size(28, 14);
            lblBitrate.TabIndex = 13;
            lblBitrate.Text = "N/A";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblBitrate);
            panel3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(192, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(75, 21);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblChannels);
            panel4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(273, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(61, 21);
            panel4.TabIndex = 15;
            // 
            // lblChannels
            // 
            lblChannels.AutoSize = true;
            lblChannels.BackColor = Color.Black;
            lblChannels.ForeColor = Color.White;
            lblChannels.Location = new Point(6, 3);
            lblChannels.Name = "lblChannels";
            lblChannels.Size = new Size(28, 14);
            lblChannels.TabIndex = 13;
            lblChannels.Text = "N/A";
            // 
            // btnEject
            // 
            btnEject.BackColor = Color.FromArgb(48, 48, 48);
            btnEject.BackgroundImage = Properties.Resources.icon_eject24;
            btnEject.BackgroundImageLayout = ImageLayout.Center;
            btnEject.FlatAppearance.BorderColor = Color.DimGray;
            btnEject.FlatStyle = FlatStyle.Flat;
            btnEject.Font = new Font("Font 90 Icons", 14.25F);
            btnEject.ForeColor = Color.White;
            btnEject.Location = new Point(400, 474);
            btnEject.Name = "btnEject";
            btnEject.Padding = new Padding(2, 0, 0, 0);
            btnEject.Size = new Size(32, 32);
            btnEject.TabIndex = 18;
            btnEject.TextAlign = ContentAlignment.BottomCenter;
            btnEject.UseVisualStyleBackColor = false;
            // 
            // btnStream
            // 
            btnStream.BackColor = Color.FromArgb(48, 48, 48);
            btnStream.BackgroundImage = Properties.Resources.icon_webradio24;
            btnStream.BackgroundImageLayout = ImageLayout.Center;
            btnStream.FlatAppearance.BorderColor = Color.DimGray;
            btnStream.FlatStyle = FlatStyle.Flat;
            btnStream.Font = new Font("Font 90 Icons", 14.25F);
            btnStream.ForeColor = Color.White;
            btnStream.Location = new Point(362, 474);
            btnStream.Name = "btnStream";
            btnStream.Padding = new Padding(2, 0, 0, 0);
            btnStream.Size = new Size(32, 32);
            btnStream.TabIndex = 19;
            btnStream.TextAlign = ContentAlignment.BottomCenter;
            btnStream.UseVisualStyleBackColor = false;
            btnStream.Click += btnStream_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(48, 48, 48);
            btnSettings.BackgroundImage = Properties.Resources.icon_settings24;
            btnSettings.BackgroundImageLayout = ImageLayout.Center;
            btnSettings.FlatAppearance.BorderColor = Color.DimGray;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Font 90 Icons", 14.25F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(13, 475);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(2, 0, 0, 0);
            btnSettings.Size = new Size(32, 32);
            btnSettings.TabIndex = 22;
            btnSettings.TextAlign = ContentAlignment.BottomCenter;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // scrollingTitle
            // 
            scrollingTitle.Tick += scrollingTitle_Tick;
            // 
            // waitScroll
            // 
            waitScroll.Interval = 1500;
            waitScroll.Tick += waitScroll_Tick;
            // 
            // volumeSlider1
            // 
            volumeSlider1.BackColor = Color.Black;
            volumeSlider1.BorderStyle = BorderStyle.FixedSingle;
            volumeSlider1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volumeSlider1.ForeColor = Color.White;
            volumeSlider1.Location = new Point(362, 99);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Padding = new Padding(0, 2, 0, 0);
            volumeSlider1.Size = new Size(108, 24);
            volumeSlider1.TabIndex = 26;
            volumeSlider1.Volume = 0F;
            // 
            // aevionProgressBar1
            // 
            aevionProgressBar1.BackColor = Color.DimGray;
            aevionProgressBar1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionProgressBar1.ForeColor = Color.White;
            aevionProgressBar1.Location = new Point(13, 66);
            aevionProgressBar1.Maximum = 100;
            aevionProgressBar1.Minimum = 0;
            aevionProgressBar1.Name = "aevionProgressBar1";
            aevionProgressBar1.ShowText = true;
            aevionProgressBar1.Size = new Size(457, 19);
            aevionProgressBar1.TabIndex = 27;
            aevionProgressBar1.Text = "Track";
            aevionProgressBar1.Value = 0;
            aevionProgressBar1.MouseClick += aevionProgressBar1_MouseClick;
            // 
            // aevionCheckBox1
            // 
            aevionCheckBox1.Checked = false;
            aevionCheckBox1.Font = new Font("Segoe UI", 9F);
            aevionCheckBox1.Location = new Point(340, 42);
            aevionCheckBox1.Name = "aevionCheckBox1";
            aevionCheckBox1.Size = new Size(75, 16);
            aevionCheckBox1.TabIndex = 28;
            aevionCheckBox1.Text = "shuffle";
            aevionCheckBox1.CheckedChanged += aevionCheckBox1_CheckedChanged;
            // 
            // aevionCheckBox2
            // 
            aevionCheckBox2.Checked = false;
            aevionCheckBox2.Font = new Font("Segoe UI", 9F);
            aevionCheckBox2.Location = new Point(409, 42);
            aevionCheckBox2.Name = "aevionCheckBox2";
            aevionCheckBox2.Size = new Size(75, 16);
            aevionCheckBox2.TabIndex = 29;
            aevionCheckBox2.Text = "repeat";
            aevionCheckBox2.CheckedChanged += aevionCheckBox2_CheckedChanged;
            // 
            // panSlider1
            // 
            panSlider1.BackColor = Color.Black;
            panSlider1.BorderStyle = BorderStyle.FixedSingle;
            panSlider1.ForeColor = Color.White;
            panSlider1.Location = new Point(215, 99);
            panSlider1.Name = "panSlider1";
            panSlider1.Pan = 0F;
            panSlider1.Size = new Size(108, 24);
            panSlider1.TabIndex = 34;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(60, 60, 60);
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.ForeColor = Color.White;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(13, 138);
            listView1.Name = "listView1";
            listView1.OwnerDraw = true;
            listView1.Scrollable = false;
            listView1.Size = new Size(457, 330);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DrawColumnHeader += listView1_DrawColumnHeader;
            listView1.MouseClick += listView1_MouseClick;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick_1;
            // 
            // webRadioPanel
            // 
            webRadioPanel.BorderStyle = BorderStyle.FixedSingle;
            webRadioPanel.Controls.Add(button1);
            webRadioPanel.Controls.Add(webURL);
            webRadioPanel.Location = new Point(89, 408);
            webRadioPanel.Name = "webRadioPanel";
            webRadioPanel.Size = new Size(305, 50);
            webRadioPanel.TabIndex = 37;
            webRadioPanel.Visible = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(231, 7);
            button1.Name = "button1";
            button1.Size = new Size(64, 35);
            button1.TabIndex = 1;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // webURL
            // 
            webURL.BackColor = Color.FromArgb(64, 64, 64);
            webURL.BorderStyle = BorderStyle.FixedSingle;
            webURL.ForeColor = Color.White;
            webURL.Location = new Point(9, 13);
            webURL.Name = "webURL";
            webURL.PlaceholderText = "Stream URL ...";
            webURL.Size = new Size(215, 22);
            webURL.TabIndex = 0;
            // 
            // discordButton
            // 
            discordButton.BackColor = Color.FromArgb(48, 48, 48);
            discordButton.BackgroundImage = Properties.Resources.icon_discord;
            discordButton.BackgroundImageLayout = ImageLayout.Center;
            discordButton.FlatAppearance.BorderColor = Color.DimGray;
            discordButton.FlatStyle = FlatStyle.Flat;
            discordButton.Font = new Font("Font 90 Icons", 14.25F);
            discordButton.ForeColor = Color.White;
            discordButton.Location = new Point(51, 475);
            discordButton.Name = "discordButton";
            discordButton.Padding = new Padding(2, 0, 0, 0);
            discordButton.Size = new Size(32, 32);
            discordButton.TabIndex = 38;
            discordButton.TextAlign = ContentAlignment.BottomCenter;
            discordButton.UseVisualStyleBackColor = false;
            discordButton.Click += discordButton_Click;
            // 
            // trackerPanel1
            // 
            trackerPanel1.BorderStyle = BorderStyle.FixedSingle;
            trackerPanel1.Controls.Add(aevionLabel6);
            trackerPanel1.Controls.Add(button3);
            trackerPanel1.Controls.Add(button2);
            trackerPanel1.Controls.Add(aevionLabel4);
            trackerPanel1.Controls.Add(aevionLabel3);
            trackerPanel1.Controls.Add(comboBox2);
            trackerPanel1.Controls.Add(aevionLabel2);
            trackerPanel1.Controls.Add(comboBox1);
            trackerPanel1.Controls.Add(textBox1);
            trackerPanel1.Location = new Point(51, 266);
            trackerPanel1.Name = "trackerPanel1";
            trackerPanel1.Size = new Size(305, 192);
            trackerPanel1.TabIndex = 38;
            trackerPanel1.Visible = false;
            // 
            // aevionLabel6
            // 
            aevionLabel6.AutoSize = true;
            aevionLabel6.BackColor = Color.Transparent;
            aevionLabel6.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionLabel6.ForeColor = Color.IndianRed;
            aevionLabel6.Location = new Point(181, 3);
            aevionLabel6.Name = "aevionLabel6";
            aevionLabel6.Size = new Size(119, 14);
            aevionLabel6.TabIndex = 42;
            aevionLabel6.Text = "Not Implemented ";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.icon_modsettings24;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Font 90 Icons", 14.25F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(259, 141);
            button3.Name = "button3";
            button3.Padding = new Padding(2, 0, 0, 0);
            button3.Size = new Size(32, 32);
            button3.TabIndex = 41;
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.instruments;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Font 90 Icons", 14.25F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(221, 141);
            button2.Name = "button2";
            button2.Padding = new Padding(2, 0, 0, 0);
            button2.Size = new Size(32, 32);
            button2.TabIndex = 40;
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // aevionLabel4
            // 
            aevionLabel4.AutoSize = true;
            aevionLabel4.BackColor = Color.Transparent;
            aevionLabel4.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionLabel4.ForeColor = Color.White;
            aevionLabel4.Location = new Point(9, 124);
            aevionLabel4.Name = "aevionLabel4";
            aevionLabel4.Size = new Size(91, 14);
            aevionLabel4.TabIndex = 5;
            aevionLabel4.Text = "Module Speed";
            // 
            // aevionLabel3
            // 
            aevionLabel3.AutoSize = true;
            aevionLabel3.BackColor = Color.Transparent;
            aevionLabel3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionLabel3.ForeColor = Color.White;
            aevionLabel3.Location = new Point(7, 65);
            aevionLabel3.Name = "aevionLabel3";
            aevionLabel3.Size = new Size(140, 14);
            aevionLabel3.TabIndex = 4;
            aevionLabel3.Text = "Tracker / Mod Style";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(64, 64, 64);
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "MOD (ProTracker) - 4 Channels" });
            comboBox2.Location = new Point(7, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(270, 22);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "MOD (ProTracker) - 4 Channels";
            // 
            // aevionLabel2
            // 
            aevionLabel2.AutoSize = true;
            aevionLabel2.BackColor = Color.Transparent;
            aevionLabel2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionLabel2.ForeColor = Color.White;
            aevionLabel2.Location = new Point(7, 14);
            aevionLabel2.Name = "aevionLabel2";
            aevionLabel2.Size = new Size(98, 14);
            aevionLabel2.TabIndex = 2;
            aevionLabel2.Text = "Interpolation";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(64, 64, 64);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Default (Polyphase)" });
            comboBox1.Location = new Point(7, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 22);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Default (Polyphase)";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(7, 141);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Stream URL ...";
            textBox1.Size = new Size(107, 22);
            textBox1.TabIndex = 0;
            textBox1.Text = "125 BPM";
            // 
            // animLoading
            // 
            animLoading.BackgroundImageLayout = ImageLayout.Stretch;
            animLoading.Image = Properties.Resources.loading3;
            animLoading.Location = new Point(180, 246);
            animLoading.Name = "animLoading";
            animLoading.Size = new Size(125, 129);
            animLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            animLoading.TabIndex = 43;
            animLoading.TabStop = false;
            animLoading.Visible = false;
            // 
            // trackerPanel2
            // 
            trackerPanel2.BorderStyle = BorderStyle.FixedSingle;
            trackerPanel2.Controls.Add(aevionLabel1);
            trackerPanel2.Location = new Point(51, 242);
            trackerPanel2.Name = "trackerPanel2";
            trackerPanel2.Size = new Size(200, 25);
            trackerPanel2.TabIndex = 39;
            trackerPanel2.Visible = false;
            // 
            // aevionLabel1
            // 
            aevionLabel1.AutoSize = true;
            aevionLabel1.BackColor = Color.Transparent;
            aevionLabel1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionLabel1.ForeColor = Color.White;
            aevionLabel1.Location = new Point(3, 5);
            aevionLabel1.Name = "aevionLabel1";
            aevionLabel1.Size = new Size(168, 14);
            aevionLabel1.TabIndex = 0;
            aevionLabel1.Text = "Tracker Module Settings";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(48, 48, 48);
            button4.BackgroundImage = Properties.Resources.icon_modsettings24;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Font 90 Icons", 14.25F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(324, 474);
            button4.Name = "button4";
            button4.Padding = new Padding(2, 0, 0, 0);
            button4.Size = new Size(32, 32);
            button4.TabIndex = 42;
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // webRadioPanel2
            // 
            webRadioPanel2.BorderStyle = BorderStyle.FixedSingle;
            webRadioPanel2.Controls.Add(aevionLabel5);
            webRadioPanel2.Location = new Point(89, 384);
            webRadioPanel2.Name = "webRadioPanel2";
            webRadioPanel2.Size = new Size(200, 25);
            webRadioPanel2.TabIndex = 40;
            webRadioPanel2.Visible = false;
            // 
            // aevionLabel5
            // 
            aevionLabel5.AutoSize = true;
            aevionLabel5.BackColor = Color.Transparent;
            aevionLabel5.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionLabel5.ForeColor = Color.White;
            aevionLabel5.Location = new Point(1, 5);
            aevionLabel5.Name = "aevionLabel5";
            aevionLabel5.Size = new Size(105, 14);
            aevionLabel5.TabIndex = 0;
            aevionLabel5.Text = "Internet Radio";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(15, 781);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(469, 45);
            trackBar1.TabIndex = 0;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Visible = false;
            // 
            // searchPanel1
            // 
            searchPanel1.BorderStyle = BorderStyle.FixedSingle;
            searchPanel1.Controls.Add(searchBox);
            searchPanel1.Location = new Point(142, 406);
            searchPanel1.Name = "searchPanel1";
            searchPanel1.Size = new Size(305, 50);
            searchPanel1.TabIndex = 38;
            searchPanel1.Visible = false;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(64, 64, 64);
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(9, 14);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Keyword ...";
            searchBox.Size = new Size(286, 22);
            searchBox.TabIndex = 0;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchPanelTitle
            // 
            searchPanelTitle.AutoSize = true;
            searchPanelTitle.BackColor = Color.Transparent;
            searchPanelTitle.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPanelTitle.ForeColor = Color.White;
            searchPanelTitle.Location = new Point(4, 6);
            searchPanelTitle.Name = "searchPanelTitle";
            searchPanelTitle.Size = new Size(112, 14);
            searchPanelTitle.TabIndex = 0;
            searchPanelTitle.Text = "Filter Playlist";
            // 
            // searchPanel2
            // 
            searchPanel2.BorderStyle = BorderStyle.FixedSingle;
            searchPanel2.Controls.Add(searchPanelTitle);
            searchPanel2.Location = new Point(142, 382);
            searchPanel2.Name = "searchPanel2";
            searchPanel2.Size = new Size(200, 25);
            searchPanel2.TabIndex = 40;
            searchPanel2.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            contextMenuStrip1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { openFileInExplorerToolStripMenuItem1, propertiesToolStripMenuItem1, removeFromPlaylistToolStripMenuItem1, toolStripSeparator1, playToolStripMenuItem, pauseToolStripMenuItem, previousTrackToolStripMenuItem, nextTrackToolStripMenuItem, toolStripSeparator2, settingsToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.Size = new Size(222, 220);
            // 
            // openFileInExplorerToolStripMenuItem1
            // 
            openFileInExplorerToolStripMenuItem1.Font = new Font("Consolas", 9F);
            openFileInExplorerToolStripMenuItem1.ForeColor = Color.White;
            openFileInExplorerToolStripMenuItem1.Image = Properties.Resources.icon_folder16;
            openFileInExplorerToolStripMenuItem1.Name = "openFileInExplorerToolStripMenuItem1";
            openFileInExplorerToolStripMenuItem1.Size = new Size(221, 22);
            openFileInExplorerToolStripMenuItem1.Text = "Open File In Explorer";
            openFileInExplorerToolStripMenuItem1.Click += openFileInExplorerToolStripMenuItem1_Click;
            // 
            // propertiesToolStripMenuItem1
            // 
            propertiesToolStripMenuItem1.Font = new Font("Consolas", 9F);
            propertiesToolStripMenuItem1.ForeColor = Color.White;
            propertiesToolStripMenuItem1.Image = Properties.Resources.icon_info16;
            propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            propertiesToolStripMenuItem1.Size = new Size(221, 22);
            propertiesToolStripMenuItem1.Text = "Properties";
            // 
            // removeFromPlaylistToolStripMenuItem1
            // 
            removeFromPlaylistToolStripMenuItem1.BackgroundImageLayout = ImageLayout.None;
            removeFromPlaylistToolStripMenuItem1.Font = new Font("Consolas", 9F);
            removeFromPlaylistToolStripMenuItem1.ForeColor = Color.White;
            removeFromPlaylistToolStripMenuItem1.Image = Properties.Resources.icon_closeremove16;
            removeFromPlaylistToolStripMenuItem1.Name = "removeFromPlaylistToolStripMenuItem1";
            removeFromPlaylistToolStripMenuItem1.Size = new Size(221, 22);
            removeFromPlaylistToolStripMenuItem1.Text = "Remove From Playlist";
            removeFromPlaylistToolStripMenuItem1.Click += removeFromPlaylistToolStripMenuItem1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(218, 6);
            // 
            // playToolStripMenuItem
            // 
            playToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            playToolStripMenuItem.Font = new Font("Consolas", 9F);
            playToolStripMenuItem.ForeColor = Color.White;
            playToolStripMenuItem.Image = Properties.Resources.icon_play16;
            playToolStripMenuItem.Name = "playToolStripMenuItem";
            playToolStripMenuItem.Size = new Size(221, 22);
            playToolStripMenuItem.Text = "Play";
            playToolStripMenuItem.Click += playToolStripMenuItem_Click;
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            pauseToolStripMenuItem.Font = new Font("Consolas", 9F);
            pauseToolStripMenuItem.ForeColor = Color.White;
            pauseToolStripMenuItem.Image = Properties.Resources.icon_pause16;
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(221, 22);
            pauseToolStripMenuItem.Text = "Pause";
            pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // previousTrackToolStripMenuItem
            // 
            previousTrackToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            previousTrackToolStripMenuItem.Font = new Font("Consolas", 9F);
            previousTrackToolStripMenuItem.ForeColor = Color.White;
            previousTrackToolStripMenuItem.Image = Properties.Resources.icon_previous16;
            previousTrackToolStripMenuItem.Name = "previousTrackToolStripMenuItem";
            previousTrackToolStripMenuItem.Size = new Size(221, 22);
            previousTrackToolStripMenuItem.Text = "Previous Track";
            previousTrackToolStripMenuItem.Click += previousTrackToolStripMenuItem_Click;
            // 
            // nextTrackToolStripMenuItem
            // 
            nextTrackToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            nextTrackToolStripMenuItem.Font = new Font("Consolas", 9F);
            nextTrackToolStripMenuItem.ForeColor = Color.White;
            nextTrackToolStripMenuItem.Image = Properties.Resources.icon_next16;
            nextTrackToolStripMenuItem.Name = "nextTrackToolStripMenuItem";
            nextTrackToolStripMenuItem.Size = new Size(221, 22);
            nextTrackToolStripMenuItem.Text = "Next Track";
            nextTrackToolStripMenuItem.Click += nextTrackToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(218, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            settingsToolStripMenuItem.Font = new Font("Consolas", 9F);
            settingsToolStripMenuItem.ForeColor = Color.White;
            settingsToolStripMenuItem.Image = Properties.Resources.icon_settings16;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(221, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(218, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            exitToolStripMenuItem.Font = new Font("Consolas", 9F);
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Image = Properties.Resources.icon_exit16;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(221, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // volumeButton
            // 
            volumeButton.BackColor = Color.Black;
            volumeButton.BackgroundImageLayout = ImageLayout.Zoom;
            volumeButton.BorderStyle = BorderStyle.FixedSingle;
            volumeButton.Image = Properties.Resources.icon_volume24;
            volumeButton.InitialImage = null;
            volumeButton.Location = new Point(332, 99);
            volumeButton.Name = "volumeButton";
            volumeButton.Size = new Size(24, 24);
            volumeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            volumeButton.TabIndex = 44;
            volumeButton.TabStop = false;
            volumeButton.Click += volumeButton_Click;
            // 
            // pauseIconTimer
            // 
            pauseIconTimer.Interval = 500;
            pauseIconTimer.Tick += pauseIconTimer_Tick;
            // 
            // player
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(485, 520);
            Controls.Add(volumeButton);
            Controls.Add(searchPanel2);
            Controls.Add(searchPanel1);
            Controls.Add(animLoading);
            Controls.Add(webRadioPanel2);
            Controls.Add(button4);
            Controls.Add(trackerPanel2);
            Controls.Add(trackerPanel1);
            Controls.Add(discordButton);
            Controls.Add(webRadioPanel);
            Controls.Add(lblMediaAdd);
            Controls.Add(label8);
            Controls.Add(listView1);
            Controls.Add(panSlider1);
            Controls.Add(aevionCheckBox2);
            Controls.Add(aevionCheckBox1);
            Controls.Add(aevionProgressBar1);
            Controls.Add(volumeSlider1);
            Controls.Add(btnSettings);
            Controls.Add(btnStream);
            Controls.Add(trackBar1);
            Controls.Add(btnEject);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnLoadFolder);
            Controls.Add(btnPause);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "player";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "j0rpiPlayer :: I'm Not Whippin' The Llamas Ass!";
            Load += player_Load;
            KeyDown += player_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelVisualizer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)displayShuffleIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)displayRepeatIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)displayPlaybackIcon).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            webRadioPanel.ResumeLayout(false);
            webRadioPanel.PerformLayout();
            trackerPanel1.ResumeLayout(false);
            trackerPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)animLoading).EndInit();
            trackerPanel2.ResumeLayout(false);
            trackerPanel2.PerformLayout();
            webRadioPanel2.ResumeLayout(false);
            webRadioPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            searchPanel1.ResumeLayout(false);
            searchPanel1.PerformLayout();
            searchPanel2.ResumeLayout(false);
            searchPanel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)volumeButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPlay;
        private Button btnStop;
        private Button btnPrev;
        private Button btnNext;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button btnPause;
        private Button btnLoadFolder;
        private OpenFileDialog openFileDialog1;
        private Label lblBitrate;
        private Panel panel3;
        private Panel panel4;
        private Label lblChannels;
        private Panel panelVisualizer;
        private Button btnEject;
        private Button btnStream;
        private Button btnSettings;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer scrollingTitle;
        private System.Windows.Forms.Timer waitScroll;
        private NAudio.Gui.VolumeSlider2 volumeSlider1;
        private Aevion_r2.AevionProgressBar aevionProgressBar1;
        private Aevion_r2.AevionCheckBox aevionCheckBox1;
        private Aevion_r2.AevionCheckBox aevionCheckBox2;
        private NAudio.Gui.PanSlider2 panSlider1;
        private Label label8;
        private Label lblMediaAdd;
        private ListView listView1;
        private Label lblElapsed;
        private Panel webRadioPanel;
        private Button button1;
        private TextBox webURL;
        private Button discordButton;
        private Panel trackerPanel1;
        private TextBox textBox1;
        private Panel trackerPanel2;
        private Aevion_r2.AevionLabel aevionLabel1;
        private Aevion_r2.AevionLabel aevionLabel3;
        private ComboBox comboBox2;
        private Aevion_r2.AevionLabel aevionLabel2;
        private ComboBox comboBox1;
        private Aevion_r2.AevionLabel aevionLabel4;
        private Button button4;
        private Panel webRadioPanel2;
        private Aevion_r2.AevionLabel aevionLabel5;
        private TrackBar trackBar1;
        private Aevion_r2.AevionLabel aevionLabel6;
        private PictureBox animLoading;
        private Panel searchPanel1;
        private TextBox searchBox;
        private Aevion_r2.AevionLabel searchPanelTitle;
        private Panel searchPanel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem playToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem previousTrackToolStripMenuItem;
        private ToolStripMenuItem nextTrackToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem openFileInExplorerToolStripMenuItem1;
        private ToolStripMenuItem removeFromPlaylistToolStripMenuItem1;
        private ToolStripMenuItem propertiesToolStripMenuItem1;
        private PictureBox displayPlaybackIcon;
        private Button button3;
        private Button button2;
        private PictureBox volumeButton;
        private System.Windows.Forms.Timer pauseIconTimer;
        private PictureBox displayShuffleIcon;
        private PictureBox displayRepeatIcon;
    }
}
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
            label12 = new Label();
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
            trackerPanel2 = new Panel();
            aevionLabel1 = new Aevion_r2.AevionLabel();
            button4 = new Button();
            webRadioPanel2 = new Panel();
            aevionLabel5 = new Aevion_r2.AevionLabel();
            trackBar1 = new TrackBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            webRadioPanel.SuspendLayout();
            trackerPanel1.SuspendLayout();
            trackerPanel2.SuspendLayout();
            webRadioPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.FlatAppearance.BorderColor = Color.DimGray;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Font 90 Icons", 14.25F);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(13, 87);
            btnPlay.Name = "btnPlay";
            btnPlay.Padding = new Padding(2, 0, 0, 0);
            btnPlay.Size = new Size(32, 32);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "D";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.BackgroundImageLayout = ImageLayout.None;
            btnStop.FlatAppearance.BorderColor = Color.DimGray;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Font 90 Icons", 14.25F);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(89, 87);
            btnStop.Name = "btnStop";
            btnStop.Padding = new Padding(2, 0, 0, 0);
            btnStop.Size = new Size(32, 32);
            btnStop.TabIndex = 4;
            btnStop.Text = "F";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            btnPrev.AccessibleDescription = "btnPrev";
            btnPrev.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrev.FlatAppearance.BorderColor = Color.DimGray;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Font 90 Icons", 14.25F);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(127, 87);
            btnPrev.Name = "btnPrev";
            btnPrev.Padding = new Padding(2, 0, 0, 0);
            btnPrev.Size = new Size(32, 32);
            btnPrev.TabIndex = 5;
            btnPrev.Text = "G";
            btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.AccessibleDescription = "btnNext";
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.FlatAppearance.BorderColor = Color.DimGray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Font 90 Icons", 14.25F);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(166, 87);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(2, 0, 0, 0);
            btnNext.Size = new Size(32, 32);
            btnNext.TabIndex = 6;
            btnNext.Text = "B";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
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
            lblElapsed.Font = new Font("DS-Digital", 30F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblElapsed.ForeColor = Color.White;
            lblElapsed.Location = new Point(60, 4);
            lblElapsed.Name = "lblElapsed";
            lblElapsed.Size = new Size(106, 40);
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
            panelVisualizer.Location = new Point(48, 0);
            panelVisualizer.Name = "panelVisualizer";
            panelVisualizer.Size = new Size(10, 48);
            panelVisualizer.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(191, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 21);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(273, 15);
            label2.TabIndex = 0;
            label2.Text = "j0rpiPlayer 0.811";
            // 
            // btnPause
            // 
            btnPause.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.FlatAppearance.BorderColor = Color.DimGray;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Font 90 Icons", 14.25F);
            btnPause.ForeColor = Color.White;
            btnPause.Location = new Point(51, 87);
            btnPause.Name = "btnPause";
            btnPause.Padding = new Padding(2, 0, 0, 0);
            btnPause.Size = new Size(32, 32);
            btnPause.TabIndex = 9;
            btnPause.Tag = "";
            btnPause.Text = "C";
            btnPause.UseVisualStyleBackColor = true;
            // 
            // btnLoadFolder
            // 
            btnLoadFolder.FlatAppearance.BorderColor = Color.DimGray;
            btnLoadFolder.FlatStyle = FlatStyle.Flat;
            btnLoadFolder.Font = new Font("Font 90 Icons", 14.25F);
            btnLoadFolder.ForeColor = Color.White;
            btnLoadFolder.Location = new Point(438, 474);
            btnLoadFolder.Name = "btnLoadFolder";
            btnLoadFolder.Padding = new Padding(3, 0, 0, 0);
            btnLoadFolder.Size = new Size(32, 32);
            btnLoadFolder.TabIndex = 10;
            btnLoadFolder.Text = ";";
            btnLoadFolder.UseVisualStyleBackColor = true;
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
            lblBitrate.Location = new Point(6, 4);
            lblBitrate.Name = "lblBitrate";
            lblBitrate.Size = new Size(28, 14);
            lblBitrate.TabIndex = 13;
            lblBitrate.Text = "N/A";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
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
            lblChannels.Location = new Point(6, 4);
            lblChannels.Name = "lblChannels";
            lblChannels.Size = new Size(28, 14);
            lblChannels.TabIndex = 13;
            lblChannels.Text = "N/A";
            // 
            // btnEject
            // 
            btnEject.FlatAppearance.BorderColor = Color.DimGray;
            btnEject.FlatStyle = FlatStyle.Flat;
            btnEject.Font = new Font("Font 90 Icons", 14.25F);
            btnEject.ForeColor = Color.White;
            btnEject.Location = new Point(400, 474);
            btnEject.Name = "btnEject";
            btnEject.Padding = new Padding(2, 0, 0, 0);
            btnEject.Size = new Size(32, 32);
            btnEject.TabIndex = 18;
            btnEject.Text = "J";
            btnEject.TextAlign = ContentAlignment.BottomCenter;
            btnEject.UseVisualStyleBackColor = true;
            // 
            // btnStream
            // 
            btnStream.FlatAppearance.BorderColor = Color.DimGray;
            btnStream.FlatStyle = FlatStyle.Flat;
            btnStream.Font = new Font("Font 90 Icons", 14.25F);
            btnStream.ForeColor = Color.White;
            btnStream.Location = new Point(362, 474);
            btnStream.Name = "btnStream";
            btnStream.Padding = new Padding(2, 0, 0, 0);
            btnStream.Size = new Size(32, 32);
            btnStream.TabIndex = 19;
            btnStream.Text = "O";
            btnStream.TextAlign = ContentAlignment.BottomCenter;
            btnStream.UseVisualStyleBackColor = true;
            btnStream.Click += btnStream_Click;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderColor = Color.DimGray;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Font 90 Icons", 14.25F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(13, 475);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(2, 0, 0, 0);
            btnSettings.Size = new Size(32, 32);
            btnSettings.TabIndex = 22;
            btnSettings.Text = "w";
            btnSettings.TextAlign = ContentAlignment.BottomCenter;
            btnSettings.UseVisualStyleBackColor = true;
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
            volumeSlider1.BackColor = Color.FromArgb(64, 0, 64);
            volumeSlider1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volumeSlider1.ForeColor = Color.White;
            volumeSlider1.Location = new Point(362, 91);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Padding = new Padding(0, 2, 0, 0);
            volumeSlider1.Size = new Size(108, 24);
            volumeSlider1.TabIndex = 26;
            volumeSlider1.Volume = 0F;
            // 
            // aevionProgressBar1
            // 
            aevionProgressBar1.BackColor = Color.FromArgb(64, 0, 64);
            aevionProgressBar1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionProgressBar1.ForeColor = Color.White;
            aevionProgressBar1.Location = new Point(13, 66);
            aevionProgressBar1.Maximum = 100;
            aevionProgressBar1.Minimum = 0;
            aevionProgressBar1.Name = "aevionProgressBar1";
            aevionProgressBar1.ShowText = true;
            aevionProgressBar1.Size = new Size(460, 15);
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
            // 
            // panSlider1
            // 
            panSlider1.BackColor = Color.FromArgb(64, 0, 64);
            panSlider1.ForeColor = Color.White;
            panSlider1.Location = new Point(215, 91);
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
            listView1.MouseDoubleClick += listView1_MouseDoubleClick_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Font 90 Icons", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(335, 93);
            label12.Name = "label12";
            label12.Size = new Size(28, 20);
            label12.TabIndex = 36;
            label12.Text = "Z";
            label12.Click += label12_Click;
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
            discordButton.BackgroundImage = Properties.Resources.discord_white_icon1;
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
            discordButton.UseVisualStyleBackColor = true;
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
            button3.BackgroundImage = Properties.Resources.tracker;
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
            aevionLabel4.Location = new Point(3, 124);
            aevionLabel4.Name = "aevionLabel4";
            aevionLabel4.Size = new Size(140, 14);
            aevionLabel4.TabIndex = 5;
            aevionLabel4.Text = "Tracker / Mod Style";
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
            button4.Text = "x";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
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
            // player
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(485, 520);
            Controls.Add(webRadioPanel2);
            Controls.Add(button4);
            Controls.Add(trackerPanel2);
            Controls.Add(trackerPanel1);
            Controls.Add(discordButton);
            Controls.Add(webRadioPanel);
            Controls.Add(lblMediaAdd);
            Controls.Add(label8);
            Controls.Add(label12);
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
            MaximizeBox = false;
            Name = "player";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "j0rpiPlayer :: I'm Not Whippin' The Llamas Ass!";
            Load += player_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            webRadioPanel.ResumeLayout(false);
            webRadioPanel.PerformLayout();
            trackerPanel1.ResumeLayout(false);
            trackerPanel1.PerformLayout();
            trackerPanel2.ResumeLayout(false);
            trackerPanel2.PerformLayout();
            webRadioPanel2.ResumeLayout(false);
            webRadioPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
        private Label label12;
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel webRadioPanel2;
        private Aevion_r2.AevionLabel aevionLabel5;
        private TrackBar trackBar1;
        private Aevion_r2.AevionLabel aevionLabel6;
    }
}
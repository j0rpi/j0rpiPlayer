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
            trackBar1 = new TrackBar();
            btnPlay = new Button();
            btnStop = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            panel1 = new Panel();
            lblElapsed = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            panelVisualizer = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            btnPause = new Button();
            btnLoadFolder = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblTotal = new Label();
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            lblMediaAdd = new Label();
            label8 = new Label();
            txtFreq = new Label();
            checkBox1 = new CheckBox();
            txtBitrate = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            panelVolume = new Panel();
            label5 = new Label();
            txtAlbum = new Label();
            panelProgress = new Panel();
            label4 = new Label();
            txtTitle = new Label();
            txtArtist = new Label();
            lblBitrate = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            lblChannels = new Label();
            label6 = new Label();
            btnEject = new Button();
            btnStream = new Button();
            btnSettings = new Button();
            linkLabel1 = new LinkLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            scrollingTitle = new System.Windows.Forms.Timer(components);
            waitScroll = new System.Windows.Forms.Timer(components);
            volumeSlider1 = new NAudio.Gui.VolumeSlider2();
            aevionProgressBar1 = new Aevion_r2.AevionProgressBar();
            aevionCheckBox1 = new Aevion_r2.AevionCheckBox();
            aevionCheckBox2 = new Aevion_r2.AevionCheckBox();
            volumeMeter1 = new NAudio.Gui.VolumeMeter();
            volumeMeter2 = new NAudio.Gui.VolumeMeter();
            label9 = new Label();
            label10 = new Label();
            panSlider1 = new NAudio.Gui.PanSlider2();
            label11 = new Label();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelVolume.SuspendLayout();
            panelProgress.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(-1, -9);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(469, 45);
            trackBar1.TabIndex = 0;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Visible = false;
            // 
            // btnPlay
            // 
            btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnPlay.FlatAppearance.BorderSize = 2;
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
            // 
            // btnStop
            // 
            btnStop.BackgroundImageLayout = ImageLayout.None;
            btnStop.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnStop.FlatAppearance.BorderSize = 2;
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
            btnPrev.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnPrev.FlatAppearance.BorderSize = 2;
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
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnNext.FlatAppearance.BorderSize = 2;
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
            panel1.Controls.Add(label7);
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
            lblElapsed.Location = new Point(60, 5);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("DS-Digital", 30F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(60, 5);
            label7.Name = "label7";
            label7.Size = new Size(106, 40);
            label7.TabIndex = 23;
            label7.Text = "00:00";
            // 
            // panelVisualizer
            // 
            panelVisualizer.Location = new Point(48, 0);
            panelVisualizer.Name = "panelVisualizer";
            panelVisualizer.Size = new Size(10, 48);
            panelVisualizer.TabIndex = 16;
            panelVisualizer.Paint += panelVisualizer_Paint_1;
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
            label2.Text = "welcome :) ";
            // 
            // btnPause
            // 
            btnPause.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnPause.FlatAppearance.BorderSize = 2;
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
            btnLoadFolder.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnLoadFolder.FlatAppearance.BorderSize = 2;
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
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(106, 115);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(63, 15);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "lblTotal";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(lblMediaAdd);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtFreq);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(txtBitrate);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(panelVolume);
            groupBox1.Controls.Add(txtAlbum);
            groupBox1.Controls.Add(panelProgress);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtArtist);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(13, 521);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 244);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(302, 130);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(140, 15);
            linkLabel2.TabIndex = 24;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "invalidate listview";
            linkLabel2.VisitedLinkColor = Color.White;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // lblMediaAdd
            // 
            lblMediaAdd.AutoSize = true;
            lblMediaAdd.BackColor = Color.FromArgb(60, 60, 60);
            lblMediaAdd.FlatStyle = FlatStyle.Flat;
            lblMediaAdd.Font = new Font("Font 90 Icons", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMediaAdd.ForeColor = Color.White;
            lblMediaAdd.Location = new Point(14, 80);
            lblMediaAdd.Name = "lblMediaAdd";
            lblMediaAdd.Size = new Size(70, 50);
            lblMediaAdd.TabIndex = 25;
            lblMediaAdd.Text = ";";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(60, 60, 60);
            label8.ForeColor = Color.White;
            label8.Location = new Point(14, 148);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 24;
            label8.Text = "add media";
            // 
            // txtFreq
            // 
            txtFreq.AutoSize = true;
            txtFreq.Location = new Point(106, 145);
            txtFreq.Name = "txtFreq";
            txtFreq.Size = new Size(56, 15);
            txtFreq.TabIndex = 24;
            txtFreq.Text = "txtFreq";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(304, 148);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "disable vu meter";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtBitrate
            // 
            txtBitrate.AutoSize = true;
            txtBitrate.Location = new Point(106, 130);
            txtBitrate.Name = "txtBitrate";
            txtBitrate.Size = new Size(77, 15);
            txtBitrate.TabIndex = 23;
            txtBitrate.Text = "txtBitrate";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.PikPng_com_gorditas_png_3315155;
            pictureBox3.Location = new Point(430, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(12, 12);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nodisc;
            pictureBox1.Location = new Point(9, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 42);
            label3.Name = "label3";
            label3.Size = new Size(448, 15);
            label3.TabIndex = 20;
            label3.Text = "_______________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 24);
            label1.Name = "label1";
            label1.Size = new Size(245, 15);
            label1.TabIndex = 19;
            label1.Text = "debug tools - for those with ballz";
            // 
            // panelVolume
            // 
            panelVolume.Controls.Add(label5);
            panelVolume.Location = new Point(6, 207);
            panelVolume.Name = "panelVolume";
            panelVolume.Size = new Size(448, 25);
            panelVolume.TabIndex = 18;
            panelVolume.Paint += panelVolume_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 5);
            label5.Name = "label5";
            label5.Size = new Size(315, 15);
            label5.TabIndex = 0;
            label5.Text = "playback latency: 0ms    decode latency: 0ms";
            // 
            // txtAlbum
            // 
            txtAlbum.AutoSize = true;
            txtAlbum.Location = new Point(106, 101);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(63, 15);
            txtAlbum.TabIndex = 2;
            txtAlbum.Text = "txtAlbum";
            // 
            // panelProgress
            // 
            panelProgress.Controls.Add(label4);
            panelProgress.Location = new Point(6, 176);
            panelProgress.Name = "panelProgress";
            panelProgress.Size = new Size(448, 25);
            panelProgress.TabIndex = 17;
            panelProgress.Paint += panelProgress_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 5);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 0;
            label4.Text = "cpu usage: < 1%";
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Location = new Point(106, 87);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(63, 15);
            txtTitle.TabIndex = 1;
            txtTitle.Text = "txtTitle";
            // 
            // txtArtist
            // 
            txtArtist.AutoSize = true;
            txtArtist.Location = new Point(106, 73);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(70, 15);
            txtArtist.TabIndex = 0;
            txtArtist.Text = "txtArtist";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(166, 768);
            label6.Name = "label6";
            label6.Size = new Size(152, 14);
            label6.TabIndex = 17;
            label6.Text = "made with ❤️ by j0rpi";
            // 
            // btnEject
            // 
            btnEject.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnEject.FlatAppearance.BorderSize = 2;
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
            btnStream.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnStream.FlatAppearance.BorderSize = 2;
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
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            btnSettings.FlatAppearance.BorderSize = 2;
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
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(156, 782);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(175, 14);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/j0rpi";
            linkLabel1.VisitedLinkColor = Color.White;
            // 
            // timer1
            // 
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
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
            volumeSlider1.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            volumeSlider1.Location = new Point(343, 87);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Padding = new Padding(0, 2, 0, 0);
            volumeSlider1.Size = new Size(130, 32);
            volumeSlider1.TabIndex = 26;
            volumeSlider1.Volume = 0F;
            // 
            // aevionProgressBar1
            // 
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
            // volumeMeter1
            // 
            volumeMeter1.Amplitude = 0F;
            volumeMeter1.Location = new Point(204, 87);
            volumeMeter1.MaxDb = 18F;
            volumeMeter1.MinDb = -60F;
            volumeMeter1.Name = "volumeMeter1";
            volumeMeter1.Size = new Size(13, 32);
            volumeMeter1.TabIndex = 30;
            volumeMeter1.Text = "L";
            // 
            // volumeMeter2
            // 
            volumeMeter2.Amplitude = 0F;
            volumeMeter2.Location = new Point(223, 87);
            volumeMeter2.MaxDb = 18F;
            volumeMeter2.MinDb = -60F;
            volumeMeter2.Name = "volumeMeter2";
            volumeMeter2.Size = new Size(13, 32);
            volumeMeter2.TabIndex = 31;
            volumeMeter2.Text = "volumeMeter2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(203, 122);
            label9.Name = "label9";
            label9.Size = new Size(14, 14);
            label9.TabIndex = 32;
            label9.Text = "L";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(222, 122);
            label10.Name = "label10";
            label10.Size = new Size(14, 14);
            label10.TabIndex = 33;
            label10.Text = "R";
            // 
            // panSlider1
            // 
            panSlider1.Location = new Point(247, 95);
            panSlider1.Name = "panSlider1";
            panSlider1.Pan = 0F;
            panSlider1.Size = new Size(90, 16);
            panSlider1.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(279, 122);
            label11.Name = "label11";
            label11.Size = new Size(28, 14);
            label11.TabIndex = 35;
            label11.Text = "Pan";
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
            // 
            // player
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(485, 805);
            Controls.Add(listView1);
            Controls.Add(label11);
            Controls.Add(panSlider1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(volumeMeter2);
            Controls.Add(volumeMeter1);
            Controls.Add(aevionCheckBox2);
            Controls.Add(aevionCheckBox1);
            Controls.Add(aevionProgressBar1);
            Controls.Add(volumeSlider1);
            Controls.Add(linkLabel1);
            Controls.Add(btnSettings);
            Controls.Add(btnStream);
            Controls.Add(btnEject);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(groupBox1);
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
            Text = "j0rpiPlayer :: alpha 0.1";
            Load += player_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelVolume.ResumeLayout(false);
            panelVolume.PerformLayout();
            panelProgress.ResumeLayout(false);
            panelProgress.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Button btnPlay;
        private Button btnStop;
        private Button btnPrev;
        private Button btnNext;
        private Panel panel1;
        private Label lblElapsed;
        private Panel panel2;
        private Label label2;
        private Button btnPause;
        private Button btnLoadFolder;
        private OpenFileDialog openFileDialog1;
        private Label lblTotal;
        private GroupBox groupBox1;
        private Label txtAlbum;
        private Label txtTitle;
        private Label txtArtist;
        private Label lblBitrate;
        private Panel panel3;
        private Panel panel4;
        private Label lblChannels;
        private Panel panelVisualizer;
        private CheckBox checkBox1;
        private Panel panelProgress;
        private Panel panelVolume;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button btnEject;
        private Button btnStream;
        private Button btnSettings;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label txtBitrate;
        private Label txtFreq;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private LinkLabel linkLabel2;
        private System.Windows.Forms.Timer scrollingTitle;
        private System.Windows.Forms.Timer waitScroll;
        private NAudio.Gui.VolumeSlider2 volumeSlider1;
        private Aevion_r2.AevionProgressBar aevionProgressBar1;
        private Aevion_r2.AevionCheckBox aevionCheckBox1;
        private Aevion_r2.AevionCheckBox aevionCheckBox2;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private NAudio.Gui.VolumeMeter volumeMeter2;
        private Label label9;
        private Label label10;
        private NAudio.Gui.PanSlider2 panSlider1;
        private Label label11;
        private Label label8;
        private Label lblMediaAdd;
        private ListView listView1;
    }
}
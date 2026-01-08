namespace j0rpiPlayer
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            groupBox1 = new GroupBox();
            aevionLabel5 = new Aevion_r2.AevionLabel();
            comboBox2 = new ComboBox();
            aevionLabel1 = new Aevion_r2.AevionLabel();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            useFractions = new Aevion_r2.AevionCheckBox();
            shuffle = new Aevion_r2.AevionCheckBox();
            useDiscordRPC = new Aevion_r2.AevionCheckBox();
            groupBox3 = new GroupBox();
            autoCheckUpdates = new Aevion_r2.AevionCheckBox();
            groupBox4 = new GroupBox();
            aevionLabel2 = new Aevion_r2.AevionLabel();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            aevionLabel3 = new Aevion_r2.AevionLabel();
            aevionLabel4 = new Aevion_r2.AevionLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(aevionLabel5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(aevionLabel1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(14, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appearance";
            // 
            // aevionLabel5
            // 
            aevionLabel5.AutoSize = true;
            aevionLabel5.BackColor = Color.Transparent;
            aevionLabel5.Font = new Font("Consolas", 9F);
            aevionLabel5.ForeColor = Color.White;
            aevionLabel5.Location = new Point(6, 63);
            aevionLabel5.Name = "aevionLabel5";
            aevionLabel5.Size = new Size(42, 14);
            aevionLabel5.TabIndex = 4;
            aevionLabel5.Text = "Theme";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(64, 64, 64);
            comboBox2.Enabled = false;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 22);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Default";
            // 
            // aevionLabel1
            // 
            aevionLabel1.AutoSize = true;
            aevionLabel1.BackColor = Color.Transparent;
            aevionLabel1.Font = new Font("Consolas", 9F);
            aevionLabel1.ForeColor = Color.White;
            aevionLabel1.Location = new Point(6, 18);
            aevionLabel1.Name = "aevionLabel1";
            aevionLabel1.Size = new Size(42, 14);
            aevionLabel1.TabIndex = 2;
            aevionLabel1.Text = "Theme";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(64, 64, 64);
            comboBox1.Enabled = false;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 22);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Default";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(useFractions);
            groupBox2.Controls.Add(shuffle);
            groupBox2.Controls.Add(useDiscordRPC);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(177, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Playback";
            // 
            // useFractions
            // 
            useFractions.Checked = false;
            useFractions.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            useFractions.Location = new Point(11, 70);
            useFractions.Name = "useFractions";
            useFractions.Size = new Size(243, 16);
            useFractions.TabIndex = 2;
            useFractions.Text = "Show Elapsed In Percentage";
            useFractions.CheckedChanged += useFractions_CheckedChanged;
            // 
            // shuffle
            // 
            shuffle.Checked = false;
            shuffle.Font = new Font("Consolas", 9F);
            shuffle.Location = new Point(11, 24);
            shuffle.Name = "shuffle";
            shuffle.Size = new Size(104, 16);
            shuffle.TabIndex = 1;
            shuffle.Text = "Shuffle Playlist";
            shuffle.CheckedChanged += shuffle_CheckedChanged;
            // 
            // useDiscordRPC
            // 
            useDiscordRPC.Checked = false;
            useDiscordRPC.Font = new Font("Consolas", 9F);
            useDiscordRPC.Location = new Point(11, 48);
            useDiscordRPC.Name = "useDiscordRPC";
            useDiscordRPC.Size = new Size(245, 16);
            useDiscordRPC.TabIndex = 0;
            useDiscordRPC.Text = "Enable Discord Rich Presence";
            useDiscordRPC.CheckedChanged += useDiscordRPC_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(autoCheckUpdates);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(14, 135);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 56);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Updates";
            // 
            // autoCheckUpdates
            // 
            autoCheckUpdates.Checked = false;
            autoCheckUpdates.Font = new Font("Consolas", 9F);
            autoCheckUpdates.Location = new Point(13, 24);
            autoCheckUpdates.Name = "autoCheckUpdates";
            autoCheckUpdates.Size = new Size(200, 16);
            autoCheckUpdates.TabIndex = 0;
            autoCheckUpdates.Text = "Always Check For Updates";
            autoCheckUpdates.CheckedChanged += autoCheckUpdates_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(aevionLabel2);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(14, 197);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(425, 207);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Plugins / Scripts";
            // 
            // aevionLabel2
            // 
            aevionLabel2.AutoSize = true;
            aevionLabel2.BackColor = Color.Transparent;
            aevionLabel2.Font = new Font("Consolas", 9F);
            aevionLabel2.ForeColor = Color.White;
            aevionLabel2.Location = new Point(54, 118);
            aevionLabel2.Name = "aevionLabel2";
            aevionLabel2.Size = new Size(315, 14);
            aevionLabel2.TabIndex = 0;
            aevionLabel2.Text = "There are no plugins or scripts installed :(";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(138, 457);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(175, 14);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/j0rpi";
            linkLabel1.VisitedLinkColor = Color.White;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(148, 443);
            label6.Name = "label6";
            label6.Size = new Size(152, 14);
            label6.TabIndex = 24;
            label6.Text = "made with ❤️ by j0rpi";
            // 
            // aevionLabel3
            // 
            aevionLabel3.AutoSize = true;
            aevionLabel3.BackColor = Color.Transparent;
            aevionLabel3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionLabel3.ForeColor = Color.White;
            aevionLabel3.Location = new Point(33, 407);
            aevionLabel3.Name = "aevionLabel3";
            aevionLabel3.Size = new Size(385, 14);
            aevionLabel3.TabIndex = 26;
            aevionLabel3.Text = "Uses NAudio for Playback, BASS.NET for tracker modules";
            // 
            // aevionLabel4
            // 
            aevionLabel4.AutoSize = true;
            aevionLabel4.BackColor = Color.Transparent;
            aevionLabel4.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aevionLabel4.ForeColor = Color.White;
            aevionLabel4.Location = new Point(362, 457);
            aevionLabel4.Name = "aevionLabel4";
            aevionLabel4.Size = new Size(77, 14);
            aevionLabel4.TabIndex = 27;
            aevionLabel4.Text = "ver: 0.815";
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(451, 484);
            Controls.Add(aevionLabel4);
            Controls.Add(aevionLabel3);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "j0rpiPlayer :: Settings";
            Load += settings_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Aevion_r2.AevionLabel aevionLabel1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Aevion_r2.AevionCheckBox shuffle;
        private Aevion_r2.AevionCheckBox useDiscordRPC;
        private GroupBox groupBox3;
        private Aevion_r2.AevionCheckBox autoCheckUpdates;
        private GroupBox groupBox4;
        private Aevion_r2.AevionLabel aevionLabel2;
        private LinkLabel linkLabel1;
        private Label label6;
        private Aevion_r2.AevionLabel aevionLabel3;
        private Aevion_r2.AevionLabel aevionLabel4;
        private Aevion_r2.AevionCheckBox useFractions;
        private Aevion_r2.AevionLabel aevionLabel5;
        private ComboBox comboBox2;
    }
}
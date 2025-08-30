namespace j0rpiPlayer
{
    partial class startupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startupForm));
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(459, 118);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 136);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Alright, don't nag me again.";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(228, 133);
            button1.Name = "button1";
            button1.Size = new Size(243, 23);
            button1.TabIndex = 2;
            button1.Text = "Launch j0rpiPlayer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // startupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 168);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "startupForm";
            Text = "j0rpiPlayer :: First Startup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CheckBox checkBox1;
        private Button button1;
    }
}

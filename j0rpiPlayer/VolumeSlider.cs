using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace NAudio.Gui
{
    /// <summary>
    /// VolumeSlider control
    /// </summary>
    public class VolumeSlider2 : System.Windows.Forms.UserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private float volume = 1.0f;
        private float MinDb = -48;
        /// <summary>
        /// Volume changed event
        /// </summary>
        public event EventHandler VolumeChanged;

        /// <summary>
        /// Creates a new VolumeSlider control
        /// </summary>
        public VolumeSlider2()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitComponent call
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // VolumeSlider2
            // 
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "VolumeSlider2";
            Size = new Size(96, 16);
            ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// <see cref="Control.OnPaint"/>
        /// </summary>
        protected override void OnPaint(PaintEventArgs pe)
        {
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            using (Pen borderPen = new Pen(Color.FromArgb(255, 50, 50, 50)))
            {
                pe.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }

            // Calculate the percentage (0.0 to 1.0)
            float percent = Volume;

            // Calculate the width of the fill bar based on the percentage
            pe.Graphics.FillRectangle(Brushes.Purple, 1, 1, (int)((this.Width - 2) * percent), this.Height - 2);

            // Format the text to display percentage
            string percentValue = String.Format("{0:F0}%", percent * 100);

            // Draw the percentage text
            pe.Graphics.DrawString(percentValue, this.Font,
                Brushes.White, this.ClientRectangle, format);
        }

        /// <summary>
        /// <see cref="Control.OnMouseMove"/>
        /// </summary>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetVolumeFromMouse(e.X);
            }
            base.OnMouseMove(e);
        }

        /// <summary>
        /// <see cref="Control.OnMouseDown"/>
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            SetVolumeFromMouse(e.X);
            base.OnMouseDown(e);
        }

        private void SetVolumeFromMouse(int x)
        {
            // Clamp the mouse X position between 0 and the control's width.
            int clampedX = Math.Max(0, Math.Min(this.Width, x));

            // Calculate the new volume as a linear percentage of the slider's width.
            float newVolume = (float)clampedX / this.Width;

            // Use the public Volume property to trigger the change and redraw.
            // The property's setter already handles clamping and event firing.
            Volume = newVolume;
        }

        /// <summary>
        /// The volume for this control
        /// </summary>
        [DefaultValue(1.0f)]
        public float Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < 0.0f)
                    value = 0.0f;
                if (value > 1.0f)
                    value = 1.0f;
                if (volume != value)
                {
                    volume = value;
                    if (VolumeChanged != null)
                        VolumeChanged(this, EventArgs.Empty);
                    Invalidate();
                }
            }
        }
    }
}

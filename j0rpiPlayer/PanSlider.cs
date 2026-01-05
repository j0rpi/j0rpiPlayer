using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TagLib;

namespace NAudio.Gui
{
	/// <summary>
	/// Pan slider control
	/// </summary>
	public class PanSlider2 : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private float pan;

        /// <summary>
        /// True when pan value changed
        /// </summary>
		public event EventHandler PanChanged;

        /// <summary>
        /// Creates a new PanSlider control
        /// </summary>
		public PanSlider2()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// PanSlider
			// 
			this.Name = "PanSlider";
			this.Size = new System.Drawing.Size(104, 16);

		}
        #endregion

        /// <summary>
        /// <see cref="Control.OnPaint"/>
        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };

            string panValue;

			// Ugly fix for the impossibility of setting pan value to 0	
			if(pan > -0.02f && pan < 0.02f)
			{
                //pan = 0.0f;
            }

            // Draw pan rectangles FIRST (so they are behind)
            if (pan == 0.0)
            {
              
                panValue = "Pan";
            }
            else if (pan > 0)
            {
                pe.Graphics.FillRectangle(Brushes.Purple,
                    (this.Width / 2), 1,
                    (int)((this.Width / 2) * pan), this.Height - 2);
                panValue = string.Format("{0:F0}% Right", pan * 100);
            }
            else
            {
                pe.Graphics.FillRectangle(Brushes.Purple,
                    (int)((this.Width / 2) * (pan + 1)), 1,
                    (int)((this.Width / 2) * (0 - pan)), this.Height - 2);
                panValue = string.Format("{0:F0}% Left", pan * -100);
            }

            // Then draw the background image ON TOP
            int imgHeight = (int)(this.Height * 0.8);
            int imgY = (this.Height - imgHeight) / 2;
            pe.Graphics.DrawImage(global::j0rpiPlayer.Properties.Resources.panbars3,
                new Rectangle(0, 11, this.Width, 12));

            // Border
            using (Pen borderPen = new Pen(Color.FromArgb(255, 50, 50, 50)))
            {
                pe.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }

            // Text
            using (Brush textBrush = new SolidBrush(Color.White))
            {
                pe.Graphics.DrawString(panValue, this.Font, textBrush, this.ClientRectangle, format);
            }
        }


        /// <summary>
        /// <see cref="Control.OnMouseMove"/>
        /// </summary>
        protected override void OnMouseMove(MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				SetPanFromMouse(e.X);
			}
			base.OnMouseMove (e);
		}

		/// <summary>
		/// <see cref="Control.OnMouseDown"/>
		/// </summary>
		/// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
		{			
			SetPanFromMouse(e.X);
			base.OnMouseDown (e);			
		}

		private void SetPanFromMouse(int x)
		{
			Pan = (((float) x / this.Width) * 2.0f) - 1.0f;
		}

        /// <summary>
        /// The current Pan setting
        /// </summary>
		public float Pan
		{
			get
			{
				return pan;
			}
			set
			{
				if(value < -1.0f)
					value = -1.0f;
				if(value > 1.0f)
					value = 1.0f;
				if(value != pan)
				{
					pan = value;
					if(PanChanged != null)
						PanChanged(this,EventArgs.Empty);
					Invalidate();
				}
				
			}
		}
	}
}

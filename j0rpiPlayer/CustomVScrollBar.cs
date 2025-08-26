using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomVScrollBar : Control
{
    private int _minimum = 0;
    private int _maximum = 100;
    private int _value = 0;
    private int _largeChange = 1;
    private bool isDragging = false;
    private int startDragY = 0;
    private int startValue = 0;

    public int Minimum
    {
        get { return _minimum; }
        set { _minimum = value; Invalidate(); }
    }

    public int Maximum
    {
        get { return _maximum; }
        set { _maximum = value; Invalidate(); }
    }

    public int Value
    {
        get { return _value; }
        set
        {
            int newValue = Math.Max(Minimum, Math.Min(Maximum, value));
            if (_value != newValue)
            {
                _value = newValue;
                OnScroll(new ScrollEventArgs(ScrollEventType.ThumbPosition, _value));
                Invalidate();
            }
        }
    }

    public int LargeChange
    {
        get { return _largeChange; }
        set { _largeChange = value; Invalidate(); }
    }

    public event ScrollEventHandler Scroll;

    protected virtual void OnScroll(ScrollEventArgs e)
    {
        Scroll?.Invoke(this, e);
    }

    public CustomVScrollBar()
    {
        this.Width = 12; // Standard scrollbar width
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (Maximum <= Minimum) return;

        // Draw the background track
        using (var trackBrush = new SolidBrush(Color.FromArgb(40, 40, 40)))
        {
            e.Graphics.FillRectangle(trackBrush, this.ClientRectangle);
        }

        // Calculate thumb position and size
        float trackHeight = this.Height;
        float thumbHeight = Math.Max(15, (float)trackHeight * LargeChange / (Maximum - Minimum + LargeChange));
        float thumbY = (trackHeight - thumbHeight) * (float)(Value - Minimum) / (Maximum - Minimum);

        // Draw the thumb
        using (var thumbBrush = new SolidBrush(Color.FromArgb(90, 90, 90)))
        {
            e.Graphics.FillRectangle(thumbBrush, 0, thumbY, this.Width, thumbHeight);
        }
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        if (e.Button == MouseButtons.Left)
        {
            // Start drag
            isDragging = true;
            startDragY = e.Y;
            startValue = this.Value;
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (isDragging)
        {
            float trackHeight = this.Height;
            float thumbHeight = Math.Max(15, (float)trackHeight * LargeChange / (Maximum - Minimum + LargeChange));
            float thumbRange = trackHeight - thumbHeight;

            if (thumbRange > 0)
            {
                float newThumbY = e.Y - (startDragY - (float)(startValue - Minimum) / (Maximum - Minimum) * thumbRange);
                int newValue = (int)Math.Round(newThumbY / thumbRange * (Maximum - Minimum)) + Minimum;
                this.Value = newValue;
            }
        }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        if (e.Button == MouseButtons.Left)
        {
            isDragging = false;
        }
    }
}
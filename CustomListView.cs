using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public class CustomListView : ListView
{
    private VScrollBar customScrollBar;
    private int scrollOffset = 0;
    private int hoveredIndex = -1;

    // This is the correct way to hide the native scrollbar and enable double buffering
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED, enables double buffering
            cp.Style &= ~0x00200000; // WS_VSCROLL, removes vertical scrollbar
            return cp;
        }
    }

    public CustomListView()
    {
        this.OwnerDraw = true;
        this.Scrollable = false;
        this.DoubleBuffered = true;

        customScrollBar = new VScrollBar();
        this.Controls.Add(customScrollBar);
        customScrollBar.Dock = DockStyle.Right;

        customScrollBar.Scroll += CustomScrollBar_Scroll;
        this.MouseWheel += CustomListView_MouseWheel;
        this.Resize += CustomListView_Resize;
        this.MouseMove += CustomListView_MouseMove;
        this.MouseLeave += CustomListView_MouseLeave;
    }

    // Call this public method whenever you add or remove items
    public void UpdateScrollBar()
    {
        if (this.Items.Count > 0)
        {
            int visibleHeight = this.ClientSize.Height;
            int totalHeight = this.Items.Count * this.Items[0].Bounds.Height;
            int itemHeight = this.Items[0].Bounds.Height;

            if (totalHeight > visibleHeight)
            {
                customScrollBar.Visible = true;
                customScrollBar.Maximum = totalHeight - visibleHeight + itemHeight;
                customScrollBar.LargeChange = visibleHeight;
                customScrollBar.SmallChange = itemHeight;
            }
            else
            {
                customScrollBar.Visible = false;
            }
        }
        else
        {
            customScrollBar.Visible = false;
        }
    }

    private void CustomScrollBar_Scroll(object sender, ScrollEventArgs e)
    {
        scrollOffset = e.NewValue;
        this.Invalidate();
    }

    private void CustomListView_MouseWheel(object sender, MouseEventArgs e)
    {
        int newValue = customScrollBar.Value - e.Delta;
        if (newValue < customScrollBar.Minimum) newValue = customScrollBar.Minimum;
        if (newValue > customScrollBar.Maximum) newValue = customScrollBar.Maximum;

        customScrollBar.Value = newValue;
        scrollOffset = newValue;
        this.Invalidate();
    }

    private void CustomListView_Resize(object sender, EventArgs e)
    {
        UpdateScrollBar();
    }

    private void CustomListView_MouseMove(object sender, MouseEventArgs e)
    {
        // Adjust mouse position by the scroll offset to get the correct item
        Point adjustedPoint = new Point(e.X, e.Y + scrollOffset);
        ListViewItem item = this.GetItemAt(adjustedPoint.X, adjustedPoint.Y);
        int newIndex = item?.Index ?? -1;

        if (hoveredIndex != newIndex)
        {
            int oldIndex = hoveredIndex;
            hoveredIndex = newIndex;
            if (oldIndex >= 0) this.Invalidate(this.Items[oldIndex].Bounds);
            if (hoveredIndex >= 0) this.Invalidate(this.Items[hoveredIndex].Bounds);
        }
    }

    private void CustomListView_MouseLeave(object sender, EventArgs e)
    {
        if (hoveredIndex >= 0)
        {
            int oldIndex = hoveredIndex;
            hoveredIndex = -1;
            this.Invalidate(this.Items[oldIndex].Bounds);
        }
    }

    // This is the core drawing method that uses the scrollOffset
    protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
    {
        // Your column header drawing code remains here
        using (var backBrush = new SolidBrush(Color.FromArgb(50, 50, 50)))
        {
            e.Graphics.FillRectangle(backBrush, e.Bounds);
        }

        using (var pen = new Pen(Color.Black))
        {
            e.Graphics.DrawRectangle(pen, e.Bounds);
        }

        TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis;
        TextRenderer.DrawText(e.Graphics, e.Header.Text, this.Font, e.Bounds, Color.White, flags);
    }

    protected override void OnDrawItem(DrawListViewItemEventArgs e)
    {
        var newBounds = e.Bounds;
        newBounds.Y -= scrollOffset;

        // This check prevents drawing items that are off-screen
        if (newBounds.Y + newBounds.Height < 0 || newBounds.Y > this.ClientSize.Height) return;

        Color backColor;
        int currentPlayingIndex = -1;

        if (e.Item.Selected)
            backColor = Color.FromArgb(70, 130, 180);
        else if (e.Item.Index == hoveredIndex)
            backColor = Color.FromArgb(60, 60, 60);
        else
            backColor = e.Item.Index % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(45, 45, 45);

        using (var brush = new SolidBrush(backColor))
        {
            e.Graphics.FillRectangle(brush, newBounds);
        }
    }

    protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
    {
        var newBounds = e.Bounds;
        newBounds.Y -= scrollOffset;

        // This check prevents drawing sub-items that are off-screen
        if (newBounds.Y + newBounds.Height < 0 || newBounds.Y > this.ClientSize.Height) return;

        Color textColor = e.Item.Selected ? Color.White : Color.LightGray;
        if (e.Item.Index == -1) // Placeholder for current playing item index
            textColor = Color.LimeGreen;

        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, this.Font, newBounds, textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
    }
}
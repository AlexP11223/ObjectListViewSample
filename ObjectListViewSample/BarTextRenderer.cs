using System;
using System.Drawing;
using BrightIdeasSoftware;

namespace ObjectListViewSample
{
    // based on https://stackoverflow.com/questions/20613322/progress-column-with-text-in-objectlistview
    public class BarTextRenderer : BarRenderer
    {
        /// <summary>
        /// Make a BarTextRenderer
        /// </summary>
        public BarTextRenderer()
        { }

        /// <summary>
        /// Make a BarTextRenderer for the given range of data values
        /// </summary>
        public BarTextRenderer(int minimum, int maximum) : base(minimum, maximum) { }

        /// <summary>
        /// Make a BarTextRenderer using a custom bar scheme
        /// </summary>
        public BarTextRenderer(Pen pen, Brush brush) : base(pen, brush) { }
        /// <summary>
        /// Make a BarTextRenderer using a custom bar scheme
        /// </summary>
        public BarTextRenderer(int minimum, int maximum, Pen pen, Brush brush) : base(minimum, maximum, pen, brush) { }

        /// <summary>
        /// Make a BarTextRenderer that uses a horizontal gradient
        /// </summary>
        public BarTextRenderer(Pen pen, Color start, Color end) : base(pen, start, end) { }

        /// <summary>
        /// Make a BarTextRenderer that uses a horizontal gradient
        /// </summary>
        public BarTextRenderer(int minimum, int maximum, Pen pen, Color start, Color end) : base(minimum, maximum, pen, start, end) { }

        public Brush TextBrush { get; set; } = new SolidBrush(Color.Black);

        public override void Render(Graphics g, Rectangle r)
        {
            base.Render(g, r);

            string text = GetText();

            SizeF textSize = g.MeasureString(text, Font);

            float x = r.X + r.Width / 2f - textSize.Width / 2f;
            float w = r.Width / 2f;
            float h = Math.Max(r.Height - Font.Size, 0.8f * r.Height);
            float y = r.Y + 0.6f * (r.Height - h);

            RectangleF rf = new RectangleF(x, y, w, h);
            g.DrawString(text, Font, TextBrush, rf);
        }
    }
}

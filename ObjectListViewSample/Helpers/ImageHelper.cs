using System;
using System.Drawing;

namespace ObjectListViewSample.Helpers
{
    static class ImageHelper
    {
        public static Bitmap Resize(Bitmap srcBitmap, Size newSize)
        {
            var bm = new Bitmap(newSize.Width, newSize.Height);
            var g = Graphics.FromImage(bm);
            g.Clear(Color.Transparent);
            int x = Math.Max(0, (bm.Size.Width - srcBitmap.Width) / 2);
            int y = Math.Max(0, (bm.Size.Height - srcBitmap.Height) / 2);
            g.DrawImage(srcBitmap, x, y, srcBitmap.Width, srcBitmap.Height);
            return bm;
        }
    }
}

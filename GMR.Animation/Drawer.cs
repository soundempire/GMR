using System.Drawing;
using System.Drawing.Drawing2D;

namespace GMR.Animation
{
    public static class Drawer
    {

        public static GraphicsPath RoundedRectangle(Rectangle rect, float roundSize)
        {
            GraphicsPath gr = new GraphicsPath();
            gr.AddArc(rect.X, rect.Y, roundSize, roundSize, 180, 90);
            gr.AddArc(rect.X + rect.Width - roundSize, rect.Y, roundSize, roundSize, 270, 90);
            gr.AddArc(rect.X + rect.Width - roundSize, rect.Y + rect.Height - roundSize, roundSize, roundSize, 0, 90);
            gr.AddArc(rect.X, rect.Y + rect.Height - roundSize, roundSize, roundSize, 90, 90);
            return gr;
        }
    }
}

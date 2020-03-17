using GMR.Animation.Animation;
using GMR.Controls.ServiceClass;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GMR.Controls
{
    public class GMRCard : Control
    {
        #region Fields

        private float curtainHeight;
        private bool mouseEntered = false;
        //private bool mousePressed = false;
        GMR.Animation.Animation.Animation animationCurtain;
        #endregion

        #region Properties
        public Color BackColorCurtain { get; set; } = FlatColors.Red;

        public string TextHeader { get; set; } = "Header";
        public Font FontHeader { get; set; } = new Font("Veranda", 12F, FontStyle.Bold);
        public Color ForeColorHeader { get; set; } = Color.White;
        public string TextDescription { get; set; } = "Your Description text for this control.";
        public Font FontDescription { get; set; } = new Font("Veranda", 8.25F, FontStyle.Regular);
        public Color ForeColorDescription { get; set; } = Color.Black;
        #endregion

        public GMRCard()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(250, 200);
            curtainHeight = Height - 60;

            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;

            animationCurtain = new GMR.Animation.Animation.Animation();
            animationCurtain.Value = curtainHeight;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectCurtain = new Rectangle(0, 0, Width - 1, (int)animationCurtain.Value);

            //фон
            graphics.FillRectangle(new SolidBrush(BackColor), rect);
            //шторка
            graphics.DrawRectangle(new Pen(BackColorCurtain), rectCurtain);
            graphics.FillRectangle(new SolidBrush(BackColorCurtain), rectCurtain);
            //обводка
            graphics.DrawRectangle(new Pen(FlatColors.Gray), rect);

            if (animationCurtain.Value == 50)
            {
                graphics.DrawString(TextDescription, FontDescription, new SolidBrush(ForeColorDescription),
                    new Rectangle(15, 70, Width - 15, Height - 70));
            }

            graphics.DrawString(Text, Font, new SolidBrush(ForeColor), 15, Height - 37);
            graphics.DrawString(TextHeader, FontHeader, new SolidBrush(ForeColorHeader), new Rectangle(15, 15, rectCurtain.Width, rectCurtain.Height));


        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Height <= 100)
                Height = 100;
            if (Width <= 100)
                Width = 100;
            curtainHeight = Height - 60;

            animationCurtain = new GMR.Animation.Animation.Animation();
            animationCurtain.Value = curtainHeight;

            Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseEntered = true;
            DoCurtainAnimation();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseEntered = false;
            DoCurtainAnimation();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            //mousePressed = true;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            //mousePressed = false;
            Invalidate();
        }

        private void DoCurtainAnimation()
        {
            if (mouseEntered)
                animationCurtain = new GMR.Animation.Animation.Animation("Curtain_" + Handle, Invalidate, animationCurtain.Value, 50);
            else
                animationCurtain = new GMR.Animation.Animation.Animation("Curtain_" + Handle, Invalidate, animationCurtain.Value, curtainHeight);

            animationCurtain.stepDevider = 6;
            Animator.Request(animationCurtain, true);
        }

    }
}

using GMR.Animation;
using GMR.Animation.Animation;
using GMR.Controls.ServiceClass;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GMR.Controls
{
    public class GMRButton : Button //Control
    {
        #region Fields
        private StringFormat sf = new StringFormat();
        private bool mouseEntered = false;
        //private bool mousePressed = false;

        private int roundingPercent = 100;
        private bool roundingEnabled = false;

        GMR.Animation.Animation.Animation curtainButtonAnimation = new GMR.Animation.Animation.Animation();
        GMR.Animation.Animation.Animation rippleButtonAnimation = new GMR.Animation.Animation.Animation();

        Point clickLocation = new Point();
        #endregion
        #region Properties
        public bool RoundingEnabled { get => roundingEnabled; set { roundingEnabled = value; Refresh(); } }
        public int Rounding
        {
            get => roundingPercent; set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;
                    Refresh();
                }
            }
        }
        #endregion

        public GMRButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(100, 30);
            BackColor = Color.Tomato;
            ForeColor = Color.White;

            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            graphics.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectCurtain = new Rectangle(0, 0, (int)curtainButtonAnimation.Value - 1, Height - 1);
            Rectangle rectRipple = new Rectangle(clickLocation.X - (int)rippleButtonAnimation.Value / 2, clickLocation.Y - (int)rippleButtonAnimation.Value / 2, (int)rippleButtonAnimation.Value, (int)rippleButtonAnimation.Value);

            //закругление
            float roundingValue = 0.1f;
            if (roundingEnabled && roundingPercent > 0)
                roundingValue = Height / 100F * roundingPercent;

            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundingValue);
            //основной прямоугольник 
            graphics.DrawPath(new Pen(BackColor), rectPath);
            graphics.FillPath(new SolidBrush(BackColor), rectPath);

            graphics.SetClip(rectPath);

            graphics.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rectCurtain);
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.White)), rectCurtain);


            if (rippleButtonAnimation.Value > 0 && rippleButtonAnimation.Value < rippleButtonAnimation.targetValue)
            {
                graphics.DrawEllipse(new Pen(Color.FromArgb(60, FlatColors.BlueDark)), rectRipple);
                graphics.FillEllipse(new SolidBrush(Color.FromArgb(60, FlatColors.BlueDark)), rectRipple);
            }
            else if (rippleButtonAnimation.Value == rippleButtonAnimation.targetValue)
            {
                rippleButtonAnimation.Value = 0;
            }

            graphics.DrawString(Text, Font, new SolidBrush(ForeColor), rect, sf);
        }

        private void ButtonCurtainAction()
        {
            if (mouseEntered == true)
                curtainButtonAnimation = new GMR.Animation.Animation.Animation("Button_" + Handle, Invalidate, curtainButtonAnimation.Value, Width - 1);
            else
                curtainButtonAnimation = new GMR.Animation.Animation.Animation("Button_" + Handle, Invalidate, curtainButtonAnimation.Value, 0);

            curtainButtonAnimation.stepDevider = 2;
            Animator.Request(curtainButtonAnimation, true);
        }
        private void ButtonRippleAction()
        {
            rippleButtonAnimation = new GMR.Animation.Animation.Animation("ButtonRipple_" + Handle, Invalidate, 0, Width);

            rippleButtonAnimation.stepDevider = 8;
            Animator.Request(rippleButtonAnimation, true);

        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseEntered = true;
            ButtonCurtainAction();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseEntered = false;
            ButtonCurtainAction();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            //mousePressed = true;
            curtainButtonAnimation.Value = curtainButtonAnimation.targetValue;
            clickLocation = e.Location;
            ButtonRippleAction();
            Focus();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            //mousePressed = false;
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, height, specified);
        }
        //protected override void OnClick(EventArgs e)
        //{
        //    base.OnClick(e);
        //    curtainButtonAnimation.Value = curtainButtonAnimation.targetValue;
        //    //clickLocation.X = ((System.Windows.Forms.MouseEventArgs)e).X;
        //    //clickLocation.Y = ((System.Windows.Forms.MouseEventArgs)e).Y;
        //    ButtonRippleAction();
        //    Focus();
        //}

    }
}

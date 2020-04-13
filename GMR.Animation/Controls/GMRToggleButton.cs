using GMR.Animation;
using GMR.Animation.Animation;
using GMR.Controls.ServiceClass;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GMR.Controls
{
    public class GMRToggleButton : Control
    {
        #region Fields
        Rectangle rect;
        int togglePosXOn;
        int togglePosXOff;
        GMR.Animation.Animation.Animation toggleAnimation;

        #endregion

        #region Properties
        public bool isChecked { get; set; } = false;
        public Color BackColorOn { get; set; } = FlatColors.Blue;
        #endregion

        public GMRToggleButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(40, 15);

            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;

            rect = new Rectangle(1, 1, Width - 3, Height - 3);
            togglePosXOff = rect.X;
            togglePosXOn = rect.Width - rect.Height;

            toggleAnimation = new GMR.Animation.Animation.Animation();
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            toggleAnimation.Value = isChecked == true ? togglePosXOn : togglePosXOff;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.Clear(Parent.BackColor);

            Pen TSPen = new Pen(FlatColors.GrayDark, 3);
            Pen TSPenToggle = new Pen(FlatColors.GrayDark, 3);

            GraphicsPath rectGP = Drawer.RoundedRectangle(rect, rect.Height);
            Rectangle rectToggle = new Rectangle((int)toggleAnimation.Value, rect.Y, rect.Height, rect.Height);

            graphics.DrawPath(TSPen, rectGP);

            if (isChecked == true)
            {
                if (Animator.isWork == false)
                    rectToggle.Location = new Point(togglePosXOn, rect.Y);

                graphics.FillPath(new SolidBrush(BackColorOn), rectGP);
            }
            else
            {
                if (Animator.isWork == false)
                    rectToggle.Location = new Point(togglePosXOff, rect.Y);

                graphics.FillPath(new SolidBrush(BackColor), rectGP);
            }

            graphics.DrawEllipse(TSPenToggle, rectToggle);
            graphics.FillEllipse(new SolidBrush(Color.White), rectToggle);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            Size = new Size(40, 15);
            rect = new Rectangle(1, 1, Width - 3, Height - 3);

            togglePosXOff = rect.X;
            togglePosXOn = rect.Width - rect.Height;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            SwitchToggle();
        }
        private void SwitchToggle()
        {
            if (isChecked == true)
                toggleAnimation = new GMR.Animation.Animation.Animation("Toggle_" + Handle, Invalidate, toggleAnimation.Value, togglePosXOff);
            else
                toggleAnimation = new GMR.Animation.Animation.Animation("Toggle_" + Handle, Invalidate, toggleAnimation.Value, togglePosXOn);

            isChecked = !isChecked;
            toggleAnimation.stepDevider = 4;
            Animator.Request(toggleAnimation, true);
        }

    }
}

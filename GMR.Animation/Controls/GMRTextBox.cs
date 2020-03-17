using GMR.Animation.Animation;
using GMR.Controls;
using GMR.Controls.ServiceClass;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace GMR.Animation.Controls
{
    [DefaultProperty("TextPreview")]
    public class GMRTextBox : Control
    {
        #region Fields
        StringFormat sf = new StringFormat();
        int topBorderOffset = 0;
        public TextBox tbInput = new TextBox();
        private int roundingPercent = 100;
        private bool roundingEnabled = false;

        Animation.Animation locationTextPreviewAnim = new Animation.Animation();
        Animation.Animation fontSizeTextPreviewAnim = new Animation.Animation();
        #endregion

        #region Properties
        public string TextPreview { get; set; } = "Input Text";
        private Font fontTextPreview = new Font("Arial", 8, FontStyle.Bold);
        public Font FontTextPreview
        {
            get => fontTextPreview; set
            {
                if (value.Size >= Font.Size)
                    return;
                fontTextPreview = value;
            }
        }
        public Color BorderColor { get; set; } = FlatColors.BlueDark;
        public Color BorderColorNotActive { get; set; } = FlatColors.GrayDark;
        public string TextInput { get => tbInput.Text; set => tbInput.Text = value; }
        public bool UseSystemPasswordChar { get => tbInput.UseSystemPasswordChar; set => tbInput.UseSystemPasswordChar = value; }
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

        public GMRTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(220, 40);

            Font = new Font("Arial", 11.25F, FontStyle.Regular);
            BackColor = Color.White;
            ForeColor = Color.Black;

            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            AdjustTextBoxInput();
            this.Controls.Add(tbInput);

            locationTextPreviewAnim.Value = tbInput.Location.Y;
            fontSizeTextPreviewAnim.Value = Font.Size;

            tbInput.AcceptsTab = false;

            tbInput.PreviewKeyDown += new PreviewKeyDownEventHandler(TbInput_PreviewKeyDown);
            tbInput.KeyDown += new KeyEventHandler(TbInput_KeyDown);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            TbInput_KeyDown(this, e);
        }
        private void TbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                var otherControl = this.Parent.Controls.OfType<Control>().First(c => c.TabIndex == this.TabIndex + 1);

                if (otherControl != null)
                {
                    if (otherControl is GMRTextBox)
                    {
                        otherControl.Focus();
                    }
                    (otherControl as GMRButton)?.PerformClick();
                }
            }
            else
            {
                return;
            }
        }
        private void AdjustTextBoxInput()
        {
            tbInput = new TextBox();
            tbInput.Name = "InputBox";
            tbInput.BorderStyle = BorderStyle.None;
            tbInput.BackColor = BackColor;
            tbInput.ForeColor = ForeColor;
            tbInput.Font = Font;

            int offset = TextRenderer.MeasureText(TextPreview, FontTextPreview).Height / 2-2;

            tbInput.Location = new Point(5, Height / 2 - offset);
            tbInput.Size = new Size(Width - 10, tbInput.Height);

            tbInput.LostFocus += TbInput_LostFocus;
        }

        private void TbInput_LostFocus(object sender, EventArgs e)
        {
                TextPreviewAction(false);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            TextPreviewAction(TextInput.Length > 0);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.Clear(Parent.BackColor);
            topBorderOffset = graphics.MeasureString(TextPreview, FontTextPreview).ToSize().Height / 2;

            Font fontTextPreviewActual = new Font(FontTextPreview.FontFamily, fontSizeTextPreviewAnim.Value, FontTextPreview.Style);

            if (tbInput.Visible == false && fontTextPreviewActual.Size <= FontTextPreview.Size)
            {
                tbInput.Visible = true;
                tbInput.Focus();
            }
            else if (tbInput.Visible == true && fontTextPreviewActual.Size > FontTextPreview.Size)
                tbInput.Visible = false;
            //закругление
            float roundingValue = 0.1f;
            if (roundingEnabled && roundingPercent > 0)
                roundingValue = Height / 100F * roundingPercent;

            Rectangle rectBase = new Rectangle(0, topBorderOffset, Width - 1, Height - 1 - topBorderOffset);

            Size TextPreviewRectSize = graphics.MeasureString(TextPreview, fontTextPreviewActual).ToSize();
            Rectangle rectTextPreview = new Rectangle(5, (int)locationTextPreviewAnim.Value, TextPreviewRectSize.Width + 3, TextPreviewRectSize.Height);

            //обводка
            GraphicsPath rectPath = Drawer.RoundedRectangle(rectBase, roundingValue);

            graphics.DrawRectangle(new Pen(tbInput.Focused || tbInput.Text.Length > 0 ? BorderColor : BorderColorNotActive), rectBase);

            //заголовок
            graphics.DrawRectangle(new Pen(Parent.BackColor), rectTextPreview);
            graphics.FillRectangle(new SolidBrush(Parent.BackColor), rectTextPreview);

            graphics.FillRectangle(new SolidBrush(BackColor), rectBase);

            graphics.DrawString(TextPreview, fontTextPreviewActual, new SolidBrush(tbInput.Focused || tbInput.Text.Length > 0 ? BorderColor : BorderColorNotActive), rectTextPreview, sf);
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            tbInput.BackColor = BackColor;
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            tbInput.ForeColor = ForeColor;
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            tbInput.Font = Font;
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            TextPreviewAction(true);
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            var previousControl = this.Parent.Controls.OfType<Control>().First(c => c.TabIndex == this.TabIndex - 1);
            if (previousControl is GMRTextBox)
                TextPreviewAction(true);
        }

        private void TextPreviewAction(bool onTop)
        {
            if (onTop)
            {
                if (tbInput.Visible == false)
                {
                    locationTextPreviewAnim = new Animation.Animation("TextPreviewLocation_" + Handle, Invalidate, locationTextPreviewAnim.Value, 0);
                    fontSizeTextPreviewAnim = new Animation.Animation("FontPreviewLocation_" + Handle, Invalidate, fontSizeTextPreviewAnim.Value, FontTextPreview.Size);
                }
                else
                {
                    tbInput.Focus();
                    return;
                }
            }
            else
            {
                if (TextInput.Length == 0)
                {
                    locationTextPreviewAnim = new Animation.Animation("TextPreviewLocation_" + Handle, Invalidate, locationTextPreviewAnim.Value, tbInput.Location.Y);
                    fontSizeTextPreviewAnim = new Animation.Animation("FontPreviewLocation_" + Handle, Invalidate, fontSizeTextPreviewAnim.Value, Font.Size);
                }
                else return;
            }

            locationTextPreviewAnim.stepDevider = 4;
            fontSizeTextPreviewAnim.stepDevider = 4;

            Animator.Request(locationTextPreviewAnim, true);
            Animator.Request(fontSizeTextPreviewAnim, true);
        }

        private void TbInput_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
                e.IsInputKey = true;
        }
    }
}

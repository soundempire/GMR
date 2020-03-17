using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using MRG1;

namespace MRG1.SuperDataControls
{
    public partial class DOTextBox : UserControl
    {
        public enum SpecialValidatorType
        {
            None,
            Email,
            EmailOrEmpty,
            NotEmptyOrSpaces,
            NotEmpty
        }
        #region Fields
        private Color colorOutLine = Color.DarkSlateBlue;
        private object m_DataSource;
        private string m_ParentDataSourceField;
        private string m_DataField;
        private DataObjects.TableColumnTypeInfo m_ColumnInfo;
        private bool m_AutoMask = true;
        #endregion

        #region Properties
        public SpecialValidatorType SpecialValidator { get; set; } = SpecialValidatorType.None;
        public event EventHandler<KeyEventArgs> KeyDown;
        public event EventHandler ValueChanging;
        public bool AutoMask
        {
            get { return m_AutoMask; }
            set
            {
                if (!(m_AutoMask = value))
                    m_ColumnInfo = null;
                else
                    if (string.IsNullOrEmpty(DataField) && GetDataSource() != null)
                    m_ColumnInfo = Common.GetColumnInfo(GetDataSource(), DataField);
            }
        }
        public int MaxLength { get => txtTextBox.MaxLength; set => txtTextBox.MaxLength = value; }
        public char PasswordChar { get => txtTextBox.PasswordChar; set => txtTextBox.PasswordChar = value; }
        public Color TextBackColor { get => txtTextBox.BackColor; set { txtTextBox.BackColor = value; Invalidate(); } }
        public Color BoxOutlineColor { get => colorOutLine; set { colorOutLine = value; Invalidate(); } }
        public object DataSource
        {
            get => GetDataSource();
            set { if (!string.IsNullOrEmpty(m_ParentDataSourceField) && m_ParentDataSourceField.Length > 0) return; m_DataSource = value; DataBind(); }
        }
        public string DataField { get => m_DataField; set { m_DataField = value; DataBind(); } }
        public string ParentDataSourceFieldName { get => m_ParentDataSourceField; set { m_DataSource = null; m_ParentDataSourceField = value; DataBind(); } }
        public string DataValue
        {
            get
            {
                if (GetDataSource() == null || string.IsNullOrEmpty(m_DataField) || m_DataField.Length < 1)
                    return null;
                object datVal;
                try
                {
                    datVal = Common.BindProperty(GetDataSource(), m_DataField);
                }
                catch (Exception)
                {
                    datVal = null;
                }
                if (datVal == null)
                    return null;
                else return datVal.ToString();
            }
            set
            {
                if (GetDataSource() == null || string.IsNullOrEmpty(m_DataField) || m_DataField.Length < 1)
                    return;
                try
                {
                    Common.StoreProperty(GetDataSource(), m_DataField, value);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public bool ReadOnly { get => txtTextBox.ReadOnly; set => txtTextBox.ReadOnly = value; }
        public override string Text { get => txtTextBox.Text; set => txtTextBox.Text = value; }
        #endregion

        #region Methods 
        private object GetDataSource()
        {
            if (!string.IsNullOrEmpty(m_ParentDataSourceField) && m_ParentDataSourceField.Length < 1)
                return m_DataSource;
            if (Parent == null)
                return null;
            object o = null;
            try
            {
                o = MRG1.Common.BindProperty(Parent, m_ParentDataSourceField);
            }
            catch (Exception)
            {
                o = null;
            }
            return o;
        }
        private void DataBind()
        {
            string val = DataValue;
            if (val != null)
            {
                if (m_AutoMask)
                    m_ColumnInfo = Common.GetColumnInfo(GetDataSource(), DataField);
                txtTextBox.Text = DataValue;
            }
        }
        public void SelectAll()
        {
            txtTextBox.SelectionStart = 0;
            txtTextBox.SelectionLength = txtTextBox.Text.Length;
        }
        private bool FixText()
        {
            if (m_ColumnInfo != null)
            {
                int origPos = txtTextBox.SelectionStart;
                string s = txtTextBox.Text;

                if (m_ColumnInfo.NumbersOnly)
                {
                    s = System.Text.RegularExpressions.Regex.Replace(s, "[^0-9.-]", "");
                    s = s.StartsWith("-") ? "-" + s.Replace("-", "") : s.Replace("-", "");

                    if (s.Contains("."))
                    {
                        string[] sp = s.Split(new char[] { '.' }, 2);
                        s = m_ColumnInfo.DecimalPlaces == 0 ? sp[0] : sp[0] + "." + sp[1].Replace(".", "");
                    }
                    if (m_ColumnInfo.DecimalPlaces != -1)
                    {
                        if (s.Contains("."))
                        {
                            string[] sp = s.Split('.');
                            if (sp[1].Length > m_ColumnInfo.DecimalPlaces)
                                sp[1] = sp[1].Substring(0, m_ColumnInfo.DecimalPlaces);
                            s = sp[0] + "." + sp[1];
                        }
                    }
                    if (m_ColumnInfo.Precision > 0)
                    {
                        if (s.Contains("."))
                        {
                            string[] sp = s.Split('.');
                            if (sp[0].Length > m_ColumnInfo.Precision - (m_ColumnInfo.DecimalPlaces > -1 ? m_ColumnInfo.DecimalPlaces : 0))
                            {
                                sp[0] = sp[0].Substring(0, m_ColumnInfo.Precision - (m_ColumnInfo.DecimalPlaces > -1 ? m_ColumnInfo.DecimalPlaces : 0));
                                s = sp[0] + "." + sp[1];
                            }
                        }
                        else
                        {
                            if (s.Length > m_ColumnInfo.Precision - (m_ColumnInfo.DecimalPlaces > -1 ? m_ColumnInfo.DecimalPlaces : 0))
                                s = s.Substring(0, m_ColumnInfo.Precision - (m_ColumnInfo.DecimalPlaces > -1 ? m_ColumnInfo.DecimalPlaces : 0));
                        }
                    }
                }
                else
                {
                    if (m_ColumnInfo.MaxLength > 0)
                        if (s.Length > m_ColumnInfo.MaxLength)
                            s = s.Substring(0, m_ColumnInfo.MaxLength);
                }
                if (s != txtTextBox.Text)
                {
                    origPos += (s.Length - txtTextBox.Text.Length);
                    txtTextBox.Text = s;
                    txtTextBox.SelectionStart = origPos;
                    txtTextBox.Width = Width - 10;
                    return true;
                }
                else
                {
                    txtTextBox.Width = Width - 10;
                    return false;
                }
            }
            else
            {
                txtTextBox.Width = Width - 10;
                return false;
            }
        }
        public bool ValidateContents()
        {
            if (!SpecialValidate())
            {
                if (Parent != null)
                {
                    Point p = Parent.PointToScreen(Location);
                    p.Offset(Width / 2, Height);
                    Help.ShowPopup(this, GetValidatorDescription(SpecialValidator), p);
                }
                return false;
            }
            else
                return false;
        }
        private bool SpecialValidate()
        {
            switch (SpecialValidator)
            {
                case SpecialValidatorType.None: return true;
                case SpecialValidatorType.Email: return ValidateEmail(txtTextBox.Text);
                case SpecialValidatorType.EmailOrEmpty: return txtTextBox.Text.Length < 1 || ValidateEmail(txtTextBox.Text);
                case SpecialValidatorType.NotEmptyOrSpaces: return txtTextBox.Text.Trim().Length > 0 ;
                case SpecialValidatorType.NotEmpty: return txtTextBox.Text.Length > 0;
                default: return false;
            }
        }
        private string GetValidatorDescription(SpecialValidatorType sv)
        {
            switch (sv)
            {
                case SpecialValidatorType.None: return "";
                case SpecialValidatorType.Email: return "Вам необходимо ввести валидный email адрес.";
                case SpecialValidatorType.EmailOrEmpty:return "Вам необходимо ввести валидный email адрес или очистить поле.";
                case SpecialValidatorType.NotEmptyOrSpaces: return "Вам необходимо ввести значение, содержащее более одного пробела в это поле.";
                case SpecialValidatorType.NotEmpty: return "Вам необходимо ввести значение в это поле.";
                default: return "";
            }
        }
        private bool ValidateEmail(string email)
        {
            var regex = new System.Text.RegularExpressions.Regex("^[A-Z0-9.%+-]+@[A-Z0-9.-]+.[A-Z]{2,4}$",System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
        public override void Refresh()
        {
            DataBind();
            base.Refresh();
        }

        #endregion

        public DOTextBox()
        {
            InitializeComponent();
            txtTextBox.Width = Width - 10;
        }

        #region Events
        private void DOTextBox_Resize(object sender, EventArgs e)
        {
            if (this.Height != txtTextBox.Height + 10)
                try { this.Height = txtTextBox.Height + 10; }
                catch (Exception) { }
            txtTextBox.Width = this.Width - 10;
        }
        private void txtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FixText()) return;
            ValueChanging.Invoke(this, new EventArgs());
        }
        private void txtTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDown.Invoke(this, e);
        }
        private void txtTextBox_Validated(object sender, EventArgs e)
        {
            DataValue = txtTextBox.Text;
        }
        private void txtTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateContents())
                e.Cancel = true;
        }
        #endregion
    }
}

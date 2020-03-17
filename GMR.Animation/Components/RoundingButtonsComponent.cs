using GMR.Controls;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GMR.Animation.Components
{
    public partial class RoundingButtonsComponent : Component
    {
        #region Fields
        public bool roundingEnabled = false;
        public int roundingPercent = 100;

        #endregion

        #region Props
        public bool RoundingEnabled { get => roundingEnabled; set { roundingEnabled = value; Update(); } }
        public Form TargetForm { get; set; }
        [DefaultValue(100)]
        [DisplayName("Rounding [%]")]
        [Description("Вкл./выкл закругление объектов")]
        public int Rounding
        {
            get => roundingPercent; set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;
                    Update();
                }
            }
        }
        [DefaultValue(true)]
        [Description("Применять закругления для вложенных контейнеров")]
        public bool NestedContainer { get; set; } = true;
        #endregion

        #region Ctors
        public RoundingButtonsComponent()
        {
            InitializeComponent();
        }
        public RoundingButtonsComponent(IContainer container)
        {
            Update();
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        public void Update()
        {
            if (TargetForm != null && TargetForm.Controls.Count > 0)
            {
                DefineRounding(TargetForm.Controls);
            }
        }
        public void DefineRounding(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is GMRButton)
                {
                    GMRButton btn = (GMRButton)ctrl;
                    btn.Rounding = Rounding;

                    btn.Refresh();
                }
                if (NestedContainer)
                    if (ctrl.Controls.Count > 0)
                        DefineRounding(ctrl.Controls);
            }
        }
    }
}

namespace Property
{
    public sealed partial class frmCommercial : Property.frmProperty
    {   //Singleton
        private static readonly frmCommercial Instance = new frmCommercial();

        private frmCommercial()
        {
            InitializeComponent();
        }

        public static void Run(clsCommercial prCommercial)
        {
            Instance.SetDetails(prCommercial);
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsCommercial lcProperty = (clsCommercial)_Property;
            txtWidth.Text = lcProperty.Width.ToString();
            txtHeight.Text = lcProperty.Height.ToString();
            txtType.Text = lcProperty.Type;
        }

        protected override void pushData()
        {
            base.pushData();
            clsCommercial lcProperty = (clsCommercial)_Property;
            lcProperty.Width = float.Parse(txtWidth.Text);
            lcProperty.Height = float.Parse(txtHeight.Text);
            lcProperty.Type = txtType.Text;
        }

    }
}


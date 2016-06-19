namespace Property
{
    public sealed partial class frmResidential : Property.frmProperty
    {   //Singleton
        public static readonly frmResidential Instance = new frmResidential();

        private frmResidential()
        {
            InitializeComponent();
        }

        public static void Run(clsResidential prResidential)
        {
            Instance.SetDetails(prResidential);
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsResidential lcProperty = (clsResidential)this._Property;
            txtWidth.Text = lcProperty.Width.ToString();
            txtHeight.Text = lcProperty.Height.ToString();
            txtType.Text = lcProperty.Type;
        }

        protected override void pushData()
        {
            base.pushData();
            clsResidential lcProperty = (clsResidential)_Property;
            lcProperty.Width = float.Parse(txtWidth.Text);
            lcProperty.Height = float.Parse(txtHeight.Text);    
            lcProperty.Type = txtType.Text;
        }
    }
}


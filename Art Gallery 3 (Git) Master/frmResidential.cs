// MATTHIAS OTTO - NMIT SDV701 GALLERY EXAMPLE
// GITHUB - FORKED MODIFIED BY: CHRISTOPHER D'ENTREMONT
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY / 'FRMRESIDENTIAL' SEALED CLASS / sub-FORM OF 'FRMPROPERTY'
// ATTRIBUTE OPERATIONS

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


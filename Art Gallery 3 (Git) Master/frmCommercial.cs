// MATTHIAS OTTO - NMIT SDV701 GALLERY EXAMPLE
// GITHUB - FORKED MODIFIED BY: CHRISTOPHER D'ENTREMONT
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY / 'FRMCOMMERCIAL' SEALED CLASS / sub-CLASS OF SUPERCLASS 'FRMPROPERTY' / FORM
// ATTRIBUTE OPERATIONS

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
            //txtHeight.Text = lcProperty.Height.ToString();
            //txtType.Text = lcProperty.Type;
        }

        protected override void pushData()
        {
            base.pushData();
            clsCommercial lcProperty = (clsCommercial)_Property;
            lcProperty.Width = float.Parse(txtWidth.Text);
            //lcProperty.Height = float.Parse(txtHeight.Text);
            //lcProperty.Type = txtType.Text;
        }

    }
}


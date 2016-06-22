// MATTHIAS OTTO - NMIT SDV701 GALLERY EXAMPLE
// GITHUB - FORKED MODIFIED BY: CHRISTOPHER D'ENTREMONT
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY / 'FRMPROPERTY' PARTIAL CLASS / FORM
// ATTRIBUTE OPERATIONS

using System;
using System.Windows.Forms;

namespace Property
{
    public partial class frmProperty : Form
    {
        protected clsProperty _Property;

        public frmProperty()
        {
            InitializeComponent();
        }

        public void SetDetails(clsProperty prProperty)
        {
            _Property = prProperty;
            updateForm();
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            txtName.Text = _Property.Name;
            txtCreation.Text = _Property.Date.ToShortDateString();
            txtValue.Text = _Property.Value.ToString();
        }

        protected virtual void pushData()
        {
            _Property.Name = txtName.Text;
            _Property.Date = DateTime.Parse(txtCreation.Text);
            _Property.Value = decimal.Parse(txtValue.Text);
        }

    }
}
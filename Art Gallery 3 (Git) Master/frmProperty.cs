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
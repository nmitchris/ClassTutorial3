using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Property
{
    public partial class frmLocation : Form
    {
        private clsLocation _Location;
        private clsPropertiesList _PropertiesList;

        private static Dictionary<clsLocation, frmLocation> _LocationFormList =
            new Dictionary<clsLocation, frmLocation>();

        private frmLocation()
        {
            InitializeComponent();
        }

        public static void Run(clsLocation prLocation)
        {
            frmLocation lcLocationForm;
            if (!_LocationFormList.TryGetValue(prLocation, out lcLocationForm))
            {
                lcLocationForm = new frmLocation();
                _LocationFormList.Add(prLocation, lcLocationForm);
                lcLocationForm.SetDetails(prLocation);
            }
            else
            {
                lcLocationForm.Show();
                lcLocationForm.Activate();
            }
        }

        private void updateTitle(string prGalleryName)
        {
            if (!string.IsNullOrEmpty(prGalleryName))
                Text = "Location Details - " + prGalleryName;
        }

        private void UpdateDisplay()
        {
            if (_PropertiesList.SortOrder == 0)
            {
                _PropertiesList.SortByName();
                rbByName.Checked = true;
            }
            else
            {
                _PropertiesList.SortByDate();
                rbByDate.Checked = true;
            }

            lstProperties.DataSource = null;
            lstProperties.DataSource = _PropertiesList;
            lblTotal.Text = Convert.ToString(_PropertiesList.GetTotalValue());
        }

        public void UpdateForm()
        {
            txtName.Text = _Location.Name;
            txtSpeciality.Text = _Location.Speciality;
            txtPhone.Text = _Location.Phone;
            _PropertiesList = _Location.PropertiesList;

            //frmMain.Instance.GalleryNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Owner.LocationList.GalleryName);
        }

        public void SetDetails(clsLocation prLocation)
        {
            _Location = prLocation;
            txtName.Enabled = string.IsNullOrEmpty(_Location.Name);
            UpdateForm();
            UpdateDisplay();
            frmMain.Instance.GalleryNameChanged += new frmMain.Notify(updateTitle);
            updateTitle(_Location.LocationList.GalleryName);
            Show();
        }

        private void pushData()
        {
            _Location.Name = txtName.Text;
            _Location.Speciality = txtSpeciality.Text;
            _Location.Phone = txtPhone.Text;
            //_PropertiesList.SortOrder = _SortOrder; // no longer required, updated with each rbByDate_CheckedChanged
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lcReply = new InputBox(clsProperty.FACTORY_PROMPT).Answer;
            if (!string.IsNullOrEmpty(lcReply))
            {
                _PropertiesList.AddWork(lcReply[0]);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
        }

        private void lstProperties_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                _PropertiesList.EditProperty(lstProperties.SelectedIndex);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstProperties.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting property", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _PropertiesList.RemoveAt(lcIndex);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
                try
                {
                    pushData();
                    if (txtName.Enabled)
                    {
                        _Location.NewLocation();
                        MessageBox.Show("Location added!", "Success");
                        frmMain.Instance.UpdateDisplay();
                        txtName.Enabled = false;
                    }
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private Boolean isValid()
        {
            if (txtName.Enabled && txtName.Text != "")
                if (_Location.IsDuplicate(txtName.Text))
                {
                    MessageBox.Show("Location with that name already exists!", "Error adding Location");
                    return false;
                }
                else
                    return true;
            else
                return true;
        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
            _PropertiesList.SortOrder = Convert.ToByte(rbByDate.Checked);
            UpdateDisplay();
        }

    }
}
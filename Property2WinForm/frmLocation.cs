// CHRISTOPHER D'ENTREMONT 
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY2WINFORM / FRMLOCATION PARTIAL CLASS / FORM
// FORM ATTRIBUTE OPERATIONS
// FORM UNDER CONSTRUCTION - I THINK IT NEEDS ADDITIONAL CLASSES FROM 'PROPERTY' PROJECT???

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Property2Selfhost.DTO;

namespace Property2WinForm.ServiceReference1
{
    public partial class frmLocation : Form
    {
        private clsLocation _Location;
        //private clsPropertiesList _PropertiesList;

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

        private void updateTitle(string prPropertyName)
        {
            if (!string.IsNullOrEmpty(prPropertyName))
                Text = "Location Details - " + prPropertyName;
        }

        // Part of original Lab 3 Tutorial - Update Method - Total Value / Sort by Date / Order.
        // Code preserved for inclusion at a later date.
        private void UpdateDisplay()
        {
            //if (_PropertiesList.SortOrder == 0)
            //{
            //    _PropertiesList.SortByName();
            //    rbByName.Checked = true;
            //}
            //else
            //{
            //    _PropertiesList.SortByDate();
            //    rbByDate.Checked = true;
            //}

            lstfrmLocoProperties.DataSource = null;
            //lstfrmLocoProperties.DataSource = _PropertiesList;
            //lblTotal.Text = Convert.ToString(_PropertiesList.GetTotalValue());
        }

        public void UpdateForm()
        {
            txtfrmLocoCityName.Text = _Location.City_Name;
            txtfrmLocoDetail.Text = _Location.Location_Detail;
            //_PropertiesList = _Location.PropertiesList;

            //frmMain.Instance.PropertyNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Location.LocationList.PropertyName);
        }

        public void SetDetails(clsLocation prLocation)
        {
            _Location = prLocation;
            txtfrmLocoCityName.Enabled = string.IsNullOrEmpty(_Location.City_Name);
            UpdateForm();
            UpdateDisplay();
            //frmMain.Instance.PropertyNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Location.LocationList.GalleryName);
            Show();
        }

        private void pushData()
        {
            _Location.City_Name = txtfrmLocoCityName.Text;
            _Location.Location_Detail = txtfrmLocoDetail.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string lcReply = new InputBox(clsProperty.FACTORY_PROMPT).Answer;
            //if (!string.IsNullOrEmpty(lcReply))
            //{
            //    _PropertiesList.AddWork(lcReply[0]);
            //    UpdateDisplay();
            //    frmMain.Instance.UpdateDisplay();
            //}
        }

        private void btnfrmLocoDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstfrmLocoProperties.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    //_LocationList.Remove(lcKey);
                    lstfrmLocoProperties.ClearSelected();
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting location");
                }
        }

        private void lstfrmLocoProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //_PropertiesList.EditProperty(lstfrmLocoProperties.SelectedIndex);
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
            int lcIndex = lstfrmLocoProperties.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting property", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //_PropertiesList.RemoveAt(lcIndex);
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
                    if (txtfrmLocoCityName.Enabled)
                    {
                        //_Location.NewLocation();
                        MessageBox.Show("Location added!", "Success");
                        frmMain.Instance.UpdateDisplay();
                        txtfrmLocoCityName.Enabled = false;
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
            //if (txtfrmLocoCityName.Enabled && txtfrmLocoCityName.Text != "")
            //    if (_Location.IsDuplicate(txtfrmLocoCityName.Text))
            //    {
            //        MessageBox.Show("Location with that name already exists!", "Error adding Location");
            //        return false;
            //    }
            //    else
            //        return true;
            //else
                return true;
        }

        // Part of original Lab 3 Tutorial - Sort by Date / Order not in my design.
        // Code preserved for inclusion at a later date.
        //private void rbByDate_CheckedChanged(object sender, EventArgs e)
        //{
        //_PropertiesList.SortOrder = Convert.ToByte(rbByDate.Checked);
        //UpdateDisplay();
        //}

    }
}
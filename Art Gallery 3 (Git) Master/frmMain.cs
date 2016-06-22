// MATTHIAS OTTO - NMIT SDV701 GALLERY EXAMPLE
// GITHUB - FORKED MODIFIED BY: CHRISTOPHER D'ENTREMONT
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY / 'FRMMAIN' PARTIAL CLASS / FORM
// ATTRIBUTE OPERATIONS

using System;
using System.Windows.Forms;

namespace Property
{
    public sealed partial class frmMain : Form
    {   //Singleton
        private static readonly frmMain _Instance = new frmMain();

        private clsLocationList _LocationList = new clsLocationList();

        public delegate void Notify(string prGalleryName);

        public event Notify GalleryNameChanged;

        private frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        private void updateTitle(string prGalleryName)
        {
            if (!string.IsNullOrEmpty(prGalleryName))
                Text = "Gallery (v3 C) - " + prGalleryName;
        }

        public void UpdateDisplay()
        {
            lstLocations.DataSource = null;
            string[] lcDisplayList = new string[_LocationList.Count];
            _LocationList.Keys.CopyTo(lcDisplayList, 0);
            lstLocations.DataSource = lcDisplayList;
            lblValue.Text = Convert.ToString(_LocationList.GetTotalValue());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmLocation.Run(new clsLocation(_LocationList));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new location");
            }
        }

        private void lstLocation_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstLocations.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmLocation.Run(_LocationList[lcKey]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                _LocationList.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Save Error");
            }
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstLocations.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    _LocationList.Remove(lcKey);
                    lstLocations.ClearSelected();
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting location");
                }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _LocationList = clsLocationList.RetrieveLocationList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File retrieve error");
            }
            UpdateDisplay();
            GalleryNameChanged += new Notify(updateTitle);
            GalleryNameChanged(_LocationList.GalleryName);
            //updateTitle(_LocationList.GalleryName);
        }

        private void btnGalName_Click(object sender, EventArgs e)
        {
            _LocationList.GalleryName = new InputBox("Enter Gallery Name:").Answer;
            GalleryNameChanged(_LocationList.GalleryName);
        }


    }
}
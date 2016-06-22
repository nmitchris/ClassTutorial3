// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY2WINFORM / 'FRMMAIN' SEALED  PARTIAL CLASS / FORM / SINGLETON PATTERN (INSTANCE) / RECURSIVE
// FORM ATTRIBUTE OPERATIONS / INITIALISE CONPONENT FORM BUILD
// WIP - I THINK THIS FORM HAS AN ISSUE WITH A MISSING 'USING'???

using System;
using System.Windows.Forms;

namespace Property2WinForm
{
    public sealed partial class frmMain : Form
    {   //frmMain is a Singleton (instance)
        //=========
        private Button btnAdd;
        private ListBox lstLocations;
        private Button btnQuit;
        private Button btnDelete;
        private Label lbfrmMainTitle;
        private Label lbfrmMainSelectLoco;
        private static readonly frmMain _Instance = new frmMain();

        //private clsLocationList _LocationList = new clsLocationList();

        public delegate void Notify(string prLocationName);

        //public event Notify PropertyNameChanged;

        private frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        private void updateTitle(string prPropertyName)
        {
            if (!string.IsNullOrEmpty(prPropertyName))
                Text = "Property (v1) - " + prPropertyName;
        }

        public void UpdateDisplay()
        {
            lstLocations.DataSource = null;
            lstLocations.DataSource = Program.SvcClient.GetLocationNames();

            //lstLocations.DataSource = null;
            //string[] lcDisplayList = new string[_LocationList.Count];
            //_LocationList.Keys.CopyTo(lcDisplayList, 0);
            //lstLocations.DataSource = lcDisplayList;
            //lblValue.Text = Convert.ToString(_LocationList.GetTotalValue());
        }

        //Lab 3 - Part 4bv - Need to correct double click operation.
        // WIP - 'frmLocation.Run(...)' - issue with using??? 22/6/2016 Cd'E

        private void lstLocations_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstLocations.SelectedItem);
            if (lcKey != null)
                try
                {
                    //frmLocation.Run(lstLocations.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        //private refreshFormFromDB(string prLocationName)
        //{
        //SetDetails(Program.SvcClient.GetLocation(prLocationName));
        //}

        public static void Run(string prLocationName)
        {
            //frmLocation lcLocationForm;
            //if (string.IsNullOrEmpty(prLocationName) ||
            //!_LocationFormList.TryGetValue(prLocationName, out lcLocationForm))
            //{
            //    lcLocationForm = new frmLocation();
            //    if (string.IsNullOrEmpty(prLocationName))
            //        lcLocationForm.SetDetails(new clsLocation());
            //    else
            //    {
            //        _LocationFormList.Add(prLocationName, lcLocationForm);
            //        lcLocationForm.refreshFormFromDB(prLocationName);
            //    }
            //}
            //else
            //{
            //    lcLocationForm.Show();
            //    lcLocationForm.Activate();
            //}

        }

        //Not used DELETE EventArgs btnGalName - after demo.
        private void btnGalName_Click(object sender, EventArgs e)
        {
            //_LocationList.PropertyName = new InputBox("Enter Property Name:").Answer;
            //PropertyNameChanged(_LocationList.PropertyName);
        }

        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbfrmMainTitle = new System.Windows.Forms.Label();
            this.lbfrmMainSelectLoco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Applications";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // lstLocations
            // 
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.Location = new System.Drawing.Point(24, 65);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(179, 199);
            this.lstLocations.TabIndex = 1;
            this.lstLocations.DoubleClick += new System.EventHandler(this.lstLocations_DoubleClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(223, 279);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(96, 38);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // lbfrmMainTitle
            // 
            this.lbfrmMainTitle.AutoSize = true;
            this.lbfrmMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfrmMainTitle.Location = new System.Drawing.Point(24, 4);
            this.lbfrmMainTitle.Name = "lbfrmMainTitle";
            this.lbfrmMainTitle.Size = new System.Drawing.Size(197, 17);
            this.lbfrmMainTitle.TabIndex = 4;
            this.lbfrmMainTitle.Text = "PROPERTIES FOR LEASE";
            // 
            // lbfrmMainSelectLoco
            // 
            this.lbfrmMainSelectLoco.AutoSize = true;
            this.lbfrmMainSelectLoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfrmMainSelectLoco.Location = new System.Drawing.Point(24, 40);
            this.lbfrmMainSelectLoco.Name = "lbfrmMainSelectLoco";
            this.lbfrmMainSelectLoco.Size = new System.Drawing.Size(120, 13);
            this.lbfrmMainSelectLoco.TabIndex = 5;
            this.lbfrmMainSelectLoco.Text = "SELECT LOCATION";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(334, 329);
            this.Controls.Add(this.lbfrmMainSelectLoco);
            this.Controls.Add(this.lbfrmMainTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lstLocations);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmMain";
            this.Text = "Property (v1)";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            try
            {
                //_LocationList = clsLocationList.RetrieveLocationList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File retrieve error");
            }
            UpdateDisplay();
            //PropertyNameChanged += new Notify(updateTitle);
            //PropertyNameChanged(_LocationList.PropertyName);
            //updateTitle(_LocationList.GalleryName);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                //frmLocation.Run(new clsLocation(_LocationList));
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Error adding new location");
            }
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //string lcKey;

            //lcKey = Convert.ToString(lstLocations.SelectedItem);
            //if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    try
            //    {
            //        _LocationList.Remove(lcKey);
            //        lstLocations.ClearSelected();
            //        UpdateDisplay();

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error deleting location");
            //    }
        }

    }
}
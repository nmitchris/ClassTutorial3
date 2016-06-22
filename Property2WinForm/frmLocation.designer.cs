// CHRISTOPHER D'ENTREMONT 
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY2WINFORM / FRMLOCATION PARTIAL CLASS / FRMLOCATIONDESIGNER
// ATTRIBUTE DESIGN

namespace Property2WinForm.ServiceReference1
{
    partial class frmLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnfrmLocoOK = new System.Windows.Forms.Button();
            this.btnfrmLocoDelete = new System.Windows.Forms.Button();
            this.btnfrmLocoAdd = new System.Windows.Forms.Button();
            this.lbfrmLocoAddress = new System.Windows.Forms.Label();
            this.lstfrmLocoProperties = new System.Windows.Forms.ListBox();
            this.txtfrmLocoDetail = new System.Windows.Forms.TextBox();
            this.lbfrmLocoDetail = new System.Windows.Forms.Label();
            this.txtfrmLocoCityName = new System.Windows.Forms.TextBox();
            this.lbfrmLocoName = new System.Windows.Forms.Label();
            this.lbfrmLocoType = new System.Windows.Forms.Label();
            this.comboBxfrmLocoPropType = new System.Windows.Forms.ComboBox();
            this.lbfrmLocoProperties = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfrmLocoOK
            // 
            this.btnfrmLocoOK.Location = new System.Drawing.Point(364, 304);
            this.btnfrmLocoOK.Name = "btnfrmLocoOK";
            this.btnfrmLocoOK.Size = new System.Drawing.Size(64, 32);
            this.btnfrmLocoOK.TabIndex = 24;
            this.btnfrmLocoOK.Text = "OK";
            // 
            // btnfrmLocoDelete
            // 
            this.btnfrmLocoDelete.Location = new System.Drawing.Point(291, 257);
            this.btnfrmLocoDelete.Name = "btnfrmLocoDelete";
            this.btnfrmLocoDelete.Size = new System.Drawing.Size(64, 32);
            this.btnfrmLocoDelete.TabIndex = 23;
            this.btnfrmLocoDelete.Text = "DELETE";
            this.btnfrmLocoDelete.Click += new System.EventHandler(this.btnfrmLocoDelete_Click);
            // 
            // btnfrmLocoAdd
            // 
            this.btnfrmLocoAdd.Location = new System.Drawing.Point(213, 257);
            this.btnfrmLocoAdd.Name = "btnfrmLocoAdd";
            this.btnfrmLocoAdd.Size = new System.Drawing.Size(64, 32);
            this.btnfrmLocoAdd.TabIndex = 22;
            this.btnfrmLocoAdd.Text = "ADD";
            this.btnfrmLocoAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbfrmLocoAddress
            // 
            this.lbfrmLocoAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfrmLocoAddress.Location = new System.Drawing.Point(14, 117);
            this.lbfrmLocoAddress.Name = "lbfrmLocoAddress";
            this.lbfrmLocoAddress.Size = new System.Drawing.Size(80, 16);
            this.lbfrmLocoAddress.TabIndex = 21;
            this.lbfrmLocoAddress.Text = "ADDRESS";
            // 
            // lstfrmLocoProperties
            // 
            this.lstfrmLocoProperties.Location = new System.Drawing.Point(14, 133);
            this.lstfrmLocoProperties.Name = "lstfrmLocoProperties";
            this.lstfrmLocoProperties.Size = new System.Drawing.Size(291, 108);
            this.lstfrmLocoProperties.TabIndex = 20;
            this.lstfrmLocoProperties.SelectedIndexChanged += new System.EventHandler(this.lstfrmLocoProperties_SelectedIndexChanged);
            this.lstfrmLocoProperties.DoubleClick += new System.EventHandler(this.lstfrmLocoProperties_SelectedIndexChanged);
            // 
            // txtfrmLocoDetail
            // 
            this.txtfrmLocoDetail.Location = new System.Drawing.Point(145, 81);
            this.txtfrmLocoDetail.Name = "txtfrmLocoDetail";
            this.txtfrmLocoDetail.Size = new System.Drawing.Size(160, 20);
            this.txtfrmLocoDetail.TabIndex = 17;
            // 
            // lbfrmLocoDetail
            // 
            this.lbfrmLocoDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfrmLocoDetail.Location = new System.Drawing.Point(14, 84);
            this.lbfrmLocoDetail.Name = "lbfrmLocoDetail";
            this.lbfrmLocoDetail.Size = new System.Drawing.Size(128, 14);
            this.lbfrmLocoDetail.TabIndex = 16;
            this.lbfrmLocoDetail.Text = "LOCATION DETAIL";
            // 
            // txtfrmLocoCityName
            // 
            this.txtfrmLocoCityName.Location = new System.Drawing.Point(145, 55);
            this.txtfrmLocoCityName.Name = "txtfrmLocoCityName";
            this.txtfrmLocoCityName.Size = new System.Drawing.Size(160, 20);
            this.txtfrmLocoCityName.TabIndex = 15;
            // 
            // lbfrmLocoName
            // 
            this.lbfrmLocoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfrmLocoName.Location = new System.Drawing.Point(14, 58);
            this.lbfrmLocoName.Name = "lbfrmLocoName";
            this.lbfrmLocoName.Size = new System.Drawing.Size(80, 20);
            this.lbfrmLocoName.TabIndex = 14;
            this.lbfrmLocoName.Text = "CITY_NAME";
            // 
            // lbfrmLocoType
            // 
            this.lbfrmLocoType.AutoSize = true;
            this.lbfrmLocoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfrmLocoType.Location = new System.Drawing.Point(170, 117);
            this.lbfrmLocoType.Name = "lbfrmLocoType";
            this.lbfrmLocoType.Size = new System.Drawing.Size(39, 13);
            this.lbfrmLocoType.TabIndex = 28;
            this.lbfrmLocoType.Text = "TYPE";
            // 
            // comboBxfrmLocoPropType
            // 
            this.comboBxfrmLocoPropType.FormattingEnabled = true;
            this.comboBxfrmLocoPropType.Location = new System.Drawing.Point(21, 264);
            this.comboBxfrmLocoPropType.Name = "comboBxfrmLocoPropType";
            this.comboBxfrmLocoPropType.Size = new System.Drawing.Size(176, 21);
            this.comboBxfrmLocoPropType.TabIndex = 29;
            // 
            // lbfrmLocoProperties
            // 
            this.lbfrmLocoProperties.AutoSize = true;
            this.lbfrmLocoProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfrmLocoProperties.Location = new System.Drawing.Point(13, 13);
            this.lbfrmLocoProperties.Name = "lbfrmLocoProperties";
            this.lbfrmLocoProperties.Size = new System.Drawing.Size(106, 17);
            this.lbfrmLocoProperties.TabIndex = 30;
            this.lbfrmLocoProperties.Text = "PROPERTIES";
            // 
            // frmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 345);
            this.ControlBox = false;
            this.Controls.Add(this.lbfrmLocoProperties);
            this.Controls.Add(this.comboBxfrmLocoPropType);
            this.Controls.Add(this.lbfrmLocoType);
            this.Controls.Add(this.btnfrmLocoOK);
            this.Controls.Add(this.btnfrmLocoDelete);
            this.Controls.Add(this.btnfrmLocoAdd);
            this.Controls.Add(this.lbfrmLocoAddress);
            this.Controls.Add(this.lstfrmLocoProperties);
            this.Controls.Add(this.txtfrmLocoDetail);
            this.Controls.Add(this.lbfrmLocoDetail);
            this.Controls.Add(this.txtfrmLocoCityName);
            this.Controls.Add(this.lbfrmLocoName);
            this.Name = "frmLocation";
            this.Text = "frmLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnfrmLocoOK;
        internal System.Windows.Forms.Button btnfrmLocoDelete;
        internal System.Windows.Forms.Button btnfrmLocoAdd;
        internal System.Windows.Forms.Label lbfrmLocoAddress;
        internal System.Windows.Forms.ListBox lstfrmLocoProperties;
        internal System.Windows.Forms.TextBox txtfrmLocoDetail;
        internal System.Windows.Forms.Label lbfrmLocoDetail;
        internal System.Windows.Forms.TextBox txtfrmLocoCityName;
        internal System.Windows.Forms.Label lbfrmLocoName;
        private System.Windows.Forms.Label lbfrmLocoType;
        private System.Windows.Forms.ComboBox comboBxfrmLocoPropType;
        private System.Windows.Forms.Label lbfrmLocoProperties;
    }
}
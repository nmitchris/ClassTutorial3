namespace Property
{
    partial class frmApplication
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
            this.lb_AppTotalValue = new System.Windows.Forms.Label();
            this.lbAppTValueCalc = new System.Windows.Forms.Label();
            this.lbfrmTitleApp = new System.Windows.Forms.Label();
            this.lstBxApplications = new System.Windows.Forms.ListBox();
            this.lbAppApplicantEmail = new System.Windows.Forms.Label();
            this.lbAppApplicantAddy = new System.Windows.Forms.Label();
            this.lbAppPropType = new System.Windows.Forms.Label();
            this.lbAppStatus = new System.Windows.Forms.Label();
            this.cmboBxAppActExpPendCan = new System.Windows.Forms.ComboBox();
            this.lbAppLastLeasePeriod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_AppTotalValue
            // 
            this.lb_AppTotalValue.AutoSize = true;
            this.lb_AppTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppTotalValue.Location = new System.Drawing.Point(24, 225);
            this.lb_AppTotalValue.Name = "lb_AppTotalValue";
            this.lb_AppTotalValue.Size = new System.Drawing.Size(114, 17);
            this.lb_AppTotalValue.TabIndex = 0;
            this.lb_AppTotalValue.Text = "TOTAL VALUE";
            // 
            // lbAppTValueCalc
            // 
            this.lbAppTValueCalc.AutoSize = true;
            this.lbAppTValueCalc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAppTValueCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppTValueCalc.Location = new System.Drawing.Point(144, 225);
            this.lbAppTValueCalc.Name = "lbAppTValueCalc";
            this.lbAppTValueCalc.Size = new System.Drawing.Size(134, 19);
            this.lbAppTValueCalc.TabIndex = 1;
            this.lbAppTValueCalc.Text = "                               ";
            // 
            // lbfrmTitleApp
            // 
            this.lbfrmTitleApp.AutoSize = true;
            this.lbfrmTitleApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfrmTitleApp.Location = new System.Drawing.Point(12, 9);
            this.lbfrmTitleApp.Name = "lbfrmTitleApp";
            this.lbfrmTitleApp.Size = new System.Drawing.Size(225, 31);
            this.lbfrmTitleApp.TabIndex = 2;
            this.lbfrmTitleApp.Text = "APPLICATIONS";
            // 
            // lstBxApplications
            // 
            this.lstBxApplications.FormattingEnabled = true;
            this.lstBxApplications.Location = new System.Drawing.Point(18, 69);
            this.lstBxApplications.Name = "lstBxApplications";
            this.lstBxApplications.Size = new System.Drawing.Size(767, 134);
            this.lstBxApplications.TabIndex = 3;
            // 
            // lbAppApplicantEmail
            // 
            this.lbAppApplicantEmail.AutoSize = true;
            this.lbAppApplicantEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppApplicantEmail.Location = new System.Drawing.Point(24, 51);
            this.lbAppApplicantEmail.Name = "lbAppApplicantEmail";
            this.lbAppApplicantEmail.Size = new System.Drawing.Size(125, 15);
            this.lbAppApplicantEmail.TabIndex = 4;
            this.lbAppApplicantEmail.Text = "APPLICANT EMAIL";
            // 
            // lbAppApplicantAddy
            // 
            this.lbAppApplicantAddy.AutoSize = true;
            this.lbAppApplicantAddy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppApplicantAddy.Location = new System.Drawing.Point(206, 51);
            this.lbAppApplicantAddy.Name = "lbAppApplicantAddy";
            this.lbAppApplicantAddy.Size = new System.Drawing.Size(149, 15);
            this.lbAppApplicantAddy.TabIndex = 5;
            this.lbAppApplicantAddy.Text = "APPLICANT ADDRESS";
            // 
            // lbAppPropType
            // 
            this.lbAppPropType.AutoSize = true;
            this.lbAppPropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppPropType.Location = new System.Drawing.Point(415, 51);
            this.lbAppPropType.Name = "lbAppPropType";
            this.lbAppPropType.Size = new System.Drawing.Size(118, 15);
            this.lbAppPropType.TabIndex = 6;
            this.lbAppPropType.Text = "PROPERTY TYPE";
            // 
            // lbAppStatus
            // 
            this.lbAppStatus.AutoSize = true;
            this.lbAppStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppStatus.Location = new System.Drawing.Point(586, 51);
            this.lbAppStatus.Name = "lbAppStatus";
            this.lbAppStatus.Size = new System.Drawing.Size(150, 15);
            this.lbAppStatus.TabIndex = 7;
            this.lbAppStatus.Text = "APPLICATION STATUS";
            // 
            // cmboBxAppActExpPendCan
            // 
            this.cmboBxAppActExpPendCan.FormattingEnabled = true;
            this.cmboBxAppActExpPendCan.Location = new System.Drawing.Point(662, 225);
            this.cmboBxAppActExpPendCan.Name = "cmboBxAppActExpPendCan";
            this.cmboBxAppActExpPendCan.Size = new System.Drawing.Size(121, 21);
            this.cmboBxAppActExpPendCan.TabIndex = 8;
            // 
            // lbAppLastLeasePeriod
            // 
            this.lbAppLastLeasePeriod.AutoSize = true;
            this.lbAppLastLeasePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppLastLeasePeriod.Location = new System.Drawing.Point(243, 24);
            this.lbAppLastLeasePeriod.Name = "lbAppLastLeasePeriod";
            this.lbAppLastLeasePeriod.Size = new System.Drawing.Size(138, 13);
            this.lbAppLastLeasePeriod.TabIndex = 9;
            this.lbAppLastLeasePeriod.Text = "Last Lease Period Only";
            // 
            // frmApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 275);
            this.Controls.Add(this.lbAppLastLeasePeriod);
            this.Controls.Add(this.cmboBxAppActExpPendCan);
            this.Controls.Add(this.lbAppStatus);
            this.Controls.Add(this.lbAppPropType);
            this.Controls.Add(this.lbAppApplicantAddy);
            this.Controls.Add(this.lbAppApplicantEmail);
            this.Controls.Add(this.lstBxApplications);
            this.Controls.Add(this.lbfrmTitleApp);
            this.Controls.Add(this.lbAppTValueCalc);
            this.Controls.Add(this.lb_AppTotalValue);
            this.Name = "frmApplication";
            this.Text = "frmApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AppTotalValue;
        private System.Windows.Forms.Label lbAppTValueCalc;
        private System.Windows.Forms.Label lbfrmTitleApp;
        private System.Windows.Forms.ListBox lstBxApplications;
        private System.Windows.Forms.Label lbAppApplicantEmail;
        private System.Windows.Forms.Label lbAppApplicantAddy;
        private System.Windows.Forms.Label lbAppPropType;
        private System.Windows.Forms.Label lbAppStatus;
        private System.Windows.Forms.ComboBox cmboBxAppActExpPendCan;
        private System.Windows.Forms.Label lbAppLastLeasePeriod;
    }
}
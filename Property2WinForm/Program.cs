// CHRISTOPHER D'ENTREMONT 
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY2WINFORM / 'PROGRAM' CLASS
// CREATES A SERVICE CLIENT VARIABLE - RUNS INSTANCE OF 'FRMMAIN'

using System;
using System.Windows.Forms;

namespace Property2WinForm
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        /// 3.Create a Basic Windows CLient
        /// vii.create a service client variable.
        public static ServiceReference1.Service1Client SvcClient = new ServiceReference1.Service1Client();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //clsCommercial.LoadCommercialForm = new clsCommercial.LoadCommericialFormDelegate(frmCommercial.Run);
            //clsResidential.LoadResidentialForm = new clsResidential.LoadResidentialFormDelegate(frmResidential.Run);
            Application.Run(frmMain.Instance);

            if (SvcClient != null &&
                SvcClient.State != System.ServiceModel.CommunicationState.Closed)
                SvcClient.Close();
        }
    }
}

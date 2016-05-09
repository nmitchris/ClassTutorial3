using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gallery3WinForm
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
        if (SvcClient != null &&
        SvcClient.State != System.ServiceModel.CommunicationState.Closed)
        SvcClient.Close();

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //clsPainting.LoadPaintingForm = new clsPainting.LoadPaintingFormDelegate(frmPainting.Run);
            //clsPhotograph.LoadPhotographForm = new clsPhotograph.LoadPhotographFormDelegate(frmPhotograph.Run);
            //clsSculpture.LoadSculptureForm = new clsSculpture.LoadSculptureFormDelegate(frmSculpture.Run);
            Application.Run(frmMain.Instance);
        }
    }
}

// MATTHIAS OTTO - NMIT SDV701 GALLERY EXAMPLE
// GITHUB - FORKED MODIFIED BY: CHRISTOPHER D'ENTREMONT
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY / 'PROPERTY' STATIC CLASS
// MAIN APPLICATION ENTRY POINT

using System;
using System.Windows.Forms;

namespace Property
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            clsCommercial.LoadCommercialForm = new clsCommercial.LoadCommericialFormDelegate(frmCommercial.Run);
            clsResidential.LoadResidentialForm = new clsResidential.LoadResidentialFormDelegate(frmResidential.Run);
            //clsSculpture.LoadSculptureForm = new clsSculpture.LoadSculptureFormDelegate(frmSculpture.Run);
            Application.Run(frmMain.Instance);
        }
    }
}

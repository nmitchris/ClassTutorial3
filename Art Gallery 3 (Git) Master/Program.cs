using System;
using System.Collections.Generic;
using System.Linq;
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

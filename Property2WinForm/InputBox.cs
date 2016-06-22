// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY2WINFORM / 'INPUTBOX' CLASS / FORM
// FORM ATTRIBUTE OPERATIONS

using System;
using System.Windows.Forms;

namespace Property2WinForm
{
    public partial class InputBox : Form
    {
        private string _Answer;

        public InputBox(string question)
        {
            InitializeComponent();
            lblQuestion.Text = question;
            lblError.Text = "";
            txtAnswer.Focus();
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _Answer = txtAnswer.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string Answer
        {
            get { return _Answer; }
            //set { mAnswer = value; }
        }
    }
}
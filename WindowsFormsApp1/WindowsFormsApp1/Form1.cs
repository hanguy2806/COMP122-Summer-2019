using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Lab08 : Form
    {
        public string UserName { get; set; }
        public double UserAge { get; set; }
        public Lab08()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is the event handler when form loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08_Load(object sender, EventArgs e)
        {
            SubmitBtn.Enabled = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            UserName = NameTxtBox.Text;
            UserAge = Convert.ToDouble(agetxtbx.Text);
            outputLbl.Text = UserName + " " + UserAge;

            //clear form
            NameTxtBox.Text = string.Empty;
            agetxtbx.Text = string.Empty;

        }

        private void Agetxtbx_TextChanged(object sender, EventArgs e)
        {
            SubmitBtn.Enabled = true;
        }

        private void OutputLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

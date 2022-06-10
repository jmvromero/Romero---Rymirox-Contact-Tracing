using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romero___Rymirox__Contact_Tracing
{
    public partial class AboutScreenForm3 : Form
    {
        public AboutScreenForm3()
        {
            InitializeComponent();
        }

        private void buttonASF1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutScreenForm2 aboutScreenForm = new AboutScreenForm2();
            aboutScreenForm.Show();
        }

        private void buttonASF2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutScreenForm4 aboutScreenForm4 = new AboutScreenForm4();
            aboutScreenForm4.Show();
        }
    }
}

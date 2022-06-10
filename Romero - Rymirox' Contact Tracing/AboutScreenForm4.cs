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
    public partial class AboutScreenForm4 : Form
    {
        public AboutScreenForm4()
        {
            InitializeComponent();
        }

        private void buttonASF4_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreenForm startingScreenForm = new StartingScreenForm();
            startingScreenForm.Show();
        }

        private void buttonASF4_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutScreenForm3 aboutScreenForm = new AboutScreenForm3();
            aboutScreenForm.Show();
        }
    }
}

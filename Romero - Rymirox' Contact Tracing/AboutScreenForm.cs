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
    public partial class AboutScreenForm : Form
    {
        public AboutScreenForm()
        {
            InitializeComponent();
        }

        private void buttonASF1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreenForm startingScreenForm = new StartingScreenForm();   
            startingScreenForm.Show();

        }

        private void buttonASF2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutScreenForm2 aboutScreenForm = new AboutScreenForm2();
            aboutScreenForm.Show();
        }
    }
}

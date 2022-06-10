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
    public partial class ContinueOptions : Form
    {
        public ContinueOptions()
        {
            InitializeComponent();
        }

        private void buttonLSF2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FillOutForm fillOutForm = new FillOutForm();
            fillOutForm.ShowDialog();
        }

        private void buttonCO2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCO3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreenForm startingScreenForm = new StartingScreenForm();
            startingScreenForm.ShowDialog();
        }
    }
}

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
    public partial class FindingRecordOptions : Form
    {
        public FindingRecordOptions()
        {
            InitializeComponent();
        }

        private void buttonFRO1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListingForm listingForm = new ListingForm();
            listingForm.ShowDialog();
        }

        private void buttonFRO3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreenForm startingScreenForm = new StartingScreenForm();
            startingScreenForm.ShowDialog();
        }

        private void buttonFRO2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QRCodeScannerForm qRCodeScannerForm = new QRCodeScannerForm();
            qRCodeScannerForm.ShowDialog();
        }
    }
}

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
    public partial class RegisterScreenForm : Form
    {
        public RegisterScreenForm()
        {
            InitializeComponent();
        }

        private void buttonLSF2_Click(object sender, EventArgs e)
        {
            RegistrationProcess();
            PasswordSystem();
        }

        public void RegistrationProcess()
        {
            string input1 = textBoxRSF1.Text;
            string input2 = textBoxRSF2.Text;
            string input3 = textBoxRSF3.Text;
        }

        public void PasswordSystem()
        {
            string input1 = textBoxRSF1.Text;
            string input2 = textBoxRSF2.Text;
            string input3 = textBoxRSF3.Text;

            bool passConfirmation = input2 == input3 && input2 != input1 && input3 != input1;
            if (passConfirmation)
            {
                MessageBox.Show("Registration Successful! Login Now.");
            }
            else
            {
                MessageBox.Show("Try Again");
            }

        }

        private void buttonRSF1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreenForm frm = new LoginScreenForm();    
            frm.ShowDialog();
        }
    }
}

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
    public partial class LoginScreenForm : Form
    {
        public LoginScreenForm()
        {
            InitializeComponent();
        }

        private void buttonLSF1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreenForm startingScreenForm = new StartingScreenForm();
            startingScreenForm.Show();
        }

        private void labelLSF8_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterScreenForm registerScreenForm = new RegisterScreenForm();
            registerScreenForm.Show();
        }

        private void buttonLSF2_Click(object sender, EventArgs e)
        {
            string input1 = textBoxLSF1.Text;
            string input2 = textBoxLSF2.Text;


            bool LoginSuccessful = input1 != input2;
            if (LoginSuccessful)
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                FillOutForm fillOutForm = new FillOutForm();
                fillOutForm.Show();
            }
            else if (input1 == input2)
            {
                input1 = ("");
                input2 = ("");
                MessageBox.Show("Try Again");
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Romero___Rymirox__Contact_Tracing
{
    public partial class FillOutForm : Form
    {
        public FillOutForm()
        {
            InitializeComponent();
        }

        private void buttonLSF2_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    string filePath = @"C:\Users\Romero\Desktop"+"\\Rymirox Contact Tracing\\"+textBoxFOF2.Text+".txt";
            //    StreamWriter streamWriter = new StreamWriter(filePath);
            //    using (streamWriter)
            //    {
            //        streamWriter.WriteLine(labelFOF3);
            //        streamWriter.WriteLine(labelFOF4);
            //        streamWriter.WriteLine(labelFOF5);
            //        streamWriter.WriteLine(labelFOF6 +":" + textBoxFOF1.Text);
            //        streamWriter.WriteLine(labelFOF8 +":" + textBoxFOF2.Text);
            //        streamWriter.WriteLine(labelFOF10 +":" + textBoxFOF3.Text);
            //        streamWriter.WriteLine(labelFOF12 +":" + comboBoxFOF1.Text);
            //        streamWriter.WriteLine(labelFOF13 +":" + textBoxFOF4.Text);
            //        streamWriter.WriteLine(labelFOF14);
            //        streamWriter.WriteLine(labelFOF15 +":" + textBoxFOF5.Text);
            //        streamWriter.WriteLine(labelFOF16 +":" + textBoxFOF6.Text);
            //        streamWriter.WriteLine(labelFOF19);
            //        streamWriter.WriteLine(labelFOF20 +":" + textBoxFOF7.Text);
            //        streamWriter.WriteLine(labelFOF22 +":" + textBoxFOF8.Text);
            //        streamWriter.WriteLine(labelFOF24 +":" + textBoxFOF9.Text);
            //        streamWriter.WriteLine(labelFOF26 +":" + textBoxFOF10.Text);
            //        streamWriter.WriteLine(labelFOF28 +":" + textBoxFOF11.Text);
            //        streamWriter.WriteLine(labelFOF30);
            //        streamWriter.WriteLine(labelFOF31 + comboBoxFOF2.Text);
            //        streamWriter.WriteLine(labelFOF32 + comboBoxFOF3.Text);
            //        streamWriter.WriteLine(labelFOF33 + comboBoxFOF4.Text); 
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error");
            //    MessageBox.Show("Please Try Again");
            //}

            string input1 = textBoxFOF1.Text;
            string input2 = textBoxFOF2.Text;
            string input3 = textBoxFOF3.Text;
            string input4 = textBoxFOF4.Text;
            string input5 = textBoxFOF5.Text;
            string input6 = textBoxFOF6.Text;
            string input7 = textBoxFOF7.Text;
            string input8 = textBoxFOF8.Text;
            string input9 = textBoxFOF9.Text;
            string input10 = textBoxFOF10.Text;
            string input11 = textBoxFOF11.Text;
            string input12 = comboBoxFOF1.Text;
            string input13 = comboBoxFOF2.Text;
            string input14 = comboBoxFOF3.Text;
            string input15 = comboBoxFOF4.Text;

            bool BlankInfo = input1 == "" || input2 == "";
            if (BlankInfo)
            {
                MessageBox.Show("Please Try Again");
            }
            else
            {
                string filePath = @"C:\Users\Romero\Desktop" + "\\Rymirox Contact Tracing\\" + textBoxFOF2.Text + ".txt";
                StreamWriter streamWriter = new StreamWriter(filePath);
                using (streamWriter)
                {
                    streamWriter.WriteLine("Rymirox Contact Tracing");
                    streamWriter.WriteLine("Serving you the best Contact Tracing Form for your safety and security!");
                    streamWriter.WriteLine("Personal Information");
                    streamWriter.WriteLine("First Name: " + textBoxFOF1.Text);
                    streamWriter.WriteLine("Last Name: " + textBoxFOF2.Text);
                    streamWriter.WriteLine("Middle Name: " + textBoxFOF3.Text);
                    streamWriter.WriteLine("Gender: " + comboBoxFOF1.Text);
                    streamWriter.WriteLine("Birthdate: " + textBoxFOF4.Text);
                    streamWriter.WriteLine("Contact Address");
                    streamWriter.WriteLine("Contact No.: " + textBoxFOF5.Text);
                    streamWriter.WriteLine("Email Address: " + textBoxFOF6.Text);
                    streamWriter.WriteLine("Location Address");
                    streamWriter.WriteLine("Country: " + textBoxFOF7.Text);
                    streamWriter.WriteLine("House Number: " + textBoxFOF8.Text);
                    streamWriter.WriteLine("Barangay: " + textBoxFOF9.Text);
                    streamWriter.WriteLine("Province: " + textBoxFOF10.Text);
                    streamWriter.WriteLine("City: " + textBoxFOF11.Text);
                    streamWriter.WriteLine("Health Check");
                    streamWriter.WriteLine("Do you have any of the following symptom/s: " + comboBoxFOF2.Text);
                    streamWriter.WriteLine("Do you have pending COVID-19 Test result?: " + comboBoxFOF3.Text);
                    streamWriter.WriteLine("Have you been exposed to a sick person or suspect, probable or confirmed COVID-19 case in the past 14 days?: " + comboBoxFOF4.Text);
                }
                MessageBox.Show("Your contact tracing was successful. Check in your Folder.");
                this.Hide();
                ContinueOptions continueOptions = new ContinueOptions();
                continueOptions.ShowDialog();
            }

        }

        private void buttonLSF3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreenForm startingScreenForm = new StartingScreenForm();
            startingScreenForm.ShowDialog();
        }
    }
}

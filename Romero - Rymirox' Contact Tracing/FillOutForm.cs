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
        bool generatedForm = false; 
        public FillOutForm()
        {
            InitializeComponent();
        }

        private void buttonLSF2_Click(object sender, EventArgs e)
        {
            
            fileWriter();
            newFile();
            


            //string filePath1 = @"C:\Users\Romero\Desktop\Rymirox Contact Tracing\Records.txt";
            //StreamWriter file = new StreamWriter(filePath1);
            //using (file)
            //{
            //    file.WriteLine(datelabel1.Text);
            //    file.WriteLine("Rymirox Contact Tracing");
            //    file.WriteLine("Serving you the best Contact Tracing Form for your safety and security!");
            //    file.WriteLine("Personal Information");
            //    file.WriteLine("First Name: " + textBoxFOF1.Text);
            //    file.WriteLine("Last Name: " + textBoxFOF2.Text);
            //    file.WriteLine("Middle Name: " + textBoxFOF3.Text);
            //    file.WriteLine("Gender: " + comboBoxFOF1.Text);
            //    file.WriteLine("Birthdate: " + textBoxFOF4.Text);
            //    file.WriteLine("Contact Address");
            //    file.WriteLine("Contact No.: " + textBoxFOF5.Text);
            //    file.WriteLine("Email Address: " + textBoxFOF6.Text);
            //    file.WriteLine("Location Address");
            //    file.WriteLine("Country: " + textBoxFOF7.Text);
            //    file.WriteLine("House Number: " + textBoxFOF8.Text);
            //    file.WriteLine("Barangay: " + textBoxFOF9.Text);
            //    file.WriteLine("Province: " + textBoxFOF10.Text);
            //    file.WriteLine("City: " + textBoxFOF11.Text);
            //    file.WriteLine("Health Check");
            //    file.WriteLine("Do you have any of the following symptom/s: " + comboBoxFOF2.Text);
            //    file.WriteLine("Do you have pending COVID-19 Test result?: " + comboBoxFOF3.Text);
            //    file.WriteLine("Have you been exposed to a sick person or suspect, probable or confirmed COVID-19 case in the past 14 days?: " + comboBoxFOF4.Text);
            //}
        }

        private void fileWriter()
        {
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

            bool BlankInfo = (input1 == "" || input2 == "") || (input3 == "" || input4 == "") || (input5 == "" || input6 == "") || (input7 == "" || input8 == "") || (input9 == "" || input10 == "") || (input11 == "" || input12 == "") || (input13 == "" || input14 == "") || (input15 == "" || input14 == "");
            if (BlankInfo)
            {
                MessageBox.Show("Please Try Again");
            }
            else
            {
                string filePath = @"C:\Users\Romero\Desktop" + "\\Rymirox Contact Tracing\\" + textBoxFOF2.Text + datetextBox1.Text + ".txt";
                StreamWriter streamWriter = new StreamWriter(filePath);
                using (streamWriter)
                {
                    streamWriter.WriteLine(datetextBox1.Text);
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

        private void FillOutForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            datelabel1.Text = DateTime.Now.ToLongDateString();
            timelabel1.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelabel1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void buttonLSF3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreenForm loginScreenForm = new LoginScreenForm();
            loginScreenForm.ShowDialog();

        }
        
        private void newFile()
        {
            string input1 = datetextBox1.Text;
            bool june23date = true;
            if (june23date = input1 == "Thursday, June 23, 2022")
            {
                string filePath = @"C:\Users\Romero\Desktop" + "\\Rymirox Contact Tracing\\" + datetextBox1.Text + ".txt";
                StreamWriter str = new StreamWriter(filePath);
                using (str)
                {
                    str.WriteLine(datelabel1.Text + " " + textBoxFOF2);
                }
            }
            else if (june23date = input1 == "Friday, June 24, 2022")
            {
                string filePath = @"C:\Users\Romero\Desktop" + "\\Rymirox Contact Tracing\\" + datetextBox1.Text + ".txt";
                StreamWriter streamWriter = new StreamWriter(filePath);
                using (streamWriter)
                {
                    streamWriter.WriteLine(datelabel1.Text + " " + textBoxFOF2);
                }
            }
            else if (june23date = input1 == "Saturday, June 25, 2022")
            {
                string filePath = @"C:\Users\Romero\Desktop" + "\\Rymirox Contact Tracing\\" + datetextBox1.Text + ".txt";
                StreamWriter streamWriter = new StreamWriter(filePath);
                using (streamWriter)
                {
                    streamWriter.WriteLine(datelabel1.Text + " " + textBoxFOF2);
                }
            }
        }

        private void saveButtonFOF1_Click(object sender, EventArgs e)
        {
            if (generatedForm)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                pictureBoxFOF1.Image.Save(path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg");
                
                MessageBox.Show("Your QR Code is now saved");
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }
            

        private void qrcodebuttonFOF1_Click(object sender, EventArgs e)
        {
            generatedForm = true;
            qrcode();
        }
        private void qrcode()
        {
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

            bool BlankInfo = (input1 == "" || input2 == "") || (input3 == "" || input4 == "") || (input5 == "" || input6 == "") || (input7 == "" || input8 == "") || (input9 == "" || input10 == "") || (input11 == "" || input12 == "") || (input13 == "" || input14 == "") || (input15 == "" || input14 == "");
            if (BlankInfo)
            {
                MessageBox.Show("Please Try Again");
            }
            else
            {
                pictureBoxFOF1.SizeMode = PictureBoxSizeMode.StretchImage;
                Zen.Barcode.CodeQrBarcodeDraw qrBarcodeDraw = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBoxFOF1.Image = qrBarcodeDraw.Draw(datetextBox1.Text + " " + "Rymirox Contact Tracing" + " " + "Personal Information" + " " + "First Name: " + textBoxFOF1.Text + " " + "Last Name: " + textBoxFOF2.Text + " " + "Middle Name: " + textBoxFOF3.Text + " " + "Gender: " + comboBoxFOF1.Text + " " + "Birthdate: " + textBoxFOF4.Text + " ", Height);


            }

        }

    }
}

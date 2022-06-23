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
    public partial class ListingForm : Form
    {
        public ListingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input1 = textBoxLF1.Text;
            string input2 = textBoxLF2.Text;

         

            bool blankInfo = input1 == "" || input2 == ""; 
            if (blankInfo)
            {
                MessageBox.Show("Please Try Again");
            }
            else
            {
                StreamReader reader = new StreamReader(@"C:\Users\Romero\Desktop" + "\\Rymirox Contact Tracing\\" + textBoxLF1.Text + textBoxLF2.Text + ".txt");
                ListBox Records = new ListBox();

                String all = reader.ReadToEnd();

                MessageBox.Show(all);
                

                reader.Close();
            }

           
             
            }

        private void button2_Click(object sender, EventArgs e)
        {

            string input3 = dateTimePicker1.Text;

           
            
            
            
            const int SIZE = 22;
            string[] numbers = new string[SIZE];
            int index = 0;

            StreamReader inputFile;
            inputFile = File.OpenText(@"C:\Users\Romero\Desktop" + "\\Rymirox Contact Tracing\\" + "ContactTracing.txt");

            while (index < numbers.Length && !inputFile.EndOfStream)
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                numbers[index] = inputFile.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                index++;
            }
            inputFile.Close();
            foreach (string value in numbers)
            {
                recordlistbox1.Items.Add(value);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreenForm startingScreenForm = new StartingScreenForm();   
            startingScreenForm.ShowDialog();
        }
    }
}

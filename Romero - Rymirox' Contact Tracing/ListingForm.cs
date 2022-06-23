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
            StreamReader reader = new StreamReader(@"C:\Users\Romero\Desktop" + "\\Rymirox Contact Tracing\\" + textBoxLF1.Text + textBoxLF2.Text + ".txt");
            ListBox Records = new ListBox();

            String all = reader.ReadToEnd();
       
            MessageBox.Show(all);


            //using (var output = File.Create("output"))
            //{
            //    foreach (var file in new[] { "file1", "file2" })
            //    {
            //        using (var input = File.OpenRead(file))
            //        {
            //            input.CopyTo(output);
            //        }
            //    }
            //}

        }
    }
}

namespace Romero___Rymirox__Contact_Tracing
{
    public partial class StartingScreenForm : Form
    {
        public StartingScreenForm()
        {
            InitializeComponent();
        }

        private void buttonSSM1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreenForm loginScreenForm = new LoginScreenForm();
            loginScreenForm.ShowDialog();
        }

        private void buttonSSM2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutScreenForm aboutScreenForm = new AboutScreenForm();
            aboutScreenForm.ShowDialog();  
        }

        private void buttonSSM3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListingForm listingForm = new ListingForm();
            listingForm.ShowDialog();
        }
    }
}
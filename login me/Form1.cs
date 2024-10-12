namespace login_me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(String.Compare(txt_user.Text,"Maryam")==0 && String.Compare(txt_pass.Text,"22011556-009")==0)
            {
                MessageBox.Show("Login successful");
            }
            else
            {
                MessageBox.Show("login failed");
            }


        }
    }
}

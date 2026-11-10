namespace program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            MessageBox.Show("please enter your name" + username + "the password is " + password);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if ((username.Trim() != "") && (password.Trim() != ""))
            {
                Form_stocks stock = new Form_stocks();
                stock.Show();
                this.Hide();
                txtusername.Text = "";
                txtpassword.Text = "";
                
            }
            else
            {
                MessageBox.Show("The username and password cannot be empty");
            }
        }
    }
}

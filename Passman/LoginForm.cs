using Passman.Properties;

namespace Passman
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == Settings.Default.Username && txtPassword.Text == Settings.Default.Password)
            {
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }
            else { MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
    }
}

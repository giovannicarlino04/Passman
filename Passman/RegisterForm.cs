using Passman.Properties;

namespace Passman
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                Settings.Default.Username = txtUsername.Text;
                Settings.Default.Password = txtPassword.Text;
                Settings.Default.Save();
                this.Close();
            }
        }
    }
}

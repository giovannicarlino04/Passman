using Passman.Properties;

namespace Passman
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Accounts == null)
                Settings.Default.Accounts = new System.Collections.Specialized.StringCollection();

            lbAccounts.Items.Clear();
            foreach (string item in Settings.Default.Accounts)
            {
                string[] FullAccount = item.Split("|");
                lbAccounts.Items.Add(FullAccount[0]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbService.Text.Length > 0 && tbEmail.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                Settings.Default.Accounts.Add($"{tbService.Text}|" +
                    $"{tbEmail.Text}|{tbPassword.Text}");
                Settings.Default.Save();

                lbAccounts.Items.Clear();
                foreach (string item in Settings.Default.Accounts)
                {
                    string[] FullAccount = item.Split("|");
                    lbAccounts.Items.Add(FullAccount[0]);
                }
            }
            else
            {
                // Do nothing
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Settings.Default.Accounts.RemoveAt(lbAccounts.SelectedIndex);
            Settings.Default.Save();
            lbAccounts.Items.RemoveAt(lbAccounts.SelectedIndex);
        }

        private void lbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAccounts.SelectedIndex != -1)
            {

                string[] FullAccount = Settings.Default.Accounts[lbAccounts.SelectedIndex].Split("|");
                tbService.Text = FullAccount[0];
                tbEmail.Text = FullAccount[1];
                tbPassword.Text = FullAccount[2];

            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? This will delete all of your passwords!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.Default.Reset();
                this.Close();
            }
        }
    }
}

#nullable disable
namespace Login_Sign_in
{
    public partial class LGF : Form
    {
        public LGF()
        {
            InitializeComponent();
            Thm.Apply(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPassword.Text;

            if (user == "" || pass == "")
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            try
            {
                if (Db.Login(user, pass))
                {
                    var dash = new DBF(user);
                    dash.FormClosed += (s, args) =>
                    {
                        if (dash.LoggedOut)
                        {
                            txtUser.Clear();
                            txtPassword.Clear();
                            Show();
                            txtUser.Focus();
                        }
                        else
                        {
                            Close();
                        }
                    };
                    Hide();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var f = new SUF();
            f.ShowDialog(this);
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var f = new FPF();
            f.ShowDialog(this);
        }
    }
}

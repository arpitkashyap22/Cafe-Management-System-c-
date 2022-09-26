using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you really want to close?", "Alert!!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGuestLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard d = new Dashboard("Guest");
            d.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Dashboard d = new Dashboard("Admin");

            if (txtUsername.Text == "Admin" && txtPassword.Text == "root")
            {
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your username of Password is wrong. Please try again.", "Alert", MessageBoxButtons.OK);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }
    }
}


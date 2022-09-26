using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btnAdd.Hide();
                btnRemove.Hide();
                btnUpdate.Hide();
            }
            else if (user == "Admin")
            {
                btnAdd.Show();
                btnRemove.Show();
                btnUpdate.Show();
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userAddItem1.Visible = false;
            userPlaceOrder1.Visible = false;
            userUpdateItem1.Visible = false;
            userRemoveItem1.Visible = false;

        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you really want to exit?", "Alert!!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm l1 = new LoginForm();
            l1.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userAddItem1.Visible = true;
            userAddItem1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            userWelcome1.SendToBack();
            userPlaceOrder1.Visible = true;
            userPlaceOrder1.BringToFront();
        }

        private void userAddItem1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            userUpdateItem1.Visible = true;
            userUpdateItem1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            userRemoveItem1.Visible = true;
            userRemoveItem1.BringToFront();
        }
    }
}

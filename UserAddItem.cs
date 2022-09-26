using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserAddItem : UserControl
    {
        Sqlfunction con = new Sqlfunction();
        String querry;
        public UserAddItem()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtName.Clear();
            txtPrice.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            querry = "insert into items (name, price, category) values ('" + txtName.Text + "', " + txtPrice.Text + ", '" + txtCategory.Text + "')";
            con.SetData(querry);
            clearAll();
        }

        private void UserAddItem_Load(object sender, EventArgs e)
        {

        }

        private void UserAddItem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}

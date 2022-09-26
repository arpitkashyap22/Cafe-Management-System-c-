using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserUpdateItem : UserControl
    {
        Sqlfunction fn = new Sqlfunction();
        string query;
        public UserUpdateItem()
        {
            InitializeComponent();
        }

        private void UserUpdateItem_Load(object sender, System.EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.GetData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, System.EventArgs e)
        {
            query = "select * from items where name like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            string name = guna2DataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price= int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());

            txtCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            query = "update items set name = '" + txtName.Text + "', price = " + txtPrice.Text + ",category = '" + txtCategory.Text + "' where id = "+id+"";
            fn.GetData(query);
            loadData();

            txtName.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
        }

        private void UserUpdateItem_Enter(object sender, System.EventArgs e)
        {
            loadData();
        }
    }
}

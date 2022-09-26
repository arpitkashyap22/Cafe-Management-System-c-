using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserRemoveItem : UserControl
    {
        Sqlfunction fn = new Sqlfunction();
        string query;

        public UserRemoveItem()
        {
            InitializeComponent();
        }

        private void UserRemoveItem_Load(object sender, EventArgs e)
        {
            lblDelete.Text = "How to Delete?";
            lblDelete.ForeColor = Color.BlueViolet;
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.GetData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item?","Importent message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where id = " + id + "";
                fn.SetData(query);
                loadData();
            }
        }

        private void UserRemoveItem_Enter(object sender, EventArgs e)
        {
            loadData();
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Click on row you want to delete and then click ok Button.", "How to Delete", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

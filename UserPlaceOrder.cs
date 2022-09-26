using DGVPrinterHelper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserPlaceOrder : UserControl
    {
        Sqlfunction fn = new Sqlfunction();
        string query;
        
        public UserPlaceOrder()
        {
            InitializeComponent();
        }

        private void showItemList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.GetData(query);

            for(int i = 0; i<ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string Category = txtCategory.Text; 
            query = " select name from items where category = '"+Category+"'";
            showItemList(query);
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            string Category = txtCategory.Text;
            query = "select name from items where category = '" + Category+ "' and name like '" + txtSearch.Text + "%'";
            showItemList(query);
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            quantityUpDown.ResetText();
            txtTotal.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;

            query = "select price from items where name ='" + text + "'";
            DataSet ds = fn.GetData(query);

            try
            {
                txtRate.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void quantityUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            int quant = int.Parse(quantityUpDown.Value.ToString());
            int rate = int.Parse(txtRate.Text);
            txtTotal.Text = (quant * rate).ToString();
        }

        protected int n, total = 0;

        int ammount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ammount = int.Parse(guna2DataGridView1.Rows[e.RowIndex]
                    .Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= ammount;
            lblGrandTotal.Text = "Rs. " + total;
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Toatal Payable Ammount : " + lblGrandTotal.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            guna2DataGridView1.Rows.Clear();
            lblGrandTotal.Text = "Rs. " + total;
        }

        private void btnAddToCart_Click(object sender, System.EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtRate.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = quantityUpDown.Value;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total = total + int.Parse(txtTotal.Text);
                lblGrandTotal.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity Needed to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

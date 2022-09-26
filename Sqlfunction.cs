using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Sqlfunction
    {

        //public void connection()
        //{
        //con = new MySqlConnection("Datasource = localhost;Database=cafe;port=3306;User Id=root;Password=arpit");
        //try
        //{
        //  con.Open();
        //output = "sucess";
        // Perform database operations
        //}
        //catch (Exception e) {
        //output = "Unsucessfull";
        //}
        //con.Close();
        //}
        protected MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection("Datasource = localhost;Database=cafe;port=3306;User Id=root;Password=arpit");
            return con;
        }

        public DataSet GetData(string query)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void SetData(string query)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Processed sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



    }
}

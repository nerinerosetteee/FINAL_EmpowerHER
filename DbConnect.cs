using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AOOP_EmpowerHER
{
    internal class DbConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;

        public string connection()
        {
            con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drich\Source\Repos\FINAL_EmpowerHER\EmpowerHER.mdf;Integrated Security=True";
            return con;
        }

        protected SqlConnection getconn()
        {
            SqlConnection conn = new SqlConnection(con);
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\drich\\source\\repos\\FINAL_EmpowerHER\\EmpowerHER.mdf;Integrated Security=True";
            return conn;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getconn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }

        public void setData(String query, String msg)
        {
            SqlConnection con = getconn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}

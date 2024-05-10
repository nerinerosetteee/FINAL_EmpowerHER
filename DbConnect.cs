using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AOOP_EmpowerHER
{
    internal class DbConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;

        public string connection()
        {
            con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drich\source\repos\AOOP_EmpowerHER\EmpowerHER.mdf;Integrated Security = True";
            return con;
        }
    }
}

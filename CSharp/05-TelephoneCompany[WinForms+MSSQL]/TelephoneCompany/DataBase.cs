using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TelephoneCompany
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=TelephoneCompany;Integrated Security=True");
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
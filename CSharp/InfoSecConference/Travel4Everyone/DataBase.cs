using MySqlConnector;

namespace Travel4Everyone
{
    internal class DataBase
    {
        private readonly MySqlConnection connection;

        public DataBase()
        {
            string connectionString = "server=bievlwhqcoznqoddspye-mysql.services.clever-cloud.com;user=uyump16dybce4wps;database=bievlwhqcoznqoddspye;password=4PghoqgVcuyEBUH52L5u;";
            /*string connectionString = "server=localhost;user=danilch;database=neww;password=danilch;Allow User Variables=true;";*/
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}

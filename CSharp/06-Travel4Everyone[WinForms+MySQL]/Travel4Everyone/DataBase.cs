using MySqlConnector;

namespace Travel4Everyone
{
	internal class DataBase
	{
		private readonly MySqlConnection connection;

		public DataBase()
		{
			string connectionString = "server=bvniajs9gycvi86nlzhw-mysql.services.clever-cloud.com;user=ufwojncblj5qpezl;database=bvniajs9gycvi86nlzhw;password=TITuHnVVniReDFUfcPLj;";

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

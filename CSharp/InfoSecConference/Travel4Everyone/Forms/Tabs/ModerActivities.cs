using MySqlConnector;
using System.Data;
using System.Windows.Forms;

namespace Travel4Everyone.UserControls
{
    public partial class ModerActivities : UserControl
    {
        private readonly DataBase database = new DataBase();
        public ModerActivities()
        {
            InitializeComponent();
        }
        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            _ = dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetDateTime(3), record.GetInt32(4), record.GetString(5), record.GetInt32(6), record.GetValue(7), record.GetString(8), record.GetString(9), record.GetString(10), record.GetString(11), record.GetString(12), record.GetString(13), record.GetString(14));
            dgw.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
        }
        public void RefreshDataGrid(DataGridView dgw, string currentUserName)
        {
            dgw.Rows.Clear();
            string querystring = $"SELECT * FROM Activities WHERE ModeratorName = @CurrentUserName";
            MySqlCommand command = new MySqlCommand(querystring, database.GetConnection());
            _ = command.Parameters.AddWithValue("@CurrentUserName", currentUserName);

            database.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
            database.CloseConnection();
        }
    }
}
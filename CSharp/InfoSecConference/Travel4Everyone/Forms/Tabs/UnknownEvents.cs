using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Travel4Everyone.UserControls
{
    public partial class UnknownEvents : UserControl
    {
        private readonly DataBase database = new DataBase();

        public UnknownEvents()
        {
            InitializeComponent();
        }

        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            // Пример: Если Image хранится в базе как byte[] (BLOB)
            byte[] imageData = DBNull.Value.Equals(record[1]) ? null : (byte[])record[1];
            Image image = ByteArrayToImage(imageData);

            _ = dgw.Rows.Add(record.GetInt32(0), image, record.GetString(2), record.GetDateTime(3), record.GetInt32(4), record.GetString(5));
            dgw.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        public void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string querystring = "SELECT E.ID, E.Image, E.EventName, E.EventDate, E.Duration, C.Name FROM Events E JOIN Cities C ON E.CityID = C.ID;";  // Замени на свой запрос
            MySqlCommand command = new MySqlCommand(querystring, database.GetConnection());
            database.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
            database.CloseConnection();
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }

            ImageConverter converter = new ImageConverter();
            Image image = (Image)converter.ConvertFrom(byteArrayIn);

            return image;
        }
    }
}

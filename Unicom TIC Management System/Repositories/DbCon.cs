using System;
using System.Data.SQLite;
using System.IO;

namespace Unicom_TIC_Management_System.Repositories
{
    public static class DbCon
    {
        private static SQLiteConnection _connection;
        private static readonly string _dbFilePath = "unicomtic.db";  // You can change path if needed

        public static SQLiteConnection GetConnection()
        {
            try
            {
                if (_connection == null)
                {
                    // Create database file if it doesn't exist
                    if (!File.Exists(_dbFilePath))
                    {
                        SQLiteConnection.CreateFile(_dbFilePath);
                    }

                    _connection = new SQLiteConnection($"Data Source={_dbFilePath};Version=3;");
                    _connection.Open();

                    // Ensure tables are created when connection is first established
                    DatabaseManager.CreateTables();
                }
                else if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }

                return _connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to connect to the SQLite database.", ex);
            }
        }
    }
}

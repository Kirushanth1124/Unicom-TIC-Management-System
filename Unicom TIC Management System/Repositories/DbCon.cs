using System;
using System.Data.SQLite;
using System.IO;

namespace Unicom_TIC_Management_System.Repositories
{
    public static class DbCon
    {
        // Database file path - App-ன் bin folder ல் unicomtic.db உருவாக்கப்படும்
        private static readonly string DbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "unicomtic.db");

        public static SQLiteConnection GetConnection()
        {
            string connectionString = "Data Source=unicomtic.db;Version=3;";
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }


    }
}

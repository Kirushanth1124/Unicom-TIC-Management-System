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
            if (!File.Exists(DbFilePath))
            {
                SQLiteConnection.CreateFile(DbFilePath);
            }

            var connection = new SQLiteConnection($"Data Source={DbFilePath};Version=3;");
            connection.Open();

            using (var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", connection))
            {
                pragmaCmd.ExecuteNonQuery();
            }

            DatabaseManager.CreateTables(connection); // இங்க இச்செயலை செய்ய வேண்டும்

            return connection;
        }

    }
}

using System;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    internal class LoginController
    {
        /// <summary>
        /// Validates login credentials and returns the user object if successful.
        /// </summary>
        public User Login(string username, string password)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); // plain text as per spec

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserId = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2),
                        Role = reader.GetString(3)
                    };
                }
            }

            // Return null if login fails
            return null;
        }

        /// <summary>
        /// Optional: Check if a username already exists (e.g., for Admin registration logic)
        /// </summary>
        public bool UsernameExists(string username)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        /// <summary>
        /// Optional: Add a new user (e.g., Admin creates user accounts)
        /// </summary>
        public void AddUser(User user)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)", conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password); // still plain text
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

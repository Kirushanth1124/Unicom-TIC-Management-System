using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    internal class LoginController
    {
        public User Login(string username, string password, string role)
        {
            using (var conn = DbCon.GetConnection())
            {
                using (var cmd = new SQLiteCommand(
                    "SELECT UserID, Username, Password, Role FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Password = reader.GetString(2),
                                Role = reader.GetString(3)
                            };
                        }
                    }
                    return null;
                }
            }
        }

        public void AddUser(User user)
        {
            using (var conn = DbCon.GetConnection())
            {
                using (var cmd = new SQLiteCommand(
                    "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool UsernameExists(string username)
        {
            using (var conn = DbCon.GetConnection())
            {
                using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}

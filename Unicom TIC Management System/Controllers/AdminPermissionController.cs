using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    public class AdminPermissionController
    {
        public List<AppUser> GetAllUsers()
        {
            var list = new List<AppUser>();

            using (var conn = DbCon.GetConnection())
            {
                // Ensure foreign keys are enabled for this connection
                EnableForeignKeys(conn);

                var cmd = new SQLiteCommand("SELECT * FROM Users", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new AppUser
                    {
                        UserID = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2),
                        Role = reader.GetString(3),
                        Name = GetNameFromRole(reader.GetInt32(0), reader.GetString(3), conn)
                    });
                }
            }

            return list;
        }

        public void AddUser(AppUser user)
        {
            using (var conn = DbCon.GetConnection())
            {
                EnableForeignKeys(conn);

                // Insert into Users and get new UserID
                var cmd = new SQLiteCommand("INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r); SELECT last_insert_rowid();", conn);
                cmd.Parameters.AddWithValue("@u", user.Username);
                cmd.Parameters.AddWithValue("@p", user.Password);
                cmd.Parameters.AddWithValue("@r", user.Role);
                long userId = (long)cmd.ExecuteScalar();

                InsertRoleDetails((int)userId, user, conn);
            }
        }

        public void UpdateUser(AppUser user)
        {
            using (var conn = DbCon.GetConnection())
            {
                EnableForeignKeys(conn);

                var cmd = new SQLiteCommand("UPDATE Users SET Username = @u, Password = @p, Role = @r WHERE UserID = @id", conn);
                cmd.Parameters.AddWithValue("@u", user.Username);
                cmd.Parameters.AddWithValue("@p", user.Password);
                cmd.Parameters.AddWithValue("@r", user.Role);
                cmd.Parameters.AddWithValue("@id", user.UserID);
                cmd.ExecuteNonQuery();

                UpdateRoleDetails(user.UserID, user, conn);
            }
        }

        public void DeleteUser(int userId)
        {
            using (var conn = DbCon.GetConnection())
            {
                EnableForeignKeys(conn);

                // Important: First delete from role tables to avoid FK constraint errors
                DeleteRoleDetails(userId, conn);

                // Then delete from Users
                var cmd = new SQLiteCommand("DELETE FROM Users WHERE UserID = @id", conn);
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertRoleDetails(int userId, AppUser user, SQLiteConnection conn)
        {
            int defaultCourseId = 0;

            if (user.Role == "Student")
            {
                var courseCmd = new SQLiteCommand("SELECT CourseID FROM Courses LIMIT 1", conn);
                var result = courseCmd.ExecuteScalar();
                if (result != null)
                {
                    defaultCourseId = Convert.ToInt32(result);
                }
                else
                {
                    throw new SQLiteException("No courses found in database. Please add at least one course.");
                }
            }

            string sql = user.Role switch
            {
                "Admin" => "INSERT INTO Admins (AdminName, UserID) VALUES (@name, @uid)",
                "Lecturer" => "INSERT INTO Lecturers (LecturerName, PhoneNumber, Address, UserID) VALUES (@name, '', '', @uid)",
                "Staff" => "INSERT INTO Staffs (StaffName, UserID) VALUES (@name, @uid)",
                "Student" => "INSERT INTO Students (StudentID, StudentName, Address, DOB, Gender, CourseID, UserID) VALUES (@uid, @name, '', '', '', @cid, @uid)",
                _ => ""
            };

            if (!string.IsNullOrEmpty(sql))
            {
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@uid", userId);
                if (user.Role == "Student")
                {
                    cmd.Parameters.AddWithValue("@cid", defaultCourseId);
                }
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateRoleDetails(int userId, AppUser user, SQLiteConnection conn)
        {
            string sql = user.Role switch
            {
                "Admin" => "UPDATE Admins SET AdminName = @name WHERE UserID = @uid",
                "Lecturer" => "UPDATE Lecturers SET LecturerName = @name WHERE UserID = @uid",
                "Staff" => "UPDATE Staffs SET StaffName = @name WHERE UserID = @uid",
                "Student" => "UPDATE Students SET StudentName = @name WHERE UserID = @uid",
                _ => ""
            };

            if (!string.IsNullOrEmpty(sql))
            {
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.ExecuteNonQuery();
            }
        }

        private void DeleteRoleDetails(int userId, SQLiteConnection conn)
        {
            // Delete role-specific records first to avoid foreign key constraint error
            var roles = new string[] { "Admins", "Lecturers", "Staffs", "Students" };

            foreach (var roleTable in roles)
            {
                var cmd = new SQLiteCommand($"DELETE FROM {roleTable} WHERE UserID = @uid", conn);
                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.ExecuteNonQuery();
            }
        }

        private string GetNameFromRole(int userId, string role, SQLiteConnection conn)
        {
            string sql = role switch
            {
                "Admin" => "SELECT AdminName FROM Admins WHERE UserID = @id",
                "Lecturer" => "SELECT LecturerName FROM Lecturers WHERE UserID = @id",
                "Staff" => "SELECT StaffName FROM Staffs WHERE UserID = @id",
                "Student" => "SELECT StudentName FROM Students WHERE UserID = @id",
                _ => ""
            };

            if (!string.IsNullOrEmpty(sql))
            {
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                var result = cmd.ExecuteScalar();
                return result?.ToString() ?? "";
            }

            return "";
        }

        private void EnableForeignKeys(SQLiteConnection conn)
        {
            // This ensures foreign keys are enforced on this connection
            using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    public class StaffController
    {
        private static Random rnd = new Random();

        // Get all staff records
        public List<Staff> GetAllStaff()
        {
            var staffList = new List<Staff>();

            using (var conn = DbCon.GetConnection())
            {

                string query = "SELECT StaffID, StaffName, Password, PhoneNumber FROM Staffs";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staffList.Add(new Staff
                        {
                            StaffID = reader.GetInt32(0),
                            StaffName = reader.GetString(1),
                            Password = reader.GetString(2),
                            PhoneNumber = reader.GetString(3)
                        });
                    }
                }
            }

            return staffList;
        }

        // Add new staff with unique StaffID
        public void AddStaff(Staff staff)
        {
            if (staff == null)
                throw new ArgumentNullException(nameof(staff));

            using (var conn = DbCon.GetConnection())
            {
                conn.Open();

                int randomId;
                do
                {
                    randomId = rnd.Next(100, 99999);
                } while (StaffIdExists(randomId, conn));

                staff.StaffID = randomId;

                string insertSql = "INSERT INTO Staffs (StaffID, StaffName, Password, PhoneNumber) VALUES (@StaffID, @StaffName, @Password, @PhoneNumber)";
                using (var cmd = new SQLiteCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staff.StaffID);
                    cmd.Parameters.AddWithValue("@StaffName", staff.StaffName);
                    cmd.Parameters.AddWithValue("@Password", staff.Password);
                    cmd.Parameters.AddWithValue("@PhoneNumber", staff.PhoneNumber);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows != 1)
                    {
                        throw new Exception("Failed to add staff record.");
                    }
                }
            }
        }

        // Update existing staff
        public void UpdateStaff(Staff staff)
        {
            if (staff == null)
                throw new ArgumentNullException(nameof(staff));

            using (var conn = DbCon.GetConnection())
            {
                conn.Open();

                string updateSql = @"
                    UPDATE Staffs
                    SET StaffName = @StaffName,
                    Password = @Password,
                    PhoneNumber = @PhoneNumber
                    WHERE StaffID = @StaffID";

                using (var cmd = new SQLiteCommand(updateSql, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffName", staff.StaffName);
                    cmd.Parameters.AddWithValue("@Password", staff.Password);
                    cmd.Parameters.AddWithValue("@PhoneNumber", staff.PhoneNumber);
                    cmd.Parameters.AddWithValue("@StaffID", staff.StaffID);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        throw new Exception($"Update failed: StaffID {staff.StaffID} not found.");
                    }
                }
            }
        }

        // Delete staff by ID
        public void DeleteStaff(int staffId)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();

                string deleteSql = "DELETE FROM Staffs WHERE StaffID = @StaffID";
                using (var cmd = new SQLiteCommand(deleteSql, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffId);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        throw new Exception($"Delete failed: StaffID {staffId} not found.");
                    }
                }
            }
        }

        // Helper: Check if StaffID exists in DB
        private bool StaffIdExists(int staffId, SQLiteConnection openConnection)
        {
            string checkSql = "SELECT COUNT(1) FROM Staffs WHERE StaffID = @StaffID";
            using (var cmd = new SQLiteCommand(checkSql, openConnection))
            {
                cmd.Parameters.AddWithValue("@StaffID", staffId);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}

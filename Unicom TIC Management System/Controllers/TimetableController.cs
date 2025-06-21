using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    public class TimeTableController
    {
        private static readonly Random rnd = new Random();

        public List<Timetable> GetAllTimetables()
        {
            var timetables = new List<Timetable>();

            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    EnableForeignKeys(conn);

                    string query = @"
                        SELECT t.TimetableID, t.SubjectID, s.SubjectName, 
                               t.TimeSlot, t.RoomID, r.RoomName, r.RoomType
                        FROM Timetables t
                        LEFT JOIN Subjects s ON t.SubjectID = s.SubjectID
                        LEFT JOIN Rooms r ON t.RoomID = r.RoomID";

                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            timetables.Add(new Timetable
                            {
                                TimetableID = reader.GetInt32(0),
                                SubjectID = reader.GetInt32(1),
                                SubjectName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                TimeSlot = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                RoomID = reader.GetInt32(4),
                                RoomName = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                RoomType = reader.IsDBNull(6) ? "" : reader.GetString(6)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetAllTimetables: " + ex.Message);
            }

            return timetables;
        }

        public void AddTimetable(Timetable timetable)
        {
            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    EnableForeignKeys(conn);

                    if (!SubjectExists(timetable.SubjectID, conn))
                        throw new Exception("Invalid SubjectID: Not found in Subjects table.");

                    if (!RoomExists(timetable.RoomID, conn))
                        throw new Exception("Invalid RoomID: Not found in Rooms table.");

                    int randomId;
                    do
                    {
                        randomId = rnd.Next(301, 999);
                    } while (TimetableIdExists(randomId, conn));

                    timetable.TimetableID = randomId;

                    string insertQuery = @"INSERT INTO Timetables 
                        (TimetableID, SubjectID, TimeSlot, RoomID) 
                        VALUES (@TimetableID, @SubjectID, @TimeSlot, @RoomID)";

                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableID);
                        cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                        cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                        cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                            throw new Exception("Insert failed. No rows affected.");
                    }
                }
            }
            catch (SQLiteException ex) when (ex.Message.Contains("FOREIGN KEY constraint failed"))
            {
                throw new Exception("Foreign key constraint failed. Please ensure the SubjectID and RoomID exist.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in AddTimetable: " + ex.Message);
            }
        }

        public void UpdateTimetable(Timetable timetable)
        {
            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    EnableForeignKeys(conn);

                    if (!SubjectExists(timetable.SubjectID, conn))
                        throw new Exception("Invalid SubjectID: Not found in Subjects table.");

                    if (!RoomExists(timetable.RoomID, conn))
                        throw new Exception("Invalid RoomID: Not found in Rooms table.");

                    string updateQuery = @"UPDATE Timetables 
                        SET SubjectID = @SubjectID, 
                            TimeSlot = @TimeSlot, 
                            RoomID = @RoomID 
                        WHERE TimetableID = @TimetableID";

                    using (var cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                        cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                        cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                        cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableID);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                            throw new Exception("Update failed. No matching record found.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in UpdateTimetable: " + ex.Message);
            }
        }

        public void DeleteTimetable(int timetableId)
        {
            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    EnableForeignKeys(conn);

                    string deleteQuery = @"DELETE FROM Timetables WHERE TimetableID = @TimetableID";

                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimetableID", timetableId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                            throw new Exception("Delete failed. No matching timetable found.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DeleteTimetable: " + ex.Message);
            }
        }

        private bool TimetableIdExists(int timetableId, SQLiteConnection conn)
        {
            string query = "SELECT COUNT(*) FROM Timetables WHERE TimetableID = @TimetableID";

            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TimetableID", timetableId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private bool SubjectExists(int subjectId, SQLiteConnection conn)
        {
            string query = "SELECT COUNT(*) FROM Subjects WHERE SubjectID = @SubjectID";

            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private bool RoomExists(int roomId, SQLiteConnection conn)
        {
            string query = "SELECT COUNT(*) FROM Rooms WHERE RoomID = @RoomID";

            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@RoomID", roomId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void EnableForeignKeys(SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}

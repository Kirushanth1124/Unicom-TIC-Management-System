using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories; // Assuming DbCon is here

namespace SchoolManageSystem.Controllers
{
    public class TimeTableController
    {
        public List<Timetable> GetAllTimetables()
        {
            var timetables = new List<Timetable>();

            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    conn.Open();

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
                                TimetableId = reader.GetInt32(0),
                                SubjectId = reader.GetInt32(1),
                                SubjectName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                TimeSlot = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                RoomId = reader.GetInt32(4),
                                RoomName = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                RoomType = reader.IsDBNull(6) ? "" : reader.GetString(6)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAllTimetables: " + ex.Message);
            }

            return timetables;
        }

        public void AddTimetable(Timetable timetable)
        {
            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    conn.Open();

                    // Generate unique TimetableID (you can improve this logic)
                    Random rnd = new Random();
                    int randomId;
                    do
                    {
                        randomId = rnd.Next(301, 400);
                    } while (TimetableIdExists(randomId, conn));

                    timetable.TimetableId = randomId;

                    string insertQuery = @"INSERT INTO Timetables (TimetableID, SubjectID, TimeSlot, RoomID) 
                                           VALUES (@TimetableID, @SubjectID, @TimeSlot, @RoomID)";

                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableId);
                        cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectId);
                        cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                        cmd.Parameters.AddWithValue("@RoomID", timetable.RoomId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddTimetable: " + ex.Message);
            }
        }

        public void UpdateTimetable(Timetable timetable)
        {
            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    conn.Open();

                    string updateQuery = @"UPDATE Timetables 
                                           SET SubjectID = @SubjectID, TimeSlot = @TimeSlot, RoomID = @RoomID 
                                           WHERE TimetableID = @TimetableID";

                    using (var cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectId);
                        cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                        cmd.Parameters.AddWithValue("@RoomID", timetable.RoomId);
                        cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateTimetable: " + ex.Message);
            }
        }

        public void DeleteTimetable(int timetableId)
        {
            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    conn.Open();

                    string deleteQuery = @"DELETE FROM Timetables WHERE TimetableID = @TimetableID";

                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimetableID", timetableId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DeleteTimetable: " + ex.Message);
            }
        }

        private bool TimetableIdExists(int timetableId, SQLiteConnection conn)
        {
            string checkQuery = @"SELECT COUNT(*) FROM Timetables WHERE TimetableID = @TimetableID";
            using (var cmd = new SQLiteCommand(checkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@TimetableID", timetableId);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}

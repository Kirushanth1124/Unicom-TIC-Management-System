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

            return timetables;
        }

        public void AddTimetable(Timetable timetable)
        {
            using (var conn = DbCon.GetConnection())
            {
                EnableForeignKeys(conn);

                if (!SubjectExists(timetable.SubjectID, conn))
                    throw new Exception("Invalid SubjectID.");

                if (!RoomExists(timetable.RoomID, conn))
                    throw new Exception("Invalid RoomID.");

                int id;
                do
                {
                    id = rnd.Next(300, 999);
                } while (TimetableIdExists(id, conn));

                timetable.TimetableID = id;

                string insert = @"INSERT INTO Timetables (TimetableID, SubjectID, TimeSlot, RoomID) 
                                  VALUES (@TimetableID, @SubjectID, @TimeSlot, @RoomID)";

                using (var cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableID);
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTimetable(Timetable timetable)
        {
            using (var conn = DbCon.GetConnection())
            {
                EnableForeignKeys(conn);

                string update = @"UPDATE Timetables 
                                  SET SubjectID = @SubjectID, TimeSlot = @TimeSlot, RoomID = @RoomID 
                                  WHERE TimetableID = @TimetableID";

                using (var cmd = new SQLiteCommand(update, conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                    cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTimetable(int timetableId)
        {
            using (var conn = DbCon.GetConnection())
            {
                EnableForeignKeys(conn);
                string delete = "DELETE FROM Timetables WHERE TimetableID = @id";

                using (var cmd = new SQLiteCommand(delete, conn))
                {
                    cmd.Parameters.AddWithValue("@id", timetableId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Subject> GetAllSubjects()
        {
            var list = new List<Subject>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT SubjectID, SubjectName FROM Subjects", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            SubjectName = reader.GetString(1)
                        });
                    }
                }
            }
            return list;
        }

        public List<Room> GetAllRooms()
        {
            var list = new List<Room>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT RoomID, RoomName, RoomType FROM Rooms", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            RoomType = reader.GetString(2)
                        });
                    }
                }
            }
            return list;
        }

        private void EnableForeignKeys(SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private bool TimetableIdExists(int id, SQLiteConnection conn)
        {
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Timetables WHERE TimetableID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private bool SubjectExists(int id, SQLiteConnection conn)
        {
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Subjects WHERE SubjectID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private bool RoomExists(int id, SQLiteConnection conn)
        {
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Rooms WHERE RoomID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    internal class TimeTableController
    {
        public List<Timetable> GetAllTimetables()
        {
            var timetables = new List<Timetable>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT t.TimetableID, t.SubjectID, s.SubjectName, 
                           t.TimeSlot, t.RoomID, r.RoomName, r.RoomType
                    FROM Timetables t
                    LEFT JOIN Subjects s ON t.SubjectID = s.SubjectID
                    LEFT JOIN Rooms r ON t.RoomID = r.RoomID", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    timetables.Add(new Timetable
                    {
                        TimetableId = reader.GetInt32(0),
                        SubjectId = reader.GetInt32(1),
                        SubjectName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        TimeSlot = reader.GetString(3),
                        RoomId = reader.GetInt32(4),
                        RoomName = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        RoomType = reader.IsDBNull(6) ? "" : reader.GetString(6)
                    });
                }
            }

            return timetables;
        }

        public void AddTimetable(Timetable timetable)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) VALUES (@SubjectID, @TimeSlot, @RoomID)", conn);
                cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectId);
                cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                cmd.Parameters.AddWithValue("@RoomID", timetable.RoomId);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTimetable(Timetable timetable)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Timetables SET SubjectID = @SubjectID, TimeSlot = @TimeSlot, RoomID = @RoomID WHERE TimetableID = @TimetableID", conn);
                cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectId);
                cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                cmd.Parameters.AddWithValue("@RoomID", timetable.RoomId);
                cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTimetable(int timetableId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Timetables WHERE TimetableID = @TimetableID", conn);
                cmd.Parameters.AddWithValue("@TimetableID", timetableId);
                cmd.ExecuteNonQuery();
            }
        }

        public Timetable GetTimetableById(int timetableId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT t.TimetableID, t.SubjectID, s.SubjectName,
                           t.TimeSlot, t.RoomID, r.RoomName, r.RoomType
                    FROM Timetables t
                    LEFT JOIN Subjects s ON t.SubjectID = s.SubjectID
                    LEFT JOIN Rooms r ON t.RoomID = r.RoomID
                    WHERE t.TimetableID = @TimetableID", conn);

                cmd.Parameters.AddWithValue("@TimetableID", timetableId);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Timetable
                    {
                        TimetableId = reader.GetInt32(0),
                        SubjectId = reader.GetInt32(1),
                        SubjectName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        TimeSlot = reader.GetString(3),
                        RoomId = reader.GetInt32(4),
                        RoomName = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        RoomType = reader.IsDBNull(6) ? "" : reader.GetString(6)
                    };
                }
            }

            return null;
        }

        public List<Timetable> GetTimetablesBySubjectId(int subjectId)
        {
            var timetables = new List<Timetable>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT t.TimetableID, t.SubjectID, s.SubjectName,
                           t.TimeSlot, t.RoomID, r.RoomName, r.RoomType
                    FROM Timetables t
                    LEFT JOIN Subjects s ON t.SubjectID = s.SubjectID
                    LEFT JOIN Rooms r ON t.RoomID = r.RoomID
                    WHERE t.SubjectID = @SubjectID", conn);

                cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    timetables.Add(new Timetable
                    {
                        TimetableId = reader.GetInt32(0),
                        SubjectId = reader.GetInt32(1),
                        SubjectName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        TimeSlot = reader.GetString(3),
                        RoomId = reader.GetInt32(4),
                        RoomName = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        RoomType = reader.IsDBNull(6) ? "" : reader.GetString(6)
                    });
                }
            }

            return timetables;
        }
    }
}

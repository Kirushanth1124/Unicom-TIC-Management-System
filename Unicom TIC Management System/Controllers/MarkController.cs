using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    internal class MarkController
    {
        public List<Mark> GetAllMarks()
        {
            var marks = new List<Mark>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT m.MarkID, m.StudentID, s.Name AS StudentName,
                           m.ExamID, e.ExamName, m.Score
                    FROM Marks m
                    LEFT JOIN Students s ON m.StudentID = s.StudentID
                    LEFT JOIN Exams e ON m.ExamID = e.ExamID", conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    marks.Add(new Mark
                    {
                        MarkId = reader.GetInt32(0),
                        StudentId = reader.GetInt32(1),
                        StudentName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        ExamId = reader.GetInt32(3),
                        ExamName = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        Score = reader.GetInt32(5)
                    });
                }
            }

            return marks;
        }

        public void AddMark(Mark mark)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@StudentID, @ExamID, @Score)", conn);
                cmd.Parameters.AddWithValue("@StudentID", mark.StudentId);
                cmd.Parameters.AddWithValue("@ExamID", mark.ExamId);
                cmd.Parameters.AddWithValue("@Score", mark.Score);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMark(Mark mark)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE MarkID = @MarkID", conn);
                cmd.Parameters.AddWithValue("@StudentID", mark.StudentId);
                cmd.Parameters.AddWithValue("@ExamID", mark.ExamId);
                cmd.Parameters.AddWithValue("@Score", mark.Score);
                cmd.Parameters.AddWithValue("@MarkID", mark.MarkId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMark(int markId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE MarkID = @MarkID", conn);
                cmd.Parameters.AddWithValue("@MarkID", markId);
                cmd.ExecuteNonQuery();
            }
        }

        public Mark GetMarkById(int markId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Marks WHERE MarkID = @MarkID", conn);
                cmd.Parameters.AddWithValue("@MarkID", markId);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Mark
                    {
                        MarkId = reader.GetInt32(0),
                        StudentId = reader.GetInt32(1),
                        ExamId = reader.GetInt32(2),
                        Score = reader.GetInt32(3)
                    };
                }
            }

            return null;
        }

        public List<Mark> GetMarksByStudentId(int studentId)
        {
            var marks = new List<Mark>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT m.MarkID, m.StudentID, s.Name AS StudentName,
                           m.ExamID, e.ExamName, m.Score
                    FROM Marks m
                    LEFT JOIN Students s ON m.StudentID = s.StudentID
                    LEFT JOIN Exams e ON m.ExamID = e.ExamID
                    WHERE m.StudentID = @StudentID", conn);

                cmd.Parameters.AddWithValue("@StudentID", studentId);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    marks.Add(new Mark
                    {
                        MarkId = reader.GetInt32(0),
                        StudentId = reader.GetInt32(1),
                        StudentName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        ExamId = reader.GetInt32(3),
                        ExamName = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        Score = reader.GetInt32(5)
                    });
                }
            }

            return marks;
        }
    }
}

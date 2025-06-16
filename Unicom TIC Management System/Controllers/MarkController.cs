using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    internal class MarkController
    {
        // எல்லா மதிப்பெண்களையும் எடுத்துக்கொள்கிறது
        public List<Mark> GetAllMarks()
        {
            var marks = new List<Mark>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT m.MarkID, m.StudentID,s.StudentName AS StudentName,
                           m.ExamID, e.ExamName, m.Score
                    FROM Marks m
                    LEFT JOIN Students s ON m.StudentID = s.StudentID
                    LEFT JOIN Exams e ON m.ExamID = e.ExamID", conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    marks.Add(new Mark
                    {
                        MarkID = reader.GetInt32(0),             
                        StudentID = reader.GetInt32(1),         
                        StudentName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        ExamID = reader.GetInt32(3),             
                        ExamName = reader.IsDBNull(4) ? "" : reader.GetString(4),    
                        Score = reader.GetInt32(5)                
                    });
                }
            }

            return marks;
        }

        // புதிய மதிப்பெண்களை சேர்
        public void AddMark(Mark mark)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();

                Random rnd = new Random();
                int randomId;

                // MarkID க்கான தனித்துவமான ID உருவாக்கு
                do
                {
                    randomId = rnd.Next(51, 100);
                } while (MarkIdExists(randomId, conn));

                mark.MarkID = randomId;

                var cmd = new SQLiteCommand("INSERT INTO Marks (MarkID, StudentID, ExamID, Score) VALUES (@MarkID, @StudentID, @ExamID, @Score)", conn);
                cmd.Parameters.AddWithValue("@MarkID", mark.MarkID);
                cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
                cmd.Parameters.AddWithValue("@Score", mark.Score);
                cmd.ExecuteNonQuery();
            }
        }

        // மதிப்பெண் புதுப்பி
        public void UpdateMark(Mark mark)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE MarkID = @MarkID", conn);
                cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
                cmd.Parameters.AddWithValue("@Score", mark.Score);
                cmd.Parameters.AddWithValue("@MarkID", mark.MarkID);
                cmd.ExecuteNonQuery();
            }
        }

        // மதிப்பெண் அழி
        public void DeleteMark(int markId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE MarkID = @MarkID", conn);
                cmd.Parameters.AddWithValue("@MarkID", markId);
                cmd.ExecuteNonQuery();
            }
        }

        // MarkID மூலம் மதிப்பெண் விவரங்கள் எடு
        public Mark GetMarkById(int markId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT MarkID, StudentID, ExamID, Score FROM Marks WHERE MarkID = @MarkID", conn);
                cmd.Parameters.AddWithValue("@MarkID", markId);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Mark
                    {
                        MarkID = reader.GetInt32(0),
                        StudentID = reader.GetInt32(1),
                        ExamID = reader.GetInt32(2),
                        Score = reader.GetInt32(3)
                    };
                }
            }

            return null;
        }

        // ஒரு மாணவனின் அனைத்து மதிப்பெண்களையும் எடு
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
                        MarkID = reader.GetInt32(0),
                        StudentID = reader.GetInt32(1),
                        StudentName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        ExamID = reader.GetInt32(3),
                        ExamName = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        Score = reader.GetInt32(5)
                    });
                }
            }

            return marks;
        }

        // MarkID database-ல் இருக்கிறதா என சரிபார்
        private bool MarkIdExists(int markId, SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Marks WHERE MarkID = @MarkID", conn))
            {
                cmd.Parameters.AddWithValue("@MarkID", markId);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}

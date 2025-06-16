using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    internal class ExamController
    {
        public List<Exam> GetAllExams()
        {
            var exams = new List<Exam>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT ExamID, ExamName, SubjectID, SubjectName 
                    FROM Exams  
                    LEFT JOIN Subjects  ON SubjectID = SubjectID", conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    exams.Add(new Exam
                    {
                        ExamID = reader.GetInt32(0),
                        ExamName = reader.GetString(1),
                        SubjectID = reader.GetInt32(2),
                        SubjectName = reader.IsDBNull(3) ? "" : reader.GetString(3)
                    });
                }
            }

            return exams;
        }

        public void AddExam(Exam exam)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();

                Random rnd = new Random();
                int randomId;

                // Random ExamID create பண்ணி அது DB-ல் இருக்கிறதா என்று Check பண்ணும்
                do
                {
                    randomId = rnd.Next(21, 50);
                } while (ExamIdExists(randomId, conn));

                exam.ExamID = randomId;

                var cmd = new SQLiteCommand("INSERT INTO Exams (ExamID, ExamName, SubjectID) VALUES (@ExamID, @ExamName, @SubjectID)", conn);
                cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);
                cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateExam(Exam exam)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Exams SET ExamName = @ExamName, SubjectID = @SubjectID WHERE ExamID = @ExamID", conn);
                cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteExam(int examId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Exams WHERE ExamID = @ExamID", conn);
                cmd.Parameters.AddWithValue("@ExamID", examId);
                cmd.ExecuteNonQuery();
            }
        }

        public Exam GetExamById(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT ExamID, ExamName, SubjectID FROM Exams WHERE ExamID = @ExamID", conn);
                cmd.Parameters.AddWithValue("@ExamID", id);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Exam
                    {
                        ExamID = reader.GetInt32(0),
                        ExamName = reader.GetString(1),
                        SubjectID = reader.GetInt32(2)
                    };
                }
            }

            return null;
        }

        private bool ExamIdExists(int examId, SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Exams WHERE ExamID = @ExamID", conn))
            {
                cmd.Parameters.AddWithValue("@ExamID", examId);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}

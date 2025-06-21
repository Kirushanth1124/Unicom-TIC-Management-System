using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    internal class ExamController
    {
        // Get all exams with subject names
        public List<Exam> GetAllExams()
        {
            var exams = new List<Exam>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT Exams.ExamID, Exams.ExamName, Exams.ExamMarks, Exams.SubjectID, Subjects.SubjectName 
                    FROM Exams  
                    LEFT JOIN Subjects ON Exams.SubjectID = Subjects.SubjectID", conn);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    exams.Add(new Exam
                    {
                        ExamID = reader.GetInt32(0),
                        ExamName = reader.GetString(1),
                        ExamMarks = reader.GetInt32(2),
                        SubjectID = reader.GetInt32(3),
                        SubjectName = reader.IsDBNull(4) ? "" : reader.GetString(4)
                    });
                }
            }

            return exams;
        }

        // Add a new exam
        public void AddExam(Exam exam)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Exams (ExamName, ExamMarks, SubjectID) VALUES (@ExamName, @ExamMarks, @SubjectID)", conn);
                cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                cmd.Parameters.AddWithValue("@ExamMarks", exam.ExamMarks);
                cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                cmd.ExecuteNonQuery();
            }
        }

        // Update exam
        public void UpdateExam(Exam exam)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Exams SET ExamName = @ExamName, ExamMarks = @ExamMarks, SubjectID = @SubjectID WHERE ExamID = @ExamID", conn);
                cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                cmd.Parameters.AddWithValue("@ExamMarks", exam.ExamMarks);
                cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);
                cmd.ExecuteNonQuery();
            }
        }

        // Delete exam
        public void DeleteExam(int examId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Exams WHERE ExamID = @ExamID", conn);
                cmd.Parameters.AddWithValue("@ExamID", examId);
                cmd.ExecuteNonQuery();
            }
        }

        // Get exam by ID
        public Exam GetExamById(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT ExamID, ExamName, ExamMarks, SubjectID FROM Exams WHERE ExamID = @ExamID", conn);
                cmd.Parameters.AddWithValue("@ExamID", id);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Exam
                    {
                        ExamID = reader.GetInt32(0),
                        ExamName = reader.GetString(1),
                        ExamMarks = reader.GetInt32(2),
                        SubjectID = reader.GetInt32(3)
                    };
                }
            }

            return null;
        }
    }
}

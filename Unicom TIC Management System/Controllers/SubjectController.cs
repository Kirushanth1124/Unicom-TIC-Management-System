using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    public class SubjectController
    {
        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT sub.SubjectID, sub.SubjectName, sub.CourseID, c.CourseName
                    FROM Subjects sub
                    LEFT JOIN Courses c ON sub.CourseID = c.CourseID", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            CourseID = reader.GetInt32(2),
                            CourseName = reader.IsDBNull(3) ? "" : reader.GetString(3)
                        });
                    }
                }
            }
            return subjects;
        }

        public void AddSubject(Subject subject)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"INSERT INTO Subjects (SubjectName, CourseID)
                                      VALUES (@SubjectName, @CourseID)", conn);

                cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);

                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                    throw new Exception("Insert failed. No rows affected.");
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"UPDATE Subjects 
                                              SET SubjectName = @SubjectName, CourseID = @CourseID 
                                              WHERE SubjectID = @SubjectID", conn);
                cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand(@"DELETE FROM Subjects WHERE SubjectID = @SubjectID", conn);
                cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        private bool SubjectIdExists(int subjectId, SQLiteConnection conn)
        {
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Subjects WHERE SubjectID = @SubjectID", conn);
            cmd.Parameters.AddWithValue("@SubjectID", subjectId);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}

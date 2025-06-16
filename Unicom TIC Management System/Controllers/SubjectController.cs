using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    internal class SubjectController
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

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subjects.Add(new Subject
                    {
                        SubjectId = reader.GetInt32(0),
                        SubjectName = reader.GetString(1),
                        CourseId = reader.GetInt32(2),
                        CourseName = reader.IsDBNull(3) ? "" : reader.GetString(3)
                    });
                }
            }

            return subjects;
        }

        public void AddSubject(Subject subject)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();

                Random rnd = new Random();
                int randomId;

                // Unique ID generate பண்ணு
                do
                {
                    randomId = rnd.Next(201, 300);
                } while (SubjectIdExists(randomId, conn));

                subject.SubjectId = randomId;

                var cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectID, SubjectName, CourseID) VALUES (@SubjectID, @SubjectName, @CourseID)", conn);
                cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectId);
                cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                cmd.Parameters.AddWithValue("@CourseID", subject.CourseId);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Subjects SET SubjectName = @SubjectName, CourseID = @CourseID WHERE SubjectID = @SubjectID", conn);
                cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                cmd.Parameters.AddWithValue("@CourseID", subject.CourseId);
                cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectID = @SubjectID", conn);
                cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        public Subject GetSubjectById(int subjectId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subjects WHERE SubjectID = @SubjectID", conn);
                cmd.Parameters.AddWithValue("@SubjectID", subjectId);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Subject
                    {
                        SubjectId = reader.GetInt32(0),
                        SubjectName = reader.GetString(1),
                        CourseId = reader.GetInt32(2)
                    };
                }
            }

            return null;
        }

        public List<Subject> GetSubjectsByCourseId(int courseId)
        {
            var subjects = new List<Subject>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subjects WHERE CourseID = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseID", courseId);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subjects.Add(new Subject
                    {
                        SubjectId = reader.GetInt32(0),
                        SubjectName = reader.GetString(1),
                        CourseId = reader.GetInt32(2)
                    });
                }
            }

            return subjects;
        }

        private bool SubjectIdExists(int subjectId, SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Subjects WHERE SubjectID = @SubjectID", conn))
            {
                cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}

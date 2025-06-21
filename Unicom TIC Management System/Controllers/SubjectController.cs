using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    public class SubjectController
    {
        // All subjects எடுத்துக்கொள்ளும் method
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

        // Add பண்ணும் method (SubjectID Auto-generate ஆகும்)
        public void AddSubject(Subject subject)
        {
            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    conn.Open();

                    Random rnd = new Random();
                    int randomId;

                    do
                    {
                        randomId = rnd.Next(201, 300);
                    } while (SubjectIdExists(randomId, conn));

                    subject.SubjectID = randomId;

                    var cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectID, SubjectName, CourseID) VALUES (@SubjectID, @SubjectName, @CourseID)", conn);
                    cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);
                    cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log or throw further
                throw new Exception("Failed to add subject. Details: " + ex.Message, ex);
            }
        }


        // Update பண்ணும் method
        public void UpdateSubject(Subject subject)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Subjects SET SubjectName = @SubjectName, CourseID = @CourseID WHERE SubjectID = @SubjectID", conn);
                cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);
                cmd.ExecuteNonQuery();
            }
        }

        // Delete பண்ணும் method
        public void DeleteSubject(int subjectId)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectID = @SubjectID", conn);
                cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        // Subject ID கொண்டு ஒருவன் data பெற method
        public Subject GetSubjectById(int subjectId)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT SubjectID, SubjectName, CourseID FROM Subjects WHERE SubjectID = @SubjectID", conn);
                cmd.Parameters.AddWithValue("@SubjectID", subjectId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            CourseID = reader.GetInt32(2)
                        };
                    }
                }
            }

            return null;
        }

        // Course ID கொண்டு Subjects list எடுக்கும் method
        public List<Subject> GetSubjectsByCourseId(int courseId)
        {
            var subjects = new List<Subject>();

            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT SubjectID, SubjectName, CourseID FROM Subjects WHERE CourseID = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseID", courseId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            CourseID = reader.GetInt32(2)
                        });
                    }
                }
            }

            return subjects;
        }

        // SubjectID உள்ளதா இல்லையா Check பண்ணும் private method
        private bool SubjectIdExists(int subjectId, SQLiteConnection conn)
        {
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Subjects WHERE SubjectID = @SubjectID", conn);
            cmd.Parameters.AddWithValue("@SubjectID", subjectId);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}

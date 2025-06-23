using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    internal class CourseController
    {
        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            CourseID = reader.GetInt32(0),
                            CourseName = reader.GetString(1)
                        });
                    }
                }
            }
            return courses;
        }


        public void AddCourse(Course course)
        {
            using (var conn = DbCon.GetConnection())
            {
                // CourseID கொடுக்காமல், CourseName மட்டும் insert பண்ணு
                using var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@CourseName)", conn);
                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.ExecuteNonQuery();

                // விருப்பமா: கடைசி insert ஆன row-இன் ID-யை பெறலாம்
                course.CourseID = (int)conn.LastInsertRowId;
            }
        }


        public void UpdateCourse(Course course)
        {
            using (var conn = DbCon.GetConnection())
            {
                using var cmd = new SQLiteCommand("UPDATE Courses SET CourseName = @CourseName WHERE CourseID = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.Parameters.AddWithValue("@CourseID", course.CourseID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCourse(int courseId)
        {
            using (var conn = DbCon.GetConnection())
            {
                using var cmd = new SQLiteCommand("DELETE FROM Courses WHERE CourseID = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseID", courseId);
                cmd.ExecuteNonQuery();
            }
        }

        public Course GetCourseById(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                using var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses WHERE CourseID = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseID", id);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Course
                    {
                        CourseID = reader.GetInt32(0),
                        CourseName = reader.GetString(1)
                    };
                }
            }

            return null;
        }

        private bool CourseIdExists(int courseId, SQLiteConnection conn)
        {
            using var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Courses WHERE CourseID = @CourseID", conn);
            cmd.Parameters.AddWithValue("@CourseID", courseId);

            var result = cmd.ExecuteScalar();
            int count = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            return count > 0;
        }
    }
}

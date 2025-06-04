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
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    courses.Add(new Course
                    {
                        CourseId = reader.GetInt32(0),
                        CourseName = reader.GetString(1)
                    });
                }
            }

            return courses;
        }

        public void AddCourse(Course course)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@CourseName)", conn);
                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCourse(Course course)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Courses SET CourseName = @CourseName WHERE CourseID = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
                cmd.Parameters.AddWithValue("@CourseID", course.CourseId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCourse(int courseId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Courses WHERE CourseID = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseID", courseId);
                cmd.ExecuteNonQuery();
            }
        }

        public Course GetCourseById(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses WHERE CourseID = @CourseID", conn);
                cmd.Parameters.AddWithValue("@CourseID", id);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Course
                    {
                        CourseId = reader.GetInt32(0),
                        CourseName = reader.GetString(1)
                    };
                }
            }

            return null;
        }
    }
}

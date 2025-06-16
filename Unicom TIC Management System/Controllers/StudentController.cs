using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    public class StudentController
    {
        private static Random rnd = new Random();

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            using (var conn = DbCon.GetConnection())
            {
                var query = @"
                    SELECT s.StudentID, s.StudentName, s.Address, s.CourseID, c.CourseName
                    FROM Students s
                    LEFT JOIN Courses c ON s.CourseID = c.CourseID";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            CourseId = reader.GetInt32(3),
                            CourseName = reader.IsDBNull(4) ? string.Empty : reader.GetString(4)
                        });
                    }
                }
            }

            return students;
        }

        // Check if StudentID exists in the database
        private bool StudentIdExists(int studentId)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // Add a new student with random StudentID
        public void AddStudent(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();

                // Generate unique random StudentId
                int randomId;
                do
                {
                    randomId = rnd.Next(101, 200);
                } while (StudentIdExists(randomId));

                student.StudentId = randomId;

                using (var cmd = new SQLiteCommand("INSERT INTO Students (StudentID, StudentName, Address, CourseID) VALUES (@StudentID, @StudentName, @Address, @CourseID)", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentId);
                    cmd.Parameters.AddWithValue("@StudentName", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Update an existing student
        public void UpdateStudent(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(@"
            UPDATE Students
            SET StudentName = @StudentName,
                Address = @Address,
                DOB = @DOB,
                CourseID = @CourseID
            WHERE StudentID = @StudentID", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentName", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@DOB", student.DOB);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseId);
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete a student by ID
        public void DeleteStudent(int studentId)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("DELETE FROM Students WHERE StudentID = @StudentID", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Get one student by ID
        public Student GetStudentById(int studentId)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT * FROM Students WHERE StudentID = @StudentID", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                StudentId = reader.GetInt32(reader.GetOrdinal("StudentID")),
                                Name = reader.GetString(reader.GetOrdinal("StudentName")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                DOB = reader.GetString(reader.GetOrdinal("DOB")),
                                CourseId = reader.GetInt32(reader.GetOrdinal("CourseID"))
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}

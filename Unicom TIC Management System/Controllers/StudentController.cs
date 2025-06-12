using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    public class StudentController
    {
        
        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            using (var conn = DbCon.GetConnection())
            {
                var query = @"
                    SELECT s.StudentID, s.Name, s.Address, s.CourseID, c.CourseName
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

        // Add a new student to the database
        public void AddStudent(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                var query = "INSERT INTO Students (Name, Address, CourseID) VALUES (@Name, @Address, @CourseID)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
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
                var query = "UPDATE Students SET Name = @Name, Address = @Address, CourseID = @CourseID WHERE StudentID = @StudentID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
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
                var query = "DELETE FROM Students WHERE StudentID = @StudentID";

                using (var cmd = new SQLiteCommand(query, conn))
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
                var query = "SELECT StudentID, Name, Address, CourseID FROM Students WHERE StudentID = @StudentID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                StudentId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                CourseId = reader.GetInt32(3)
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}

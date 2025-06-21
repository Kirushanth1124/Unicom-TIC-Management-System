using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    public class StudentController
    {
        // Check if StudentID exists
        private bool StudentIdExists(int studentId, SQLiteConnection conn)
        {
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Students WHERE StudentID = @id", conn);
            cmd.Parameters.AddWithValue("@id", studentId);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        // Check if UserID exists
        private bool UserIdExists(int userId, SQLiteConnection conn)
        {
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE UserID = @id", conn);
            cmd.Parameters.AddWithValue("@id", userId);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        // Generate Unique StudentID
        private int GenerateUniqueStudentId(SQLiteConnection conn)
        {
            Random rnd = new Random();
            int studentId;
            do
            {
                studentId = rnd.Next(1000, 9999);
            } while (StudentIdExists(studentId, conn));
            return studentId;
        }

        // Generate Unique UserID
        private int GenerateUniqueUserId(SQLiteConnection conn)
        {
            Random rnd = new Random();
            int userId;
            do
            {
                userId = rnd.Next(1000, 9999);
            } while (UserIdExists(userId, conn));
            return userId;
        }

        // Add student (with auto-generated StudentID and UserID)
        public void AddStudent(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();

                // Generate unique IDs
                int newStudentId = GenerateUniqueStudentId(conn);
                int newUserId = GenerateUniqueUserId(conn);

                // Insert into Users table first (assuming you want to insert into Users too)
                var userCmd = new SQLiteCommand("INSERT INTO Users (UserID, Username, Password, Role) VALUES (@UserID, @Username, @Password, @Role)", conn);
                userCmd.Parameters.AddWithValue("@UserID", newUserId);
                userCmd.Parameters.AddWithValue("@Username", student.Name);  // or any username logic
                userCmd.Parameters.AddWithValue("@Password", "defaultPassword");  // set a default or hash password
                userCmd.Parameters.AddWithValue("@Role", "Student");
                userCmd.ExecuteNonQuery();

                // Now insert into Students table
                var studentCmd = new SQLiteCommand(@"INSERT INTO Students 
                (StudentID, StudentName, Address, DOB, Gender, CourseName, UserID) 
                VALUES (@StudentID, @Name, @Address, @DOB, @Gender, @CourseName, @UserID)", conn);

                studentCmd.Parameters.AddWithValue("@StudentID", newStudentId);
                studentCmd.Parameters.AddWithValue("@Name", student.Name);
                studentCmd.Parameters.AddWithValue("@Address", student.Address);
                studentCmd.Parameters.AddWithValue("@DOB", student.DOB);
                studentCmd.Parameters.AddWithValue("@Gender", student.Gender);
                studentCmd.Parameters.AddWithValue("@CourseName", student.CourseName);
                studentCmd.Parameters.AddWithValue("@UserID", newUserId);

                studentCmd.ExecuteNonQuery();

                // Update student object IDs as well
                student.StudentId = newStudentId;
                student.UserID = newUserId;
            }
        }

        // Other CRUD methods like UpdateStudent, DeleteStudent, GetAllStudents should be here...
        // Make sure UpdateStudent and DeleteStudent use StudentID properly.

        public List<Student> GetAllStudents()
        {
            var list = new List<Student>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT StudentID, StudentName, Address, DOB, Gender, CourseName, UserID FROM Students", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Student
                        {
                            StudentId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            DOB = reader.GetString(3),
                            Gender = reader.GetString(4),
                            CourseName = reader.GetString(5),
                            UserID = reader.GetInt32(6)
                        });
                    }
                }
            }
            return list;
        }

        public void UpdateStudent(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Students SET StudentName = @Name, Address = @Address, DOB = @DOB, Gender = @Gender, CourseName = @CourseName WHERE StudentID = @StudentID", conn);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@DOB", student.DOB);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@CourseName", student.CourseName);
                cmd.Parameters.AddWithValue("@StudentID", student.StudentId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Students WHERE StudentID = @StudentID", conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

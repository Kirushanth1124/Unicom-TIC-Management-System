using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    public class StudentController
    {
        private Random rnd = new Random();

        private bool StudentIdExists(int studentId, SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Students WHERE StudentID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", studentId);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private bool UserIdExists(int userId, SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE UserID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", userId);
                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private int GenerateUniqueStudentId(SQLiteConnection conn)
        {
            int studentId;
            do
            {
                studentId = rnd.Next(1000, 9999);
            } while (StudentIdExists(studentId, conn));
            return studentId;
        }

        private int GenerateUniqueUserId(SQLiteConnection conn)
        {
            int userId;
            do
            {
                userId = rnd.Next(1000, 9999);
            } while (UserIdExists(userId, conn));
            return userId;
        }

        public void AddStudent(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();
                int newStudentId = GenerateUniqueStudentId(conn);
                int newUserId = GenerateUniqueUserId(conn);

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (var userCmd = new SQLiteCommand("INSERT INTO Users (UserID, Username, Password, Role) VALUES (@UserID, @Username, @Password, @Role)", conn))
                        {
                            userCmd.Parameters.AddWithValue("@UserID", newUserId);
                            userCmd.Parameters.AddWithValue("@Username", student.Name);
                            userCmd.Parameters.AddWithValue("@Password", "defaultPassword");
                            userCmd.Parameters.AddWithValue("@Role", "Student");
                            userCmd.ExecuteNonQuery();
                        }

                        using (var studentCmd = new SQLiteCommand(@"INSERT INTO Students 
                            (StudentID, StudentName, Address, DOB, Gender, CourseName, UserID) 
                            VALUES (@StudentID, @Name, @Address, @DOB, @Gender, @CourseName, @UserID)", conn))
                        {
                            studentCmd.Parameters.AddWithValue("@StudentID", newStudentId);
                            studentCmd.Parameters.AddWithValue("@Name", student.Name);
                            studentCmd.Parameters.AddWithValue("@Address", student.Address);
                            studentCmd.Parameters.AddWithValue("@DOB", student.DOB);
                            studentCmd.Parameters.AddWithValue("@Gender", student.Gender);
                            studentCmd.Parameters.AddWithValue("@CourseName", student.CourseName);
                            studentCmd.Parameters.AddWithValue("@UserID", newUserId);
                            studentCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        student.StudentID = newStudentId;
                        student.UserID = newUserId;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error adding student: " + ex.Message);
                    }
                }
            }
        }

        public List<Student> GetAllStudents()
        {
            var list = new List<Student>();

            using (var conn = DbCon.GetConnection())
            {

                using (var cmd = new SQLiteCommand("SELECT StudentID, StudentName, Address, DOB, Gender, CourseName, UserID FROM Students", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Student
                        {
                            StudentID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            DOB = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            Gender = reader.IsDBNull(4) ? "" : reader.GetString(4),
                            CourseName = reader.IsDBNull(5) ? "" : reader.GetString(5),
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
                using (var cmd = new SQLiteCommand(@"UPDATE Students 
                    SET StudentName = @Name, Address = @Address, DOB = @DOB, Gender = @Gender, CourseName = @CourseName 
                    WHERE StudentID = @StudentID", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@DOB", student.DOB);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@CourseName", student.CourseName);
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (var conn = DbCon.GetConnection())
            {
                conn.Open();

                int userId = -1;

                using (var cmdUserId = new SQLiteCommand("SELECT UserID FROM Students WHERE StudentID = @StudentID", conn))
                {
                    cmdUserId.Parameters.AddWithValue("@StudentID", studentId);
                    var result = cmdUserId.ExecuteScalar();
                    if (result != null) userId = Convert.ToInt32(result);
                }

                using (var cmd = new SQLiteCommand("DELETE FROM Students WHERE StudentID = @StudentID", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.ExecuteNonQuery();
                }

                if (userId != -1)
                {
                    using (var cmdUser = new SQLiteCommand("DELETE FROM Users WHERE UserID = @UserID", conn))
                    {
                        cmdUser.Parameters.AddWithValue("@UserID", userId);
                        cmdUser.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}

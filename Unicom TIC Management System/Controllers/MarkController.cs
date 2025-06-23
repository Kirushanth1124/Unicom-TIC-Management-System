using SchoolManageSystem.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

public class MarkController
{
    private ExamController examController = new ExamController(); // ExamController instance

    // எல்லா மதிப்பெண்களையும் எடுத்துக்கொள்கிறது
    public List<Mark> GetAllMarks()
    {
        var marks = new List<Mark>();

        using (var conn = DbCon.GetConnection())
        {
            var cmd = new SQLiteCommand(@"
                SELECT m.MarkID, m.StudentID,s.StudentName AS StudentName,
                       m.ExamID, e.ExamName, m.Score
                FROM Marks m
                LEFT JOIN Students s ON m.StudentID = s.StudentID
                LEFT JOIN Exams e ON m.ExamID = e.ExamID", conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                marks.Add(new Mark
                {
                    MarkID = reader.GetInt32(0),
                    StudentID = reader.GetInt32(1),
                    StudentName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    ExamID = reader.GetInt32(3),
                    ExamName = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    Score = reader.GetInt32(5)
                });
            }
        }

        return marks;
    }

    // புதிய மதிப்பெண்களை சேர்
    public void AddMark(Mark mark)
    {
        using (var conn = DbCon.GetConnection())
        {
            var cmd = new SQLiteCommand("PRAGMA busy_timeout = 5000;", conn);  // Timeout 5 seconds
            cmd.ExecuteNonQuery();

            // Get ExamName using ExamID
            var exam = examController.GetExamById(mark.ExamID);
            string examName = exam?.ExamName ?? "Unknown"; // Default to "Unknown" if no ExamName found

            // Get StudentName using StudentID
            var student = GetStudentById(mark.StudentID);
            string studentName = student?.Name ?? "Unknown"; // Default to "Unknown" if no StudentName found

            var cmdInsert = new SQLiteCommand("INSERT INTO Marks (StudentID, ExamID, Score, SubjectID, ExamName, StudentName) VALUES (@StudentID, @ExamID, @Score, @SubjectID, @ExamName, @StudentName)", conn);

            cmdInsert.Parameters.AddWithValue("@StudentID", mark.StudentID);
            cmdInsert.Parameters.AddWithValue("@ExamID", mark.ExamID);
            cmdInsert.Parameters.AddWithValue("@Score", mark.Score);

            // Get SubjectID based on ExamID
            int subjectID = GetSubjectIDFromExam(mark.ExamID);

            // Check if SubjectID is valid
            if (subjectID == 0)
            {
                MessageBox.Show("Error: Invalid ExamID. Could not retrieve SubjectID.");
                return;
            }

            cmdInsert.Parameters.AddWithValue("@SubjectID", subjectID);  // Add SubjectID
            cmdInsert.Parameters.AddWithValue("@ExamName", examName);  // Add ExamName to the insert statement
            cmdInsert.Parameters.AddWithValue("@StudentName", studentName);  // Add StudentName to the insert statement

            try
            {
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Mark added successfully.");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error adding mark: " + ex.Message);
            }
        }
    }
    private Student GetStudentById(int studentID)
    {
        using (var conn = DbCon.GetConnection())
        {
            var cmd = new SQLiteCommand("SELECT StudentID, StudentName FROM Students WHERE StudentID = @StudentID", conn);
            cmd.Parameters.AddWithValue("@StudentID", studentID);

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Student
                {
                    StudentID = reader.GetInt32(0),
                    Name = reader.IsDBNull(1) ? "" : reader.GetString(1)
                };
            }
        }

        return null;
    }
    private string GetStudentNameFromStudent(int studentID)
    {
        string studentName = string.Empty;

        using (var conn = DbCon.GetConnection())
        {
            var cmd = new SQLiteCommand("SELECT StudentName FROM Students WHERE StudentID = @StudentID", conn);
            cmd.Parameters.AddWithValue("@StudentID", studentID);

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                studentName = reader.GetString(0);  // StudentName களை பெறுதல்
            }
        }

        return studentName;
    }


    private string GetExamNameFromExam(int examID)
    {
        string examName = string.Empty;

        using (var conn = DbCon.GetConnection())
        {
            var cmd = new SQLiteCommand("SELECT ExamName FROM Exams WHERE ExamID = @ExamID", conn);
            cmd.Parameters.AddWithValue("@ExamID", examID);

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                examName = reader.GetString(0);  // ExamName களை பெறுதல்
            }
        }

        return examName;
    }


    // ExamID மூலம் SubjectID பெறும் மெத்தோடு
    private int GetSubjectIDFromExam(int examID)
    {
        // ExamID கொண்டு அந்த தேர்வின் SubjectID ஐ பெறுங்கள்
        var exam = examController.GetExamById(examID);  // ExamController மூலம் exam details பெறுதல்

        if (exam != null)
        {
            return exam.SubjectID;  // Return the corresponding SubjectID
        }
        return 0;  // Default value if no matching exam found
    }
    // மதிப்பெண் புதுப்பி
    public void UpdateMark(Mark mark)
    {
        using (var conn = DbCon.GetConnection())
        {
            var cmd = new SQLiteCommand("UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE MarkID = @MarkID", conn);
            cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
            cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
            cmd.Parameters.AddWithValue("@Score", mark.Score);
            cmd.Parameters.AddWithValue("@MarkID", mark.MarkID);
            cmd.ExecuteNonQuery();
        }
    }

    // மதிப்பெண் அழி
    public void DeleteMark(int markId)
    {
        using (var conn = DbCon.GetConnection())
        {
            var cmd = new SQLiteCommand("DELETE FROM Marks WHERE MarkID = @MarkID", conn);
            cmd.Parameters.AddWithValue("@MarkID", markId);
            cmd.ExecuteNonQuery();
        }
    }

    // MarkID மூலம் மதிப்பெண் விவரங்கள் எடு
    public Mark GetMarkById(int markId)
    {
        using (var conn = DbCon.GetConnection())
        {
            var cmd = new SQLiteCommand("SELECT MarkID, StudentID, ExamID, Score FROM Marks WHERE MarkID = @MarkID", conn);
            cmd.Parameters.AddWithValue("@MarkID", markId);

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Mark
                {
                    MarkID = reader.GetInt32(0),
                    StudentID = reader.GetInt32(1),
                    ExamID = reader.GetInt32(2),
                    Score = reader.GetInt32(3)
                };
            }
        }

        return null;
    }

    // ஒரு மாணவனின் அனைத்து மதிப்பெண்களையும் எடு
    public List<Mark> GetMarksByStudentId(int studentId)
    {
        var marks = new List<Mark>();

        using (var conn = DbCon.GetConnection())
        {
            var cmd = new SQLiteCommand(@"
                SELECT m.MarkID, m.StudentID, s.Name AS StudentName,
                       m.ExamID, e.ExamName, m.Score
                FROM Marks m
                LEFT JOIN Students s ON m.StudentID = s.StudentID
                LEFT JOIN Exams e ON m.ExamID = e.ExamID
                WHERE m.StudentID = @StudentID", conn);

            cmd.Parameters.AddWithValue("@StudentID", studentId);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                marks.Add(new Mark
                {
                    MarkID = reader.GetInt32(0),
                    StudentID = reader.GetInt32(1),
                    StudentName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    ExamID = reader.GetInt32(3),
                    ExamName = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    Score = reader.GetInt32(5)
                });
            }
        }

        return marks;
    }

    // MarkID database-ல் இருக்கிறதா என சரிபார்
    private bool MarkIdExists(int markId, SQLiteConnection conn)
    {
        using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Marks WHERE MarkID = @MarkID", conn))
        {
            cmd.Parameters.AddWithValue("@MarkID", markId);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}

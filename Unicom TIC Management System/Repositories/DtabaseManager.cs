using System.Data.SQLite;

namespace Unicom_TIC_Management_System.Repositories
{
    public class DatabaseManager
    {
        public static void CreateTables()
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentName TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        DOB TEXT NOT NULL,
                        CourseID INTEGER NOT NULL,
                        FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
                    );

                    CREATE TABLE IF NOT EXISTS Lecturer (
                        LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                        LecturerName TEXT NOT NULL,
                        PhoneNumber TEXT NOT NULL,
                        Address TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Exam (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        ExamMarks TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Admin (
                        AdminID INTEGER PRIMARY KEY AUTOINCREMENT,
                        AdminName TEXT NOT NULL,
                        Password TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Course (
                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Staff (
                        StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StaffName TEXT NOT NULL,
                        StaffPassword TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Subject (
                        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        CourseID INTEGER,
                        FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
                    );

                    CREATE TABLE IF NOT EXISTS TimeTable (
                        TimeTableID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectID INTEGER,
                        TimeSlot TEXT NOT NULL,
                        RoomID INTEGER NOT NULL,
                        FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID),
                        FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
                    );

                    CREATE TABLE IF NOT EXISTS LecturerCourse (
                        LecturerID INTEGER,
                        CourseID INTEGER,
                        PRIMARY KEY (LecturerID, CourseID),
                        FOREIGN KEY (LecturerID) REFERENCES Lecturer(LecturerID),
                        FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
                    );

                    CREATE TABLE IF NOT EXISTS LecturerSubject (
                        LecturerID INTEGER,
                        SubjectID INTEGER,
                        PRIMARY KEY (LecturerID, SubjectID),
                        FOREIGN KEY (LecturerID) REFERENCES Lecturer(LecturerID),
                        FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID)
                    );

                    CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        UserPassword TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS ManageMarks (
                        StudentID INTEGER,
                        ExamID INTEGER,
                        Score INTEGER,
                        PRIMARY KEY (StudentID, ExamID),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (ExamID) REFERENCES Exam(ExamID)
                    );

                    CREATE TABLE IF NOT EXISTS LecturerStudent (
                        LecturerID INTEGER,
                        StudentID INTEGER,
                        PRIMARY KEY (LecturerID, StudentID),
                        FOREIGN KEY (LecturerID) REFERENCES Lecturer(LecturerID),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
                    );

                    CREATE TABLE IF NOT EXISTS Rooms (
                        RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL
                    );
                ";

                cmd.ExecuteNonQuery();
            }
        }
    }
}

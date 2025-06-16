using System.Data.SQLite;

namespace Unicom_TIC_Management_System.Repositories
{
    public class DatabaseManager
    {
        // Singleton pattern (optional)
        private static DatabaseManager? _instance;
        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseManager();
                return _instance;
            }
        }

        // Create all necessary tables in the SQLite database
        public static void CreateTables(SQLiteConnection conn)
        {
            // Enable foreign key constraints in SQLite
            using (var pragmaCmd = conn.CreateCommand())
            {
                pragmaCmd.CommandText = "PRAGMA foreign_keys = ON;";
                pragmaCmd.ExecuteNonQuery();
            }

            // Define each table creation command separately
            string[] tableCommands = new string[]
            {
                @"
                CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT NOT NULL,
                    RoomType TEXT NOT NULL
                );",

                @"
                CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL
                );",

                @"
                CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentName TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    DOB TEXT NOT NULL,
                    CourseID INTEGER NOT NULL,
                    FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS Lecturer (
                    LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                    LecturerName TEXT NOT NULL,
                    PhoneNumber TEXT NOT NULL,
                    Address TEXT NOT NULL
                );",

                @"
                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT NOT NULL,
                    ExamMarks TEXT NOT NULL
                );",

                @"
                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER NOT NULL,
                    ExamID INTEGER NOT NULL,
                    SubjectID INTEGER NOT NULL,
                    Score INTEGER NOT NULL,
                    ExamName TEXT NOT NULL,
                    StudentName TEXT NOT NULL
                );",

                @"
                CREATE TABLE IF NOT EXISTS Admin (
                    AdminID INTEGER PRIMARY KEY AUTOINCREMENT,
                    AdminName TEXT NOT NULL,
                    Password TEXT NOT NULL
                );",

                @"
                CREATE TABLE IF NOT EXISTS Staff (
                    StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StaffName TEXT NOT NULL,
                    StaffPassword TEXT NOT NULL
                );",

                @"
                CREATE TABLE IF NOT EXISTS Subjects (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL,
                    CourseID INTEGER,
                    CourseName TEXT,
                    FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS TimeTable (
                    TimeTableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER,
                    TimeSlot TEXT NOT NULL,
                    RoomID INTEGER NOT NULL,
                    FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID),
                    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS LecturerCourse (
                    LecturerID INTEGER,
                    CourseID INTEGER,
                    PRIMARY KEY (LecturerID, CourseID),
                    FOREIGN KEY (LecturerID) REFERENCES Lecturer(LecturerID),
                    FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS LecturerSubject (
                    LecturerID INTEGER,
                    SubjectID INTEGER,
                    PRIMARY KEY (LecturerID, SubjectID),
                    FOREIGN KEY (LecturerID) REFERENCES Lecturer(LecturerID),
                    FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );",

                @"
                CREATE TABLE IF NOT EXISTS ManageMarks (
                    StudentID INTEGER,
                    ExamID INTEGER,
                    Score INTEGER,
                    PRIMARY KEY (StudentID, ExamID),
                    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY (ExamID) REFERENCES Exam(ExamID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS LecturerStudent (
                    LecturerID INTEGER,
                    StudentID INTEGER,
                    PRIMARY KEY (LecturerID, StudentID),
                    FOREIGN KEY (LecturerID) REFERENCES Lecturer(LecturerID),
                    FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
                );"
            };

            // Execute each table creation command one by one
            foreach (var cmdText in tableCommands)
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // TODO: Implement these methods as per your need

        internal List<Modals.Student> GetAllStudents()
        {
            throw new System.NotImplementedException();
        }

        internal object GetStudentMarks(int studentId)
        {
            throw new System.NotImplementedException();
        }

        internal object GetStudentTimetable(int studentId)
        {
            throw new System.NotImplementedException();
        }
    }
}

using System.Data.SQLite;

namespace Unicom_TIC_Management_System.Repositories
{
    public class DatabaseManager
    {
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

        public static void CreateTables(SQLiteConnection conn)
        {
            using (var pragmaCmd = conn.CreateCommand())
            {
                pragmaCmd.CommandText = "PRAGMA foreign_keys = ON;";
                pragmaCmd.ExecuteNonQuery();
            }

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
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );",

                @"
                CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentName TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    DOB TEXT NOT NULL,
                    Gender TEXT NOT NULL,
                    CourseID INTEGER NOT NULL,
                    CourseName TEXT NOT NULL,
                    UserID INTEGER NOT NULL,
                    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS Lecturers (
                    LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                    LecturerName TEXT NOT NULL,
                    PhoneNumber INTEGER NOT NULL,
                    Address TEXT NOT NULL,
                    UserID INTEGER NOT NULL,
                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT NOT NULL,
                    ExamMarks INTEGER,
                    SubjectID INTEGER NOT NULL,
                    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER NOT NULL,
                    ExamID INTEGER NOT NULL,
                    SubjectID INTEGER NOT NULL,
                    Score INTEGER NOT NULL,
                    ExamName TEXT NOT NULL,
                    StudentName TEXT NOT NULL,
                    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID),
                    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS Admins (
                    AdminID INTEGER PRIMARY KEY AUTOINCREMENT,
                    AdminName TEXT NOT NULL,
                    UserID INTEGER NOT NULL,
                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS Staffs (
                    StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StaffName TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    PhoneNumber INTEGER NOT NULL,
                    UserID INTEGER NOT NULL,
                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS Subjects (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL,
                    CourseID INTEGER,
                    CourseName TEXT,
                    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS Timetables (
                    TimetableID INTEGER PRIMARY KEY ,
                    SubjectID INTEGER NOT NULL,
                    TimeSlot TEXT NOT NULL,
                    RoomID INTEGER NOT NULL,
                    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS LecturerCourse (
                    LecturerID INTEGER,
                    CourseID INTEGER,
                    PRIMARY KEY (LecturerID, CourseID),
                    FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
                    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS LecturerSubjects (
                    LecturerID INTEGER,
                    SubjectID INTEGER,
                    PRIMARY KEY (LecturerID, SubjectID),
                    FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
                    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS ManageMarks (
                    StudentID INTEGER,
                    ExamID INTEGER,
                    Score INTEGER,
                    PRIMARY KEY (StudentID, ExamID),
                    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
                );",

                @"
                CREATE TABLE IF NOT EXISTS LecturerStudents (
                    LecturerID INTEGER,
                    StudentID INTEGER,
                    PRIMARY KEY (LecturerID, StudentID),
                    FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
                    FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
                );"
            };

            foreach (var cmdText in tableCommands)
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.ExecuteNonQuery();
                }
            }
        }

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

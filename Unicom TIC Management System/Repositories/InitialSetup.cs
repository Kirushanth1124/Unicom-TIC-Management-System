using System;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System
{
    public class InitialSetup
    {
        public static void CreateDefaultAdmin()
        {
            var loginController = new LoginController();

            if (!loginController.UsernameExists("admin"))
            {
                var adminUser = new User
                {
                    Username = "admin",
                    Password = "admin123",
                    Role = "Admin"
                };

                loginController.AddUser(adminUser);
                Console.WriteLine("Default admin created successfully.");
            }
            else
            {
                Console.WriteLine("Admin already exists.");
            }
        }

        /*public static void CreateDefaultLecturer()
        {
            var loginController = new LoginController();

            if (!loginController.UsernameExists("lecturer"))
            {
                var lecturerUser = new User
                {
                    Username = "lecturer",
                    Password = "lecturer123",
                    Role = "Lecturer"
                };

                loginController.AddUser(lecturerUser);
                Console.WriteLine("Default Lecturer created successfully.");
            }
            else
            {
                Console.WriteLine("Lecturer already exists.");
            }
        }

        public static void CreateDefaultStaff()
        {
            var loginController = new LoginController();

            if (!loginController.UsernameExists("staff"))
            {
                var staffUser = new User
                {
                    Username = "staff",
                    Password = "staff123",
                    Role = "Staff"
                };

                loginController.AddUser(staffUser);
                Console.WriteLine("Default Staff created successfully.");
            }
            else
            {
                Console.WriteLine("Staff already exists.");
            }
        }*/
    }
}

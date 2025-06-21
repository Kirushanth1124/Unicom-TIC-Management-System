namespace Unicom_TIC_Management_System.Modals
{
    public class AppUser
    {
        public int UserID { get; set; }
        public string Name { get; set; }  // Display name (AdminName, etc.)
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}

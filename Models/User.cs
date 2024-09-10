namespace CMCS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; } // Lecturer, Coordinator, Manager
    }
}

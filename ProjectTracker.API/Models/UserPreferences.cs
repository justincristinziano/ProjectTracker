namespace ProjectTracker.API.Models
{
    public class UserPreferences
    {
        public int Id { get; set; }
        public int UserId { get; set;}

        public bool CalendarNotifications { get; set; } = false;
        public bool TextNotifications { get; set; } = false;
    }
}
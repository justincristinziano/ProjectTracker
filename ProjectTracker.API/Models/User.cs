using ProjectTracker.API.Enums;


namespace ProjectTracker.API.Models
{
    public class User
    {
        /// <value>The user's id (primary key)</value>
        public int UserId { get; set;}

        /// <value>The user's first name</value>
        public string FirstName { get; set; } = "Tracker User";

        /// <value>The user's last name</value>
        public string LastName { get; set; } = "";

        /// <value>The user's google calendar ID</value>
        public string? GoogleCalendarId { get; set; }

        /// <value>The user's assigned projects</value>
        public List<Project> AssignedProjects { get; set; } = new List<Project>();

        /// <value>The user's application preferences</value>
        public UserPreferences? Preferences { get; set; }

        /// <value>The user's role</value>
        public UserRole Role { get; set; } = UserRole.ViewOnly;

        /// <summary>A manager, CSS, or implementation specialist can upload a new project</summary>
        public bool CanUploadProjects() =>
            Role == UserRole.CSS || Role == UserRole.IMP || Role == UserRole.Manager;

        /// <summary>An implementation specialist can claim projects</summary>
        public bool CanClaimProjects() =>
            Role == UserRole.IMP;

        /// <summary>An implementation specialist can transfer the project to another imp specialist</summary>
        public bool CanTransferProjects() =>
            Role == UserRole.IMP;

        /// <summary>Everyone can view all the projects</summary>
        public bool CanViewAllProjects() => true;

        /// <summary>A manager can reassign projects to other implementation specialists</summary>
        public bool CanReassignProjects() =>
            Role == UserRole.Manager;

        /// <summary>A manager or implementation specialist can see the report stats</summary>
        public bool CanViewReports() =>
            Role == UserRole.Manager || Role == UserRole.IMP;
    }
}

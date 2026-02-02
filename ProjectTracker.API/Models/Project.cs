// Author: Justin Cristinziano
// Last Updated: 1-28-26
// Description: This file contains the Project model. A Project is made when a
// Levitate client requests an update to their client list
using ProjectTracker.API.Enums; 

namespace ProjectTracker.API.Models
{
    public class Project
    {
        /// <value> This is the project's ID </value>
        public int Id { get; set; } 
        public DateTime DateUploaded { get; set;}
        public DateTime DueDate { get; set;}

        /// <value> The date the project was completed (null until completed)</value>
        public DateTime? DateCompleted { get; set;}  

        /// <value> This Project's Customer </value>
        public string CustomerName { get; set;}

        /// <value> This project's current status </value>
        public string Status { get; set;}

        /// <value> This project's assigned user </value>
        public User AssignedUser { get; set;}

        /// <value> This project's sharefile link </value>
        public string ShareFileLink { get; set; }

        /// <value> This is the AI progress (check enum) </value>
        public AIProgress AIUsed { get; set; }
        
    }
}
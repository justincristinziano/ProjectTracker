using Microsoft.EntityFrameworkCore;
using ProjectTracker.API.Models;

namespace ProjectTracker.API.Data
{
    public class ApplicationDbContext : DbContext
    {

        /// <summary>
        /// This is the constructor for the database initializer
        /// </summary>
        /// <param name="options">The database options chosen in Program.cs</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
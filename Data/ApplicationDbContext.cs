using EventOrganizer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EventOrganizer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

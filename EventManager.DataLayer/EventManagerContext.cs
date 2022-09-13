using EventManager.DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace EventManager.DataLayer
{
    public class EventManagerContext : DbContext
    {
        private readonly string _connectionString;

        public EventManagerContext()
        {
            _connectionString = "Data Source=/Users/daniel/Projects/EventManager/eventmanager.sqlite";
        }

        public EventManagerContext(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Value should not be empty.", nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }
    }
}
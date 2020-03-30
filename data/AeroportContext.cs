using Microsoft.EntityFrameworkCore;
using trpz_labs.model.entity;

namespace trpz_labs.data
{
    public class AirportContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        
        
        public AirportContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;database=labdbåtest;uid=root;pwd=1234;";
            optionsBuilder
                .UseLazyLoadingProxies(false)
                .UseMySql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
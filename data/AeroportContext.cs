using Microsoft.EntityFrameworkCore;
using trpz_labs.model.entity;

namespace trpz_labs.data
{
    public class AirportContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }

        // public DbSet<Client> Clients { get; set; }
        //
        // public DbSet<Plane> Planes { get; set; }
        //
        // public DbSet<Ticket> Tickets { get; set; }
    }
}
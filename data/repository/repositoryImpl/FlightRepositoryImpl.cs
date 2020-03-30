using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using trpz_labs.model.entity;

namespace trpz_labs.data.repository.repositoryImpl
{
    public class FlightRepositoryImpl : IFlightRepository
    {
        private AirportContext context;

        public FlightRepositoryImpl(AirportContext context)
        {
            this.context = context;
        }

        public IEnumerable<Flight> GetAll()
        {
            return context.Flights.Include(b => b.Passengers).ThenInclude(p => p.Ticket);
        }

        public void Update(Flight flight)
        {
            context.Entry(flight).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
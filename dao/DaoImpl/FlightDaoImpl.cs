using System;
using System.Collections.Generic;
using trpz_labs.model.entity;

namespace trpz_labs.dao.DaoImpl
{
    public class FlightDaoImpl : FlightDAO
    {
        public IList<Flight> FindAll()
        {
            var tickets = initializeTickets();
            IList<Client> passengers = initializePassengers(tickets);
            IList<Client> passengers2 = initializePassengers(tickets);
            passengers2.Add(new Client("Client5", "Client2", tickets[0]));

            var departureTime = new DateTime(2020, 11, 27, 18, 0, 0);
            var lastTimeForBuying = new DateTime(2020, 11, 26, 18, 0, 0);
            var flights = new List<Flight>
            {
                new Flight(21312, "first", departureTime,
                    lastTimeForBuying, TimeSpan.Zero,
                    Status.READY, new Plane("first plane", 31231, 1000, 100), passengers, tickets),

                new Flight(312, "second", departureTime, lastTimeForBuying,
                    new TimeSpan(0, 2, 30), Status.DELAYED,
                    new Plane("second plane", 321, 1500, 100), passengers2, tickets)
            };
            return flights;
        }

        public Flight Update(Flight flight)
        {
            Console.WriteLine(flight);
            return flight;
        }

        private static List<Client> initializePassengers(IList<Ticket> tickets)
        {
            return new List<Client>
            {
                new Client("Client1", "Client1", tickets[0]),
                new Client("Client2", "Client2", tickets[1]),
                new Client("Client3", "Client3", tickets[2])
            };
        }

        private static IList<Ticket> initializeTickets()
        {
            return new List<Ticket>
            {
                new Ticket("VIP", 1000, 20),
                new Ticket("Casual", 500, 20),
                new Ticket("Low", 100, 20)
            };
        }
    }
}
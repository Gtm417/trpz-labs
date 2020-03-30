using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace trpz_labs.model.entity
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime LastTimeForBuying { get; set; }

        public TimeSpan DelayedTime { get; set; }

        public Status Status { get; set; }

        public Plane Plane { get; set; }

        public IList<Client> Passengers { get; set; }

        public IList<Ticket> Ticket { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(Number)}: {Number}, {nameof(Name)}: {Name}, {nameof(DepartureTime)}: {DepartureTime}, {nameof(LastTimeForBuying)}: {LastTimeForBuying}, {nameof(DelayedTime)}: {DelayedTime}, {nameof(Status)}: {Status}";
        }
        
        
        //public Flight(int number, string name, DateTime departureTime, DateTime lastTimeForBuying,
        //    TimeSpan delayedTime, Status status, Plane plane,
        //    IList<Client> passengers, IList<Ticket> ticket)
        //{
        //    Number = number;
        //    Name = name;
        //    DepartureTime = departureTime;
        //    LastTimeForBuying = lastTimeForBuying;
        //    DelayedTime = delayedTime;
        //    Status = status;
        //    Plane = plane;
        //    Passengers = passengers;
        //    Ticket = ticket;
        //}
    }
}
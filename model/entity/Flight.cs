using System.Collections.Generic;

namespace trpz_labs.model.entity
{
    public class Flight
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }

        public Plane Plane { get; set; }

        public List<Client> Passengers { get; set; }

        public List<Ticket> Ticket { get; set; }
    }
}
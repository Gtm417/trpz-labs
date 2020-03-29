using System;
using System.Collections.Generic;
using trpz_labs.model.entity;

namespace trpz_labs.model.service
{
    public interface FlightService
    {
        IEnumerable<Flight> GetAllFlights();
        void UpdateFlight(Flight flight);
        // void SetLastBuyingTimeToFlight(Flight flight, DateTime dateTime);
        // void SetDelayedTime(Flight flight, TimeSpan delayedTime);
    }
}
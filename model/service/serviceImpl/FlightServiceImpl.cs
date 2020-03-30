using System;
using System.Collections.Generic;
using trpz_labs.data;
using trpz_labs.model.entity;

namespace trpz_labs.model.service.serviceImpl
{
    public class FlightServiceImpl : FlightService
    {
        private readonly UnitOfWork unitOfWork;

        public FlightServiceImpl()
        {
            unitOfWork = new UnitOfWork();
        }

        public IEnumerable<Flight> GetAllFlights()
        {
            return unitOfWork.Flights.GetAll();
        }
        
        public void UpdateFlight(Flight flight)
        {
            unitOfWork.Flights.Update(flight);
        }
        
        // public void SetLastBuyingTimeToFlight(Flight flight, DateTime dateTime)
        // {
        //     flight.LastTimeForBuying = dateTime;
        //     unitOfWork.Flights.Update(flight);
        // }
        //
        // public void SetDelayedTime(Flight flight, TimeSpan timeSpan)
        // {
        //     flight.DelayedTime = timeSpan;
        //     flight.DepartureTime = flight.DepartureTime.Add(timeSpan);
        //     unitOfWork.Flights.Update(flight);
        // }
    }
}
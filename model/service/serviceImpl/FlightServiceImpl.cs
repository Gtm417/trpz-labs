using System;
using System.Collections.Generic;
using trpz_labs.dao;
using trpz_labs.dao.DaoImpl;
using trpz_labs.model.entity;

namespace trpz_labs.model.service.serviceImpl
{
    public class FlightServiceImpl : FlightService
    {
        private readonly FlightDAO flightDao;
        private ClientDAO clientDao;

        public FlightServiceImpl()
        {
            flightDao = new FlightDaoImpl();
            clientDao = new ClientDaoImpl();
        }

        public IList<Flight> GetAllFlights()
        {
            return flightDao.FindAll();
        }

        // public IList<Client> GetAllPassengersByFlight(Flight flight)
        // {
        //     return clientDao.FindAllPassengersByFlight(flight);
        // }

        public void UpdateFlight(Flight flight)
        {
            flightDao.Update(flight);
        }

        public void SetLastBuyingTimeToFlight(Flight flight, DateTime dateTime)
        {
            flight.LastTimeForBuying = dateTime;
            flightDao.Update(flight);
        }

        public void SetDelayedTime(Flight flight, TimeSpan timeSpan)
        {
            flight.DelayedTime = timeSpan;
            flight.DepartureTime = flight.DepartureTime.Add(timeSpan);
            flightDao.Update(flight);
        }
    }
}
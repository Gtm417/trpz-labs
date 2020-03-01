using System.Collections.Generic;
using trpz_labs.model.entity;

namespace trpz_labs.dao.DaoImpl
{
    public class ClientDaoImpl : ClientDAO
    {
        public IList<Client> FindAllPassengersByFlight(Flight flight)
        {
            return flight.Passengers;
        }
    }
}
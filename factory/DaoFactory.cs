using trpz_labs.dao;
using trpz_labs.dao.DaoImpl;

namespace trpz_labs.factory
{
    public class DaoFactory
    {
        public static FlightDAO createFlightDao()
        {
            return new FlightDaoImpl(); 
        }
        
    }
}
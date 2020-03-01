using System.Collections.Generic;
using trpz_labs.model.entity;

namespace trpz_labs.dao
{
    public interface FlightDAO
    {
        IList<Flight> FindAll();
        
    }
}
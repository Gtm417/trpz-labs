using System.Collections.Generic;
using trpz_labs.model.entity;

namespace trpz_labs.data.repository
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> GetAll();

        void Update(Flight flight);
    }
}
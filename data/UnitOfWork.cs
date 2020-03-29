using System;
using trpz_labs.data.repository;
using trpz_labs.data.repository.repositoryImpl;

namespace trpz_labs.data
{
    public class UnitOfWork : IDisposable
    {
        private AirportContext context  = new AirportContext();
        private IFlightRepository flightRepository;
        private bool disposed = false;
        
        
        public IFlightRepository Flights
        {
            get { return flightRepository ??= new FlightRepositoryImpl(context); }
        }
        
        public void Save()
        {
            context.SaveChanges();
        }
        
        
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using trpz_labs.Annotations;
using trpz_labs.model.entity;
using trpz_labs.model.service;

namespace trpz_labs.viewModel
{
    public class FlightViewModel : INotifyPropertyChanged
    {
        private readonly FlightService _flightService;

        private Flight selectedFlight;


        public FlightViewModel(FlightService flightService)
        {
            _flightService = flightService;
            foreach (Flight flight in flightService.GetAllFlights())
            {
                // foreach (Client pa in flight.Passengers)
                // {
                //     Console.WriteLine(pa);
                // }
            }
            Flights = new ObservableCollection<Flight>(flightService.GetAllFlights());
        }

        public Flight SelectedFlight
        {
            get => selectedFlight;
            set
            {
                selectedFlight = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Flight> Flights { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void saveChanges()
        {
            _flightService.UpdateFlight(SelectedFlight);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
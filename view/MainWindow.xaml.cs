using System.Windows;
using trpz_labs.model.service.serviceImpl;
using trpz_labs.viewModel;

namespace trpz_labs.view
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new FlightViewModel(new FlightServiceImpl());
        }

        private void btn_checkPassengers_Click(object sender, RoutedEventArgs e)
        {
            dg_passengers.ItemsSource = ((FlightViewModel) DataContext).SelectedFlight.Passengers;
        }

        private void btn_saveChanges_Click(object sender, RoutedEventArgs e)
        {
            ((FlightViewModel) DataContext).saveChanges();
        }
    }
}
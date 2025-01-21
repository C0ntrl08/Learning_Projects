using ParkingManagementSystem.models;

namespace ParkingManagementSystem.services
{
    public class PaymentServices
    {
        private const double CarRatePerMinute = 1.50;
        private const double MotorcycleRatePerMinute = 1.10;

        public double CalculateParkingFee(IVehicle vehicle, TimeSpan parkedDuration)
        {
            double ratePerMinute = vehicle is Car ? CarRatePerMinute : MotorcycleRatePerMinute;
            return ratePerMinute * parkedDuration.TotalMinutes;
        }
    }
}

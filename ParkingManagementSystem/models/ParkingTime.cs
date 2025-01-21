namespace ParkingManagementSystem.models
{
    public class ParkingTime
    {
        public IVehicle Vehicle { get; private set; }
        public DateTime StartTime { get; private set; }

        public ParkingTime(IVehicle vehicle)
        {
            Vehicle = vehicle;
            StartTime = DateTime.Now;
        }

        public TimeSpan GetParkedDuration()
        {
            return DateTime.Now - StartTime;
        }

        public override string ToString()
        {
            return $"{Vehicle.Make} {Vehicle.Model} with license plate {Vehicle.LicensePlate} - Parked for {GetParkedDuration().TotalMinutes:F2} minutes.";
        }
    }
}

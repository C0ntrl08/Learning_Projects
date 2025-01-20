namespace ParkingManagementSystem.models
{
    public class Motorcycle : IVehicle
    {
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Motorcycle(string licensePlate, string make, string model)
        {
            LicensePlate = licensePlate;
            Make = make;
            Model = model;
        }
    }
}

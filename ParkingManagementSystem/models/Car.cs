namespace ParkingManagementSystem.models
{
    public class Car : IVehicle
    {
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Car(string licensePlate, string make, string model)
        {
            LicensePlate = licensePlate;
            Make = make;
            Model = model;
        }

        public override string ToString()
        {
            return $"{Make} {Model} with {LicensePlate} license plate";
        }
        
    }
}

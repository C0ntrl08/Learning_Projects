using ParkingManagementSystem.ui;

namespace ParkingManagementSystem.models
{
    public interface IVehicle
    {
        string LicensePlate { get; set; }
        string Make { get; set; }
        string Model { get; set; }

    }
}

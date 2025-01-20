using ParkingManagementSystem.models;
using ParkingManagementSystem.ui;

namespace ParkingManagementSystem.services
{
    public class ParkingServices
    {
        int maxParkingSpaces = 100;

        private List<IVehicle> ParkedVehicles = new List<IVehicle>();
        private int AvailableSpaces;
        public ParkingServices()
        {
            AvailableSpaces = maxParkingSpaces;
        }

        public void ParkVehicle(IVehicle vehicle)
        {
            if (AvailableSpaces > 0)
            {
                ParkedVehicles.Add(vehicle);
                AvailableSpaces--;
            }
            else
            {
                throw new InvalidOperationException(Menu.NoParkingSpacesLeft());
            }
        }

        public void RemoveVehicleByLicensePlate(string licensePlate)
        {
            IVehicle vehicleToRemove = ParkedVehicles.Find(v => v.LicensePlate == licensePlate);
            if (vehicleToRemove != null)
            {
                ParkedVehicles.Remove(vehicleToRemove);
                AvailableSpaces++;
            }
            else
            {
                throw new InvalidOperationException(Menu.VehicleNotFound());
            }

        }


    }
}

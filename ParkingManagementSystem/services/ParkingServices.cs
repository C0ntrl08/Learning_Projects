using ParkingManagementSystem.models;
using ParkingManagementSystem.ui;

namespace ParkingManagementSystem.services
{
    public class ParkingServices
    {
        int maxParkingSpaces = 100;
        private Dictionary<string, ParkingTime> ParkedVehicles = new Dictionary<string, ParkingTime>();
        //private List<IVehicle> ParkedVehicles = new List<IVehicle>();
        private int AvailableSpaces;
        public ParkingServices()
        {
            AvailableSpaces = maxParkingSpaces;
        }

        public void ParkVehicle(IVehicle vehicle)
        {
            if (AvailableSpaces > 0)
            {
                ParkedVehicles[vehicle.LicensePlate] = new ParkingTime(vehicle);
                AvailableSpaces--;
            }
            else
            {
                throw new InvalidOperationException(Menu.NoParkingSpacesLeft());
            }
        }

        public void RemoveVehicleByLicensePlate(string licensePlate)
        {
            if (ParkedVehicles.ContainsKey(licensePlate))
            {
                ParkedVehicles.Remove(licensePlate);
                AvailableSpaces++;
            }
            else
            {
                throw new InvalidOperationException(Menu.VehicleNotFound());
            }
        }
        public void ListParkedVehicles()
        {
            foreach (var parkedVehicle in ParkedVehicles.Values)
            {
                Console.WriteLine(parkedVehicle.ToString());
            }
        }
        public bool HasLicensePlateRegistered(string licensePlate)
        {
            return ParkedVehicles.ContainsKey(licensePlate);
        }

        public TimeSpan GetParkedDuration(string licensePlate)
        {
            if (ParkedVehicles.ContainsKey(licensePlate))
            {
                return ParkedVehicles[licensePlate].GetParkedDuration();
            }
            else
            {
                throw new InvalidOperationException(Menu.VehicleNotFound());
            }
        }

        public IVehicle GetVehicleByLicensePlate(string licensePlate)
        {
            if (ParkedVehicles.ContainsKey(licensePlate))
            {
                return ParkedVehicles[licensePlate].Vehicle;
            }
            else
            {
                throw new InvalidOperationException(Menu.VehicleNotFound());
            }
        }
    }
}

using System.ComponentModel.DataAnnotations;
using ParkingManagementSystem.ui;

namespace ParkingManagementSystem.models
{
    public class ParkingLot
    {
        private static ParkingLot _instance;
        // A static readonly object is used to ensure thread safety when creating the instance.
        private static readonly object _instanceLock = new object();
        public int TotalSpaces { get; private set; } = 100;
        public int AvailableSpaces { get; private set; }
        public List<IVehicle> ParkedVehicles { get; private set; }

        private ParkingLot()
        {
            AvailableSpaces = TotalSpaces;
            ParkedVehicles = new List<IVehicle>();
        }

        public static ParkingLot GetInstance()
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new ParkingLot();
                    }
                }
            }
            return _instance;
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
    }
}

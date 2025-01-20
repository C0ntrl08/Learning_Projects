using ParkingManagementSystem.models;
using ParkingManagementSystem.services;
using ParkingManagementSystem.ui;

namespace ParkingManagementSystem.controllers
{
    public static class OptionHandler
    {
        private static Dictionary<DateTime, string> UserProblems = new Dictionary<DateTime, string>();
        private static ParkingServices _parkingService = new ParkingServices();
        public static void HandleOption(int option) {

            switch (option) {
                case 1:
                    IVehicle carToPark = GetVehicleDetails("Car");
                    _parkingService.ParkVehicle(carToPark);
                    Menu.VehicleHasBeenParked();
                    //TODO - Time
                    break;
                case 2:
                    IVehicle motorcycleToPark = GetVehicleDetails("Motorcycle");
                    _parkingService.ParkVehicle(motorcycleToPark);
                    Menu.VehicleHasBeenParked();
                    // TODO - Time
                    break;
                case 3:
                    RemoveVehicle();
                    break;
                case 4:
                    Console.WriteLine("Processing payment...");
                    // logic to pay for parking
                    //_paymentService.PayForParking(car);
                    break;
                case 5:
                    Console.WriteLine("Extending parking time...");
                    // logic to pay for parking
                    // _paymentService.ExtendParkingTime(car,time);
                    break;
                case 6:
                    EnterProblem();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private static IVehicle GetVehicleDetails(string vehicleType)
        {
            Console.Write($"Please enter {vehicleType.ToLower()} details to park...\n");
            Console.Write("License plate: ");
            string licensePlate = Console.ReadLine();
            Console.Write("Manufacturer: ");
            string madeBy = Console.ReadLine();
            Console.Write($"{vehicleType} model name: ");
            string modelName = Console.ReadLine();

            if (vehicleType == "Car")
            {
                
                return new Car(licensePlate, madeBy, modelName);
            }
            else if (vehicleType == "Motorcycle")
            {
                return new Motorcycle(licensePlate, madeBy, modelName);
            }
            else
            {
                throw new InvalidOperationException(Menu.UnsupportedVehicle());
            }
        }

        private static void RemoveVehicle()
        {
            Menu.RemovingTheVehicle();
            string licensePlate = Console.ReadLine();
            _parkingService.RemoveVehicleByLicensePlate(licensePlate);
            Menu.VehicleHasBeenRemoved();
        }

        public static void EnterProblem()
        {
            Menu.DescribeProblem();
            string problemDescription = Console.ReadLine();
            DateTime problemTime = DateTime.Now;

            UserProblems[problemTime] = problemDescription;

            Console.WriteLine("Problem recorded at " +problemTime.ToString("HH:mm") + ": " + problemDescription);
        }



        
    }
}

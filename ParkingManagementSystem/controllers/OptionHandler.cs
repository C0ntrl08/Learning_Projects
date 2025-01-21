using ParkingManagementSystem.models;
using ParkingManagementSystem.services;
using ParkingManagementSystem.ui;

namespace ParkingManagementSystem.controllers
{
    public static class OptionHandler
    {
        private static Dictionary<DateTime, string> UserProblems = new Dictionary<DateTime, string>();
        private static ParkingServices _parkingService = new ParkingServices();
        private static PaymentServices _paymentService = new PaymentServices();

        public static void HandleOption(int option)
        {
            switch (option)
            {
                case 1:
                    IVehicle carToPark = GetVehicleDetails("Car");
                    _parkingService.ParkVehicle(carToPark);
                    Menu.VehicleHasBeenParked();
                    break;
                case 2:
                    IVehicle motorcycleToPark = GetVehicleDetails("Motorcycle");
                    _parkingService.ParkVehicle(motorcycleToPark);
                    Menu.VehicleHasBeenParked();
                    break;
                case 3:
                    RemoveVehicle();
                    break;
                case 4:
                    EnterProblem();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private static IVehicle GetVehicleDetails(string vehicleType)
        {
            string licensePlate;
            bool toContinue = true;
            Console.Write($"Please enter {vehicleType.ToLower()} details to park...\n");
            Console.Write("License plate: ");
            do
            {
                licensePlate = Console.ReadLine().ToUpper();
                if (_parkingService.HasLicensePlateRegistered(licensePlate))
                {
                    Menu.PlateAlreadyRegistered();
                }
                else
                {
                    toContinue = false;
                }
            } while (toContinue);

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
            _parkingService.ListParkedVehicles();
            string licensePlate = Console.ReadLine().ToUpper();

            try
            {
                TimeSpan parkedDuration = _parkingService.GetParkedDuration(licensePlate);
                IVehicle vehicleToRemove = _parkingService.GetVehicleByLicensePlate(licensePlate);
                _parkingService.RemoveVehicleByLicensePlate(licensePlate);
                double parkingFee = _paymentService.CalculateParkingFee(vehicleToRemove, parkedDuration);
                Console.WriteLine($"The vehicle was parked for {parkedDuration.TotalMinutes:F2} minutes. The total parking fee is {parkingFee:F2} euros.");
                Menu.VehicleHasBeenRemoved();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void EnterProblem()
        {
            Menu.DescribeProblem();
            string problemDescription = Console.ReadLine();
            if (InputChecker.IsTextNullOrEmpty(problemDescription))
            {
                throw new InvalidDataException(Menu.MessageEmpty());
            }
            else
            {
                DateTime problemTime = DateTime.Now;
                UserProblems[problemTime] = problemDescription;
                Console.WriteLine("Problem recorded at " + problemTime.ToString("HH:mm") + ": " + problemDescription);
            }
        }
    }
}


namespace ParkingManagementSystem.controllers
{
    public static class OptionHandler
    {
        public static void HandleOption(int option) {


            switch (option) {
                case 1:
                    Console.WriteLine("Please enter car details to park...");
                    // logic to park the car;
                    // _parkingService.ParkCar(car, lot);
                    break;
                case 2:
                    Console.WriteLine("Please enter car details to remove...");
                    // logic to remove the car
                    // _parkingService.RemoveCar(car,lot);
                    break;
                case 3:
                    Console.WriteLine("Processing payment...");
                    // logic to pay for parking
                    //_paymentService.PayForParking(car);
                    break;
                case 4:
                    Console.WriteLine("Extending parking time...");
                    // logic to pay for parking
                    // _paymentService.ExtendParkingTime(car,time);
                    break;
                case 5:
                    Console.WriteLine("Please describe the problem: ");
                    // _parkingService.ReportProblem(spot, problem);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        }
    }
}

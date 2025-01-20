using ParkingManagementSystem.controllers;

namespace ParkingManagementSystem.ui
{
    public static class Menu
    {
        public static void WelcomeScreen()
        {
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Welcome to the Parking Management System! ");
            Console.WriteLine($"Today is {today.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"The Time is {now.ToString("HH:mm")}");
            Console.WriteLine("-------------------------------------------");
        }
        public static void ShowChooseOptions() {
            Console.WriteLine("Select the wanted action: ");
            Console.WriteLine("1. I park my car");
            Console.WriteLine("2. I park my motorcycle");
            Console.WriteLine("3. I am taking my vehicle out");
            Console.WriteLine("4. Pay for parking");
            Console.WriteLine("5. Extend parking time");
            Console.WriteLine("6. Reporting a problem");
        }
        public static void AskingForConfirmation()
        {
            Console.WriteLine("Do you want to perform another action? (y/n)");
        }

        public static void InvalidInputTextForNumbers()
        {
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Invalid input. Please enter a valid number corresponding to the menu options.");
        }

        public static void InvalidInputTextForYesAndNo()
        {
            Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
        }

        public static void SayingGoodBye()
        {
            Console.WriteLine("Thank You for using our services. Good Bye!");
        }

        public static string NoParkingSpacesLeft()
        {
            return "No available spaces.";
        }

        public static string VehicleNotFound()
        {
            return "Vehicle not found.";
        }

        public static string UnsupportedVehicle()
        {
            return "Unsupported vehicle type.";
        }

        public static void VehicleHasBeenParked()
        {
            Console.WriteLine("Vehicle has been parked.");
        }

        public static void DescribeProblem()
        {
            Console.WriteLine("Please enter the problem description: ");
        }

        public static void VehicleHasBeenRemoved()
        {
            Console.WriteLine("Vehicle has been removed.");
        }

        public static void RemovingTheVehicle()
        {
            Console.WriteLine("Please enter the license plate number to remove the vehicle: ");
        }

    }
}

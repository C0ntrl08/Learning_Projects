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
            Console.WriteLine("2. I am taking out my car");
            Console.WriteLine("3. Pay for parking");
            Console.WriteLine("4. Extend parking time");
            Console.WriteLine("5. Reporting a problem");
        }
        public static void AskingForConfirmation()
        {
            Console.WriteLine("Do you want to perform another action? (y/n)");
        }

        public static void InvalidInputTextForNumbers()
        {
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

    }
}



namespace ParkingManagementSystem.ui
{
    public static class Menu
    {
        public static void welcomeScreen()
        {
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Welcome to the Parking Management System! ");
            Console.WriteLine($"Today is {today.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"The Time is {now.ToString("HH:mm")}");

            Console.WriteLine("-------------------------------------------");
        }

        public static void showChooseOptions() {
            Console.WriteLine("Select the wanted action: ");
            Console.WriteLine("1. I park my car");
            Console.WriteLine("2. I am taking out my car");
            Console.WriteLine("3. Pay for parking");
            Console.WriteLine("4. Extend parking time");
            Console.WriteLine("5. Reporting a problem");
        }


    }
}

using ParkingManagementSystem.models;

namespace ParkingManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ParkingManagementSystem.controllers.LogicBuilder.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message.ToString());
            }

            

            
        }

    }
}

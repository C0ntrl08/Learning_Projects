using ParkingManagementSystem.models;
using ParkingManagementSystem.ui;

namespace ParkingManagementSystem.controllers
{
    public static class LogicBuilder
    {
        private static readonly int minimumLevelOption = 1;
        private static readonly int maximumLevelOption = 7;
        private static Dictionary<DateTime, string> UserProblems = new Dictionary<DateTime, string>();
        public static void Run()
        {
            Menu.WelcomeScreen();
            ParkingLot.GetInstance();

            bool continueRunning = true;

            while (continueRunning)
            {
                Menu.ShowChooseOptions();

                int selectedOption;
                bool validInput = int.TryParse(Console.ReadLine(), out selectedOption);

                if (validInput && selectedOption >= minimumLevelOption && selectedOption <= maximumLevelOption)
                {
                    OptionHandler.HandleOption(selectedOption);

                    continueRunning = AskToContinue();
                }
                else
                {
                    Menu.InvalidInputTextForNumbers();
                }
            }
        }
        public static bool AskToContinue()
        {
            while (true)
            {
                Menu.AskingForConfirmation();
                string continueInput = Console.ReadLine().Trim().ToLower();
                if (InputChecker.IsValidOptionEntered(continueInput))
                {
                    if (continueInput == "n")
                    {
                        Menu.SayingGoodBye();
                        return false;
                    }
                    return true;
                }
                else
                {
                    Menu.InvalidInputTextForYesAndNo();
                }
            }
        }
    }
}

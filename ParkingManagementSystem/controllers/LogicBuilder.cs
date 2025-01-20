using ParkingManagementSystem.models;
using ParkingManagementSystem.ui;

namespace ParkingManagementSystem.controllers
{
    public static class LogicBuilder
    {
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

                if (validInput && selectedOption >= 1 && selectedOption <= 5)
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

using System.Reflection.Metadata.Ecma335;
using ParkingManagementSystem.ui;

namespace ParkingManagementSystem.controllers
{
    public static class LogicBuilder
    {
        public static void Run()
        {
            Menu.welcomeScreen();

            bool continueRunning = true;

            while (continueRunning)
            {
                Menu.showChooseOptions();

                int selectedOption;
                bool validInput = int.TryParse(Console.ReadLine(), out selectedOption);

                if (validInput && selectedOption >= 1 && selectedOption <= 5)
                {
                    OptionHandler.HandleOption(selectedOption);

                    continueRunning = AskToContinue();
                }
                else
                {
                    Menu.invalidInputTextForNumbers();
                }
            }
        }

        public static bool AskToContinue()
        {
            while (true)
            {
                Menu.askingForConfirmation();
                string continueInput = Console.ReadLine().Trim().ToLower();
                if (InputChecker.IsValidOptionEntered(continueInput))
                {
                    if (continueInput == "n")
                    {
                        Menu.sayingGoodBye();
                        return false;
                    }
                    return true;
                }
                else
                {
                    Menu.invalidInputTextForYesAndNo();
                }

            }
        }
    }

}

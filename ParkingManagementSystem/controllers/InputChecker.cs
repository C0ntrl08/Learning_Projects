namespace ParkingManagementSystem.controllers
{
    public static class InputChecker
    {
        public static bool IsValidOptionEntered(int option, int minOption, int maxOption)
        {

            return option >= minOption && option <= maxOption;
        }

        public static bool IsValidOptionEntered(string inputLetter)
        {
            return inputLetter == "y" || inputLetter == "n";
        }
    }
}

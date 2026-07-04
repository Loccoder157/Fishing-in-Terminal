using System;

namespace Ui
{
    class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("""
            ====== FISHING GAME ======
            1. Go Fishing
            2. Inventory
            3. Rods
            4. Boats
            5. Shop
            6. Player
            7. Save Game
            8. Load Game
            0. Exit
            ==========================
            """);
        }
        public static int SelectedOption()
        {
            int selectedOption;
            Console.Write("selectedOption: ");
            selectedOption = int.Parse(Console.ReadLine());
            return selectedOption;
        }
    }
}
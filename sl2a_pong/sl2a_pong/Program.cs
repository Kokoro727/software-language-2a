using System;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                DisplayMenuBox();

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Diff.difficulty();
                        break;
                    case "2":
                        DisplayDateTime();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to return to the main menu...");
                    Console.ReadKey();
                }
            }
        }

        static void DisplayMenuBox()
        {
            // Define the box size
            int boxWidth = 50;
            int boxHeight = 20;

            // Top border
            Console.WriteLine(new string('═', boxWidth));

            // Menu content
            string[] menuItems = {
                "Main Menu",
                "",
                "1. Choose gamemode",
                "2. Display Date and Time",
                "3. Exit",
                "",
                "Select an option: "
            };

            foreach (string item in menuItems)
            {
                string paddedItem = item.PadRight(boxWidth - 2);
                Console.WriteLine("║" + paddedItem.Substring(0, Math.Min(boxWidth - 2, paddedItem.Length)) + "║");
            }

            // Fill the rest of the box with empty lines
            for (int i = menuItems.Length; i < boxHeight - 1; i++)
            {
                Console.WriteLine("║" + new string(' ', boxWidth - 2) + "║");
            }

            // Bottom border
            Console.WriteLine(new string('═', boxWidth));
        }

        

        static void DisplayDateTime()
        {
            Console.Clear();
            Console.WriteLine($"Current Date and Time: {DateTime.Now}");
        }
    }
}

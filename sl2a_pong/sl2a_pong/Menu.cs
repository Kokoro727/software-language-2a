using System;
using baseClass;

namespace sl2a_pong
{
    public class Menu : ProgramBase
    {
        // declare variables
        private String dateAndTime;

        public Menu()
        {
            DisplayMenuBox();
            dateAndTime = "";
        }
        public void DisplayMenuBox()
        {
            // Define the box size
            int boxWidth = 50;
            int boxHeight = 20;

            // Top border
            //Console.WriteLine(new string('═', boxWidth));
            Print(new string('═', boxWidth));

            // Menu content
            string[] menuItems = {
                "Main Menu",
                "",
                "1. Play pong",
                "2. Display Date and Time",
                "3. Exit",
                "",
                "Select an option: "
            };

            foreach (string item in menuItems)
            {
                string paddedItem = item.PadRight(boxWidth - 2);
                //Console.WriteLine("║" + paddedItem.Substring(0, Math.Min(boxWidth - 2, paddedItem.Length)) + "║");
                Print("║" + paddedItem.Substring(0, Math.Min(boxWidth - 2, paddedItem.Length)) + "║");
            }

            // Fill the rest of the box with empty lines
            for (int i = menuItems.Length; i < boxHeight - 1; i++)
            {
                //Console.WriteLine("║" + new string(' ', boxWidth - 2) + "║");
                Print("║" + new string(' ', boxWidth - 2) + "║");
            }

            // Bottom border
            //Console.WriteLine(new string('═', boxWidth));
            Print(new string('═', boxWidth));
        }

        public void DisplayDateTime()
        {
            Console.Clear();
            //Console.WriteLine($"Current Date and Time: {DateTime.Now}");
            dateAndTime = $"Current Date and Time: {DateTime.Now}";
            Thread thread1 = new Thread(new ThreadStart(Print));
        }

        // a method derived from ProgramBase to implement a method to print to the console
        public override void Print()
        {
            Console.WriteLine(dateAndTime);
        }
        public override void Print(String message) 
        {
            Console.WriteLine(message);
        }
    }
}

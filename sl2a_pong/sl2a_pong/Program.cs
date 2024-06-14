using sl2a_pong;
using baseClass;
using System;
using System.ComponentModel.Design;

namespace Pong;

class Program : ProgramBase
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();

            //define and initialise classes
            Menu menu = new Menu();
            PongHandler pong = new PongHandler();

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    pong.playPong();
                    break;
                case "2":
                    menu.DisplayDateTime();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    //this.Print("Invalid option. Please try again.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPress any key to return to the main menu...");
                //this.Print("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }
        }


    }
}

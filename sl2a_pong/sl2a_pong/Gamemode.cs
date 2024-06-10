using System;

namespace Pong
{
    public static class Diff
    {
        public static void difficulty()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            Console.WriteLine("║                                                             ║");
            Console.WriteLine("║                                                             ║");
            Console.WriteLine("║                                                             ║");
            Console.WriteLine("║                                                             ║");
            Console.WriteLine("║                                                             ║");  
            Console.WriteLine("║Select Mode: 1. Play against AI  2. Play against Friend      ║");
            Console.WriteLine("║                                                             ║");
            Console.WriteLine("║                                                             ║");
            Console.WriteLine("║                                                             ║");
            Console.WriteLine("║                                                             ║");
            Console.WriteLine("║                                                             ║");
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
            string modeInput = Console.ReadLine();

            if (modeInput == "1")
            {
                Console.Clear();
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("║Select Difficulty: 1. Easy  2. Medium  3. Hard  4. Impossible║");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("║                                                             ║");
                Console.WriteLine("═══════════════════════════════════════════════════════════════");
                string difficultyInput = Console.ReadLine();
                Difficulty difficulty = Difficulty.Medium;

                switch (difficultyInput)
                {
                    case "1":
                        difficulty = Difficulty.Easy;
                        break;
                    case "2":
                        difficulty = Difficulty.Medium;
                        break;
                    case "3":
                        difficulty = Difficulty.Hard;
                        break;
                    case "4":
                        difficulty = Difficulty.Impossible;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Defaulting to Medium difficulty.");
                        break;
                }

                pongHandler.PlayPong(false, difficulty);
            }
            else if (modeInput == "2")
            {
                pongHandler.PlayPong(true, Difficulty.Medium);
            }
            else
            {
                Console.WriteLine("Invalid selection. Exiting.");
            }
        }
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard,
        Impossible
    }
}

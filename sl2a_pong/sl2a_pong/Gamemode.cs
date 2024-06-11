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

            pongHandler.PlayPong();
        }
    }

   
}

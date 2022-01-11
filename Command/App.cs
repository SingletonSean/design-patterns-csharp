using System;

namespace Command
{
    public class App
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Press one of the key below to perform the corresponding action:");
                Console.WriteLine("A. Action 1");
                Console.WriteLine("B. Action 2");
                Console.WriteLine("C. Undo");

                ConsoleKey action = Console.ReadKey().Key;
                Console.WriteLine();

                switch (action)
                {
                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.B:
                        break;
                    case ConsoleKey.C:
                        break;
                }
            }
        }
    }
}

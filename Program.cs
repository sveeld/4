using System;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TestAppConsole";

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("HELLO");

            Console.Write(" ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WORLD");

            Console.ResetColor();
            Console.Write("App is successed");

            Console.ReadLine();
           /* foreach (var arg in args)
            {
                Console.Write(arg);
                Console.Write(" ");
            }
	
            Console.ReadLine();*/
        }
    }
}

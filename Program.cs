using System;

namespace TestAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TestAppConsole";

            string str1 = "Hello World";
            string str2 = "HELLO";
            string str3 = "WORLD";
            
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(str1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(str2);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str3);

            Console.ResetColor();
            Console.Write("App is successed");

            Console.ReadLine();
        }
    }
}

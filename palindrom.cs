// Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)
// Александров Дмитрий [11-3-6]

using System;

namespace CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string origin = Console.ReadLine();
            string readableChars = "";
            foreach (char c in origin)
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                {
                    readableChars += char.ToLower(c);
                }
            }
            
            bool isPalindrom = true;
            for (int i = 0; i < readableChars.Length / 2; ++i)
            {
               if (readableChars[i] != readableChars[readableChars.Length - i - 1])
               {
                   isPalindrom = false;
               }
            }
            
            Console.Write($"\"{origin}\" is ");
            Console.WriteLine(isPalindrom ? "palindrom" : "not palindrom");
        }
    }
}

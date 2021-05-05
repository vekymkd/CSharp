using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("---------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");

            Console.WriteLine("---------------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  * * *");
            Console.WriteLine("    *");
            Console.WriteLine("   * *");
            Console.WriteLine("  *   *");

            Console.WriteLine("---------------");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Velimir Stojanov, student at SEDC");
            Console.ReadLine();
        }
    }
}

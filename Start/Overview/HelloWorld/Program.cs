using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine() ?? "Guest";
            Console.WriteLine("Hello there " + name + "!");
        }
    }
}

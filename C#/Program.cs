using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}Hello, {name}! Nice to see you!");
        }
    }
}

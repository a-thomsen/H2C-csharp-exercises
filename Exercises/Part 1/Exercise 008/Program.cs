using System;

namespace exercise_08
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string greeting = "Hello ";
            string name = Console.ReadLine();
            Console.WriteLine(greeting + name + "!");
        }
    }
}

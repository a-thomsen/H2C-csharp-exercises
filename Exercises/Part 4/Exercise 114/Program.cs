using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
          int count = 0; 

          while (true) {
            string line = Console.ReadLine();

                if (line == "end") {
                break;
                }
            count++; 
          }
        Console.WriteLine("Strings read: " + count); 
        }
    }
}
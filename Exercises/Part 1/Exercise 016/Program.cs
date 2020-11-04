using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("How many days?");
      int days = Console.ReadLine();
      Console.WriteLine(days + " days is equal to " + (days*86400) + " seconds.");
    }
  }
}

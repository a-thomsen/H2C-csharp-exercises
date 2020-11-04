using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give a string: ");
        string str = Console.ReadLine();
      Console.WriteLine("Give an integer: ");
        string userInt = Console.ReadLine();
        int intValue = Convert.ToInt32(userInt);
      Console.WriteLine("Give a double: ");
        string userDoub = Console.ReadLine();
        double doubleValue = Convert.ToDouble(userDoub);
      Console.WriteLine("Give me the truth!");
        string userBool = Console.ReadLine();
        bool booleanValue = System.Convert.ToBoolean(userBool);
      Console.WriteLine("Your string: " + str + "\n" +
      "Your integer: " + intValue + "\n" +
      "Your double: " + doubleValue + "\n" +
      "Your boolean: " + booleanValue);
    }
  }
}

using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account annasAccount = new Account("Anna's account", 100.00);

      annasAccount.Deposit(20);
      Console.WriteLine("The balance of Anna's account is now: " + annasAccount.balance);
    }
  }
}
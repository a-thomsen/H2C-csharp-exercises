using System;

namespace exercise_100
{
  public class Debt {
    public double balance;
    public double interestRate; 

  public Debt (double initialBalance, double initialInterestRate) {
      this.initialBalance = initialBalance;
      this.initialInterestRate = initialInterestRate;
  }

  public void PrintBalance(){
      Console.WriteLine("Balance: " + this.initialBalance);
  }

  public void WaitOneYear() {
      this.initialBalance = this.initialBalance * this.initialInterestRate; 
    }
  }
}
using System;

namespace exercise_108
{
  public class PaymentCard {
      private double balance;

  public PaymentCard (double openingBalance){
      this.balance = openingBalance;
    }
  public override string ToString(){
    return "The card has a balance of " + this.balance + " euros"; 
    }
  public void EatLunch(){
      double lunch = 10.6;

      if (this.balance >= 10.6){
      this.balance = this.balance - lunch;
      }
    }
  public void DrinkCoffee(){
      double coffee = 2.0;

      if (this.balance >= 2.0){
      this.balance = this.balance - coffee;
      }
    }
  }
}
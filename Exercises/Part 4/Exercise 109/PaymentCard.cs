using System;

namespace exercise_109
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

      if (this.balance >= lunch){
      this.balance = this.balance - lunch;
      }
    }
  public void DrinkCoffee(){
      double coffee = 2.0;

      if (this.balance >= coffee){
      this.balance = this.balance - coffee;
      }
    }
  public void AddMoney(double amount){

      if (this.balance + amount >= 150){
          this.balance = 150;
      } else if (amount < 0) {
          return "Can not add negatives";  
      } else {
          this.balance = this.balance + amount; 
      }
    }  
  }
}
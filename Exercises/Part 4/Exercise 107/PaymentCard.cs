using System;

namespace exercise_107
{
  public class PaymentCard {
      private double balance;

  public PaymentCard (double openingBalance){
      this.balance = openingBalance;
    }
  public override string ToString(){
        return "The card has a balance of " + this.balance + " euros"; 
    }
  }
}
using System; 

namespace exercise_123
{
  public class Counter
  {
    // DO NOT TOUCH THESE VARIABLES
    public int value {get; set;}

    // CREATE YOUR CONSTRUCTORS HERE
    public Counter (int startValue){
        this.value = startValue;
    }

    public Counter (){
        this.value = 0; 
    }

    public void Increase(){
        this.value++;
    }

    public void Increase(int increaseBy){
        this.value += increaseBy;
    }

    public void Decrease(){
        this.value--;
    }

    public void Decrease(int decreaseBy){
        this.value -= decreaseBy;
    }
  }
}    
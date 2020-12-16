using System;

namespace exercise_119
{
  public class Timer
  {
    public int hundredths {get; set;}
    public int seconds {get; set;}

    public Timer()
    {
      this.hundredths = 0;
      this.seconds = 0;
    }

    public void Advance()
    {
      this.hundredths = this.hundredths + 1; 
      
      if (this.hundredths >= 100){
          this.hundredths = 0;
          this.seconds = this.seconds + 1; 
      }
      if (this.seconds >= 60){
          this.seconds = 0; 
      }
    }

    public override string ToString()
    {
      return this.seconds + ":" + this.hundredths; 
    }
  }
}  
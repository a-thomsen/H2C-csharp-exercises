using System;

namespace exercise_120
{
	public class Cube
	{
	  public int edge { get; set; }

	  public Cube(int length){
	    this.edge = length;
	  }

	public int Volume(){
	    int volume = this.edge * this.edge * this.edge;
	    return volume;
	}

	public override string ToString(){
	    return "The length of the edge is " + this.edge + " and the volume is " + this.Volume();
	}
    }
}

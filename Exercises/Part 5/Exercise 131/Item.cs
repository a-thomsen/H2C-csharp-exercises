using System; 

namespace exercise_131
{
  public class Item
  {

    private string identifier;
    private string name;

    public Item(string identifier, string name)
    {
      this.identifier = identifier;
      this.name = name;
    }
    public override string ToString()
    {
      return this.identifier + ": " + this.name;
    }

    //compare with Item.identifier

    public override bool Equals(object compared)
    {
      if (this.identifier == compared.identifier); {
        return true;
      } 
      else {
        return false; 
      }
    }
  }
}
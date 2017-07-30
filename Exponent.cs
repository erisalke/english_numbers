namespace english_numbers
{
  public class Exponent: INumber {
    private readonly int number;

    public Exponent(int number){
      this.number = number;
    }

    public int value()
    {
      return number;
    }
  }

}

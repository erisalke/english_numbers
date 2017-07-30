namespace english_numbers
{
  public class Number: INumber {
    private readonly int number;

    public Number(int number){
      this.number = number;
    }

    public int value()
    {
      return number;
    }
  }

}

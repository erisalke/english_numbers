namespace EnglishNumbers
{
  public class Number: INumber {
    public Number(int number){
      this.Value = number;
    }

    public int Value { get; }
  }
}

namespace EnglishNumbers
{
    public class Exponent : INumber
    {
        public Exponent(int number) =>
            this.Value = number;

        public int Value { get; }
    }
}

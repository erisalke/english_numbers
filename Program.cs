using System;

namespace EnglishNumbers
{
  public class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------
            var sentence = "Five hundred twenty-three million, seven hundred eighteen thousand and ninety-three";
            // ---------------------------

            try {
                var solution = Solver.Run(sentence);

                Console.WriteLine($"Input: \"{sentence}\"");
                Console.WriteLine($"Solution: {solution.ToString("N0")}");
            }
            catch (WordNotFoundException e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

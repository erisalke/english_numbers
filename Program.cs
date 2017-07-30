using System;

namespace english_numbers
{
  class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------
            var sentence = "Five hundred twenty-three million, seven hundred eighteen thousand and ninety-three";
            // ---------------------------

            var solver = new Solver(sentence);
            try {
                var solution = solver.run();

                Console.WriteLine($"Input: \"{sentence}\"");
                Console.WriteLine($"Solution: {solution.ToString("N0")}");
            }
            catch (WordNotFoundException e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

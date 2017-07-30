using System;
using System.Collections.Generic;
using System.Linq;

namespace english_numbers
{
  class Solver {
    private string baseSentence;

    public Solver(string sentence)
    {
      this.baseSentence = sentence;
    }

    internal int run()
    {
      var words = cleanupInput(baseSentence);
      var numbers = wordsToNumbers(words);
      var solution = numbersToSolution(numbers);
      
      return solution;
    }

    private int numbersToSolution(List<INumber> numbers)
    {
      var result = 0;
      var exponent = 1;

      foreach(var number in numbers) {
        if (number is Number) {
          result += number.value() * exponent;
        }

        if (number is Exponent) {
          var newExponent = number.value();
          exponent = (exponent > newExponent)
            ? exponent *= newExponent
            : newExponent;
        }
      }

      return result;
    }

    private List<INumber> wordsToNumbers(string[] words)
    {
      var result = new List<INumber>();

      foreach(var word in words) {
        result.Add(Dictionaries.Translate(word));
      }

      return result;
    }

    private string[] cleanupInput(string baseSentence)
    {
      var delimiters = new [] { ' ', ',', '-' };
      var splittedArray = baseSentence
        .ToLower()
        .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
      var onlyWords = splittedArray.Where(x => x != "and");
      
      return onlyWords.Reverse().ToArray();
    }
  }
}

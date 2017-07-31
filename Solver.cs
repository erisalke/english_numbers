using System;
using System.Collections.Generic;
using System.Linq;

namespace EnglishNumbers
{
    public static class Solver
    {
        public static int Run(string sentence) =>
          sentence
              .ToLower()
              .Split(new[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries)
              .Where(x => x != "and")
              .Reverse()
              .Select(w => Dictionaries.Translate(w))
              .Aggregate((result: 0, exponent: 1),
                ((int result, int exponent) acc, INumber number) =>
                  number is Number 
                    ? (acc.result + number.Value * acc.exponent, acc.exponent)
                    : number is Exponent 
                      ? (acc.result, acc.exponent > number.Value ? acc.exponent * number.Value : number.Value)
                      : acc)
              .result;
    }
}

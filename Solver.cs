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
              .Aggregate((result: 0, exp: 1),
                ((int result, int exp) acc, int number) =>
                  number >= 100
                    ? (acc.result, acc.exp > number ? acc.exp * number : number)
                    : (acc.result + number * acc.exp, acc.exp))
              .result;
    }
}

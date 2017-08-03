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
              .Aggregate(
                (rest: 0, exponent: 1),
                ((int rest, int exponent) acc, int number) =>
                  number < 100
                    ? (number * acc.exponent + acc.rest, acc.exponent)
                    : (acc.rest, number > acc.exponent  ? number : number * acc.exponent))
              .rest;
    }
}

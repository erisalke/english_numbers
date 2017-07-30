using System;
using System.Collections.Generic;
using System.Linq;

namespace english_numbers
{
  public static class Dictionaries {
    public static INumber Translate(string key) {
      var number = Numbers.Where(x => x.Key == key).FirstOrDefault();
      if (number.Key != null) {
        return new Number(number.Value);
      }

      var exponent = Exponents.Where(x => x.Key == key).FirstOrDefault();
      if (exponent.Key != null) {
        return new Exponent(exponent.Value);
      }

      throw new WordNotFoundException(key);
    }

    private static Dictionary<string, int> Numbers {
      get {
        return new Dictionary<string, int> () {
          { "one", 1 },
          { "two", 2 },
          { "three", 3 },
          { "four", 4 },
          { "five", 5 },
          { "six", 6 },
          { "seven", 7 },
          { "eight", 8 },
          { "nine", 9 },
          { "ten", 10 },
          { "eleven", 11 },
          { "twelve", 12 },
          { "thirteen", 13 },
          { "fourteen", 14 },
          { "fifteen", 15 },
          { "sixteen", 16 },
          { "seventeen", 17 },
          { "eighteen", 18 },
          { "nineteen", 19 },
          { "twenty", 20 },
          { "thirty", 30 },
          { "fourty", 40 },
          { "fifty", 50 },
          { "sixty", 60 },
          { "seventy", 70 },
          { "eighty", 80 },
          { "ninety", 90 },
        };
      }
    }

    private static Dictionary<string, int> Exponents {
      get {
        return new Dictionary<string, int> () {
          { "hundred", 100 },
          { "thousand", 1000 },
          { "million", (int)1e6 },
          { "billion", (int)1e9 }
        };
      }
    }
  }
}

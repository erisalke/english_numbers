using System;

namespace EnglishNumbers
{
  internal class WordNotFoundException : Exception
  {
    private readonly string word;

    public WordNotFoundException(string word)
    {
      this.word = word;
    }
    
    public override string ToString() {
      return $"Word \"{word}\" was not found in any dictionary. Check the spelling or fix dictionaries.";
    }
  }
}

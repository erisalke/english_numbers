using System;

namespace english_numbers
{
  internal class WordNotFoundException : Exception
  {
    private string word;

    public WordNotFoundException(string word)
    {
      this.word = word;
    }
    
    public override string ToString() {
      return $"Word \"{word}\" was not found in any dictionary. Check the spelling or fix dictionaries.";
    }
  }
}

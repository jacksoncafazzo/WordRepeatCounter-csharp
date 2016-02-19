using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace WordRepeatDetector
{
  public class RepeatCounter
  {
    public bool CountRepeats(string searchWord, string sentence)
    {
      string[] sentenceArray = Regex.Split(sentence, @"\W+");
      bool yes = false;
      foreach (string word in sentenceArray)
      {
        if (word == searchWord)
        {
          yes = true;
          break;
        }
        else
        {
         yes = false;
        }
      }
      return yes;
    }
  }
}

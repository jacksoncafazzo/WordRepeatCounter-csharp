using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace WordRepeatDetector
{
  public class RepeatCounter
  {
    private string _word;
    private string[] _sentence;
    private int _counter;
    private List<RepeatCounter> _instances = new List<RepeatCounter>(){};

    public RepeatCounter()
    {
      _instances.Add(this);
    }

    public int CountRepeats(string searchWord, string searchSentence)
    {
      _counter = 0;
      _word = searchWord;
      _sentence = Regex.Split(searchSentence, @"\W+");

      bool yes = false;
      foreach (string word in _sentence)
      {
        if (word == searchWord)
        {
          _counter += 1;
        }
      }
      return _counter;
    }
  }
}

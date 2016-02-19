using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace WordRepeatDetector
{
  public class RepeatCounter
  {
    private string _word;
    private string _originalSentence;
    private string[] _sentence;
    private int _counter;
    private List<RepeatCounter> _instances = new List<RepeatCounter>(){};

    public RepeatCounter()
    {
      _instances.Add(this);
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetSentence()
    {
      return _originalSentence;
    }
    public int GetCount()
    {
      return _counter;
    }
    public List<RepeatCounter> GetAll()
    {
      return _instances;
    }

    public int CountRepeats(string searchWord, string searchSentence)
    {
      _counter = 0;
      _word = searchWord;
      _originalSentence = searchSentence;
      _sentence = Regex.Split(searchSentence, @"\W+");

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

using System;
using System.Collections.Generic;
using Xunit;

namespace WordRepeatDetector
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_WillReturn1IfOneMatch_true()
    {
      RepeatCounter model = new RepeatCounter();
      Assert.Equal(1, model.CountRepeats("cats", "i just love cats and their little faces"));
    }
    [Fact]
    public void CountRepeats_WillReturn2IfMatchTwice_true()
    {
      RepeatCounter model = new RepeatCounter();
      Assert.Equal(2, model.CountRepeats("cats", "i just love cats and their cats furriness"));
    }
    [Fact]
    public void CountRepeats_WillReturn3IfMatchingThreeTimes_true()
    {
      RepeatCounter model = new RepeatCounter();
      Assert.Equal(3, model.CountRepeats("coding", "i love surf coding, coding adventures, all coding"));
    }
    [Fact]
    public void RepeatCounterUI_WillCreateAnInstanceListUponCreation_true()
    {
      RepeatCounter model = new RepeatCounter();
      model.CountRepeats("cats", "i just love cats and their little faces");
      List<RepeatCounter> models = new List<RepeatCounter>(){};
      models = model.GetAll();
      Console.WriteLine("You searched for: " + model.GetWord());
      Console.WriteLine("In this sentence: " + model.GetSentence());
      Console.WriteLine("And it matched: " + model.GetCount() + " times");
    }
  }
}

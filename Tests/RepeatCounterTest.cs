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
  }
}

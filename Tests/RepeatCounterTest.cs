using System;
using System.Collections.Generic;
using Xunit;

namespace WordRepeatDetector
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_Will_true()
    {
      RepeatCounter model = new RepeatCounter();
      Assert.Equal(true, model.CountRepeats("cats", "i just love cats and their little faces"));
    }
    [Fact]
    public void CountRepeats_WillReturnTrueIfMatch_true()
    {
      RepeatCounter model = new RepeatCounter();
      Assert.Equal(true, model.CountRepeats("cats", "i just love cats and their furriness"));
    }
  }
}

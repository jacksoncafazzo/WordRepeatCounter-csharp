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
      Assert.Equal(true, model.CountRepeats());
    }
  }
}

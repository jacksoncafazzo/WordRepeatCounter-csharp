using Nancy;
using Nancy.ViewEngines.Razor;
using WordRepeatDetector;
using System;
using System.Collections.Generic;

namespace WordRepeatDetector
{
  public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get["/"] = _ => {
          return View["index.cshtml"];
        };
        Post["/search"] = _ => {
          RepeatCounter model = new RepeatCounter();
          model.CountRepeats(Request.Form["word"], Request.Form["sentence"]);
          List<RepeatCounter> allCounts = new List<RepeatCounter>(){};
          allCounts = RepeatCounter.GetAll();
          return View["result.cshtml", allCounts];
        };
        Post["/boom"] = _ => {
          RepeatCounter model = new RepeatCounter();
          RepeatCounter.ClearAll();
          return View["cleared.cshtml", model];
        };
      }
    }
  }

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
      }
    }
  }

﻿using System;
using System.Linq;

namespace Demo.Refactorings
{
  public class ChangeSignature
  {
    public void A()
    {
      B("best");
      B("nice");
      B("test");
    }

    public void B (string value)
    {
      Console.WriteLine(value);
    }
  }
}
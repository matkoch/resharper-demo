using System;
using System.Linq;

namespace Demo.QuickFixes
{
  public class Basics
  {
    public void A()
    {
      string a = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";

      System.Console.WriteLine(a);
      System.Console.WriteLine(a);

      // Type: var spaceCount = a.Where(x => x == ' ');
    }
  }
}
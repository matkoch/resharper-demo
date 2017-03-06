using System;
using System.Collections.Generic;
using System.Linq;
using Demo.Navigation;
using JetBrains.Annotations;

namespace Demo.Refactorings
{
  public class PostfixTemplates
  {
    // var, SC, ret
    public Car CreateCar (int seats, int maximumVelocity)
    {
      throw new NotImplementedException();
    }

    // foreach, notnull, check seats, yield
    public IEnumerable<IVehicle> GetBigVehicles (IVehicle[] vehicles)
    {
      throw new NotImplementedException();
    }
  }
}
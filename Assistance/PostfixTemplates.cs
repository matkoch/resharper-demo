using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Navigation;
using JetBrains.Annotations;

namespace Demo.Assistance
{
    public class PostfixTemplates
    {
        // new, ret
        public Car CreateCar (int seats, int maximumVelocity)
        {
            throw new NotImplementedException();
        }

        public void UseStringBuilder()
        {
        }

        // foreach, notnull, check seats, yield
        public IEnumerable<IVehicle> GetBigVehicles (IVehicle[] vehicles)
        {
            throw new NotImplementedException();
        }
    }
}

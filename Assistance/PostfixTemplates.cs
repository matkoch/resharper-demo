using System;
using System.Collections.Generic;
using ReSharperDemo.Navigation;

namespace ReSharperDemo.Assistance
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

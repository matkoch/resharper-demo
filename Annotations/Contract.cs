using System;
using JetBrains.Annotations;

namespace Demo.Annotations
{
    public class Contract
    {
        public void Entry ()
        {
            HaltOnNull("key");
            Console.WriteLine("output");
        }

        [ContractAnnotation("null => halt")]
        private void HaltOnNull (string key)
        {
        }
    }
}

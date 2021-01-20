using System;

namespace ReSharperDemo.Annotations
{
    public class ModifiedClosure
    {
        public void M()
        {
            var a = 1;
            N(() => Console.WriteLine(a));

            a = 2;
            Console.WriteLine(a);
        }

        public void N(Action action)
        {
        }
    }
}
using System;
using System.Collections.Generic;

namespace ReSharperDemo.SSR
{
    public class Basic
    {
        public void M(Dictionary<int, int> dictionary, int key)
        {
            if (dictionary.ContainsKey(key))
            {
                var value = dictionary[key];

                var z = value * 5;
                Console.WriteLine(value);
            }
        }
    }
}

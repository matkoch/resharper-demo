using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using Xunit.Sdk;

namespace Demo.QuickFixes
{
    public class Basics
    {
        public void A ()
        {
            string a = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";

            System.Console.WriteLine(a);
            System.Console.WriteLine(a);

            // Type: var spaceCount = a.Where(x => x == ' ');

            var dictionary = new Dictionary<string, string>();
            foreach (var keyValue in dictionary)
            {
                Console.WriteLine(keyValue.Key);
                Console.WriteLine(keyValue.Value);
            }
        }

        public MyEnum GetFlags(int i)
        {
            switch (i)
            {
                case 1: return MyEnum.A;
                case 2: return MyEnum.B;
                default: throw new Exception("message");
            }
        }

        public enum MyEnum
        {
            A,
            B,
            C
        }
    }
}

using System;
using Xunit;

namespace ReSharperDemo.Testing
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var a = 1_000_000 + 2 + 3 * 100;
            A.M();
        }

        [Fact]
        public void Test2()
        {
            B.M();
        }
    }

    public class A
    {
        public static void M ()
        {
            // debug
        }
    }

    public class B
    {
        public static void M ()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine ("1111aasdadssd");
        }
    }
}

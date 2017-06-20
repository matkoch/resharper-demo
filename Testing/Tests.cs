using System;
using System.Threading;
using Xunit;

namespace Demo.Testing
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
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
            Console.WriteLine ("poskdfposdkf");
        }
    }
}

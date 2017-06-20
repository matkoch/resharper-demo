using System.Threading;
using Xunit;

namespace Demo.Testing
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            A.M();
        }

        [Fact]
        public void Teste3242()
        {
            // convenient 
            B.M();
        }
    }


    public class A
    {

        public static void M ()
        {
            Thread.Sleep(millisecondsTimeout: 5000);
        }
    }

    public class B
    {
        public static void M ()
        {
            System.Console.WriteLine ("sodfoskdfp");
        }
    }
}

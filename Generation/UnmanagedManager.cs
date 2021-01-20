using System.Threading;

namespace ReSharperDemo.Generation
{
    // FEAT: Implement IDisposable and Generate Pattern
    public class UnmanagedManager //: IDisposable
    {
        private readonly ManualResetEvent _firstResetEvent;
        private readonly ManualResetEvent _secondResetEvent;
    }
}

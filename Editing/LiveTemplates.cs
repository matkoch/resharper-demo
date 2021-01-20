using ReSharperDemo.Navigation;

namespace ReSharperDemo.Editing
{
    public class LiveTemplates
    {
        public void Test()
        {
        }

        private class SUT
        {
            public IVehicle Vehicle { get; }

            public SUT(IVehicle vehicle)
            {
                Vehicle = vehicle;
            }
        }

        private static T CreateInstance<T>() => default;
    }
}

using System;

namespace ReSharperDemo.Navigation.Test
{
    [Subject(typeof(Car), typeof(Position))]
    public class NavigationIntegrationTest
    {
    }

    public class SubjectAttribute : Attribute
    {
        public SubjectAttribute (params Type[] subjects)
        {
        }
    }
}

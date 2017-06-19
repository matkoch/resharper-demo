using System;
using System.Linq;

namespace Demo.Navigation.Extensions
{
    public static class VehicleExtensions
    {
        public static T Forward<T> (this T vehicle, int xOffset)
            where T : IVehicle
        {
            vehicle.Move(xOffset, yOffset: 0);
            return vehicle;
        }
    }
}

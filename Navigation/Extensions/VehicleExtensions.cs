using System;
using System.Linq;

namespace Demo.Navigation.Extensions
{
    public static class VehicleExtensions
    {
        public static IVehicle Forward (this IVehicle vehicle, int xOffset)
        {
            vehicle.Move(xOffset, yOffset: 0);
            return vehicle;
        }
    }
}

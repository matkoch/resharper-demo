namespace ReSharperDemo.Navigation.Extensions
{
    public static class VehicleExtensions
    {
        public static IVehicle Forward (this IVehicle vehicle, int xOffset)
        {
            vehicle.Move(xOffset, 0);
            return vehicle;
        }
    }
}

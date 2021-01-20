using System;
using ReSharperDemo.Navigation.Extensions;

namespace ReSharperDemo.Navigation.Test
{
    public class VehicleTestsBase
    {
        public void Test ()
        {
            IVehicle car = new Car (4, 250);

            car.Move (50, 0);
            car.Forward (xOffset: 400).Move (new Position (500, 0));

            dynamic dynamicCar = car;
            dynamicCar.Move (1, 2);

            object objectCar = car;
            objectCar.Invoke ("Move", 1, 2);


            Console.WriteLine ($"MaximumVelocity: {car.MaximumVelocity}; Seats: {car.Seats}");
        }
    }
}

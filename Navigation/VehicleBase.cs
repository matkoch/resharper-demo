using System;
using System.Linq;

namespace Demo.Navigation
{
  public abstract class VehicleBase : IVehicle
  {
    protected VehicleBase (int seats, int maximumVelocity)
    {
      // TODO: Check ranges

      Seats = seats;
      MaximumVelocity = maximumVelocity;
    }

    public Position Position { get; private set; }

    public int Seats { get; }

    public int MaximumVelocity { get; }

    public abstract void Move (int xOffset, int yOffset);

    public void Move (Position offset)
    {
      Move(offset.X, offset.Y);
    }
  }
}
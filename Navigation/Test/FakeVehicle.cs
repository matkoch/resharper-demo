using System;
using System.Linq;

namespace Demo.Navigation.Test
{
  public class FakeVehicle : IVehicle
  {
    public int Seats { get; }
    public int MaximumVelocity { get; }
    public Position Position { get; }

    public void Move (int xOffset, int yOffset)
    {
      throw new NotImplementedException();
    }

    public void Move (Position offset)
    {
      throw new NotImplementedException();
    }
  }
}
using System.Collections.Generic;

namespace Ianmann56.Battleship.Game
{
  public enum ShipType
  {
    PatrolBoat = 0,
    Submarine = 1,
    Cruiser = 2,
    Battleship = 3,
    Carrier = 4
  }

  public class Ship
  {
    private static readonly Dictionary<ShipType, int> ShipTypeLengths = new Dictionary<ShipType, int>()
    {
      { ShipType.PatrolBoat, 2 },
      { ShipType.Submarine, 3 },
      { ShipType.Cruiser, 3 },
      { ShipType.Battleship, 4 },
      { ShipType.Carrier, 5 }
    };
    
    public ShipType Type { get; private set; }
    public IEnumerable<Coordinate> Coordinates { get; private set; }
    public int Length => ShipTypeLengths[this.Type];

    public Ship(ShipType type, Coordinate coordinate, Orientation orientation)
    {
      this.Type = type;
      this.Coordinates = coordinate.GetCoordinatesInOrientation(orientation, this.Length);
    }
  }
}
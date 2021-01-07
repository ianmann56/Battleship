using System.Collections.Generic;
using System.Linq;

namespace Ianmann56.Battleship.Game
{
  public struct ShipPlacement
  {
    public Coordinate StartingCoordinate { get; set; }
    public Orientation Orientation { get; set; }
  }
  
  public class Board
  {
    public IEnumerable<Ship> Ships { get; private set; }

    public Board()
    {
      this.Ships = new List<Ship>();
    }

    public void SetShipLocations(
      ShipPlacement patrolBoat,
      ShipPlacement submarine,
      ShipPlacement cruiser,
      ShipPlacement battleship,
      ShipPlacement carrier)
    {
      this.Ships = new List<Ship>()
      {
        new Ship(ShipType.PatrolBoat, patrolBoat.StartingCoordinate, patrolBoat.Orientation),
        new Ship(ShipType.Submarine, submarine.StartingCoordinate, submarine.Orientation),
        new Ship(ShipType.Cruiser, cruiser.StartingCoordinate, cruiser.Orientation),
        new Ship(ShipType.Battleship, battleship.StartingCoordinate, battleship.Orientation),
        new Ship(ShipType.Carrier, carrier.StartingCoordinate, carrier.Orientation)
      };
    }
  }
}
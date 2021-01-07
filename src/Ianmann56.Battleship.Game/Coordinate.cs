using System;
using System.Collections.Generic;

namespace Ianmann56.Battleship.Game
{
  public class Coordinate
  {
    public string Letter { get; private set; }
    public int Number { get; private set; }

    public Coordinate(string letter, int number)
    {
      this.Letter = letter;
      this.Number = number;
    }

    public bool IsSameAs(Coordinate other)
    {
      return this.Letter == other.Letter && this.Number == other.Number;
    }

    public IEnumerable<Coordinate> GetCoordinatesInOrientation(Orientation orientation, int length)
    {
      if (length == 0)
      {
        return Array.Empty<Coordinate>();
      }

      List<Coordinate> coords = new List<Coordinate>() { this };
      for (int i = 1; i < length; i++)
      {
        Coordinate lastCoord = coords[i-1];
        Coordinate nextCoord = lastCoord.GetNextCoordinate(orientation);
        coords.Add(nextCoord);
      }
      return coords;
    }

    private Coordinate GetNextCoordinate(Orientation orientation)
    {
      string letter = this.Letter;
      int number = this.Number;
      if (orientation == Orientation.Horizontal)
      {
        letter = GetNextLetter(letter);
      }
      else
      {
        number = number == 10 ? 1 : number + 1;
      }
      return new Coordinate(letter, number);
    }

    private static string GetNextLetter(string original)
    {
      char originalChar = char.Parse(original);
      if (originalChar == 'j' || originalChar == 'J')
      {
        return "A";
      }
      char nextChar = (char) (((int) originalChar) + 1);
      return nextChar.ToString();
    }
  }
}

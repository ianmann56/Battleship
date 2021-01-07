using System;

namespace Ianmann56.Battleship.Console
{
  public class Program
  {
    public static void Main(string[] args)
    {
      GameController gameController = new GameController();
      gameController.SetupGame();
    }
  }
}

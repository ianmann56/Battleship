using BattleshipGame = Ianmann56.Battleship.Game.Game;

namespace Ianmann56.Battleship.Console
{
  public class GameController
  {
    private BattleshipGame game;

    public void StartGame()
    {

    }

    public void SetupGame()
    {
      string player1Name = this.ReadPlayerName(1);
      string player2Name = this.ReadPlayerName(2);

      this.game = new BattleshipGame(player1Name, player2Name);
    }

    private string ReadPlayerName(int playerNumber)
    {
      System.Console.Write($"Player {playerNumber} name: ");
      string name = System.Console.ReadLine();
      return name;
    }
  }
}
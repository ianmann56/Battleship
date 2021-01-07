using Ianmann56.Battleship.Game;

namespace Ianmann56.Battleship.Console
{
  public class PlayerBoardView
  {
    public Team Team { get; private set; }

    public PlayerBoardView(Team team)
    {
      this.Team = team;
    }
  }
}
namespace Ianmann56.Battleship.Game
{
  public class Team
  {
    public Player Player { get; private set; }
    public Board Board { get; private set; }

    public Team(Player player, Board board)
    {
      this.Player = player;
      this.Board = board;
    }
  }
  
  public class Game
  {
    public Team Team1 { get; private set; }
    public Team Team2 { get; private set; }

    public Game(string player1Name, string player2Name)
    {
      this.Init(player1Name, player2Name);
    }

    private void Init(string player1Name, string player2Name)
    {
      this.Team1 = new Team(
        new Player(player1Name),
        new Board());
      this.Team2 = new Team(
        new Player(player2Name),
        new Board());
    }
  }
}
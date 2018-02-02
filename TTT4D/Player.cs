namespace TTT4D {
  public class Player {
    public string Name{ get; }

    public string Color{ get; }

    public bool IsHuman{ get; }

    public Player(string name, string color, bool isHuman) {
      Name = name;
      Color = color;
      IsHuman = isHuman;
    }
  }
}
namespace TTT4D
{
	public class Match
	{
		public Board CurrentBoard { get; }
		public int CurrentGameturn { get; }

		public Match(Board board)
		{
			CurrentBoard = board ?? new Board();
		}
	}
}
namespace TTT4D
{
	public class MatchResult
	{
		public Match Match { get; }
		public int Winner { get; }

		public MatchResult(Match match, int winner)
		{
			Match = match ?? throw new System.ArgumentNullException(nameof(match));
			Winner = winner;
		}
	}
}
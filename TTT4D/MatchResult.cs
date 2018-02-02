namespace TTT4D
{
	/// <summary>
	/// a summary for a <see cref="Match"/> result.
	/// </summary>
	public class MatchResult
	{
		/// <summary>
		/// <see cref="Match"/> that this class is summarizing.
		/// </summary>
		public Match Match { get; }

		/// <summary>
		/// Gets the index of the winner.
		/// </summary>
		public int Winner { get; }

		/// <param name="match">Match.</param>
		/// <param name="winner">Index of the winner</param>
		public MatchResult(Match match, int winner)
		{
			Match = match ?? throw new System.ArgumentNullException(nameof(match));
			Winner = winner;
		}
	}
}
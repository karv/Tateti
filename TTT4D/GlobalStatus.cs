namespace TTT4D
{
	/// <summary>
	/// A histogram of past (and current) game results.
	/// </summary>
	public class GlobalStatus
	{
		/// <summary>
		/// Gets an array with the game results.
		/// </summary>
		public MatchResult[] GetResultsArray() => _results.ToArray();

		/// <summary/>
		public GlobalStatus()
		{ _results = new System.Collections.Generic.List<MatchResult>(); }

		System.Collections.Generic.List<MatchResult> _results { get; }
	}
}
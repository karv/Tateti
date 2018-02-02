using System;

namespace TTT4D
{
	/// <summary>
	/// Validates <see cref="PlayerAction"/>.
	/// </summary>
	public class MatchMoveValidator
	{
		/// <summary>
		/// Determines whether a player action is valid.
		/// </summary>
		/// <param name="action">Action.</param>
		public bool IsActionValid(PlayerAction action)
		{
			throw new NotImplementedException();
		}

		/// <param name="match">Match.</param>
		public MatchMoveValidator(Match match)
		{
			_match = match;
		}

		readonly Match _match;
	}
}
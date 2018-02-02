using System;

namespace TTT4D
{
	/// <summary>
	/// A game run.
	/// </summary>
	public class Match
	{
		/// <summary>
		/// Gets the board associated to this game instance.
		/// </summary>
		public BoardArray CurrentBoard { get; }
		/// <summary>
		/// Gets the zero-based current turn.
		/// </summary>
		public int CurrentGameturn { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TTT4D.Match"/> class with a specified <see cref="BoardArray"/>.
		/// </summary>
		/// <param name="board">Game Board.</param>
		public Match(BoardArray board)
		{
			CurrentBoard = board ?? throw new ArgumentNullException(nameof(board));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TTT4D.Match"/> class with a new <see cref="BoardArray"/>.
		/// </summary>
		public Match() : this(new BoardArray()) { }
	}
}
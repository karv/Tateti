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
		/// Gets the index of the current player.
		/// </summary>
		public int CurrentPlayerIndex => CurrentGameturn % 2;
		/// <summary>
		/// Gets the current player.
		/// </summary>
		/// <value>The current player.</value>
		public Player CurrentPlayer => _players[CurrentPlayerIndex];

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TTT4D.Match"/> class with a specified <see cref="BoardArray"/>.
		/// </summary>
		/// <param name="board">Game Board.</param>
		/// <param name="player0">The 1st player.</param>
		/// <param name="player1">The 2nd player.</param>
		public Match(BoardArray board, Player player0, Player player1)
		{
			CurrentBoard = board ?? throw new ArgumentNullException(nameof(board));
			_players[0] = player0 ?? throw new ArgumentNullException(nameof(player0));
			_players[1] = player1 ?? throw new ArgumentNullException(nameof(player1));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TTT4D.Match"/> class with a new <see cref="BoardArray"/>.
		/// </summary>
		/// <param name="player0">The 1st player.</param>
		/// <param name="player1">The 2nd player.</param>
		public Match(Player player0, Player player1) : this(new BoardArray(), player0, player1) { }

		/// <summary>
		/// Gets the player with the specified index.
		/// </summary>
		public Player GetPlayerByIndex(int index) => _players[index];
		readonly Player[] _players = new Player[2];
	}
}
namespace TTT4D
{
	/// <summary>
	/// A 3-Dimentional board, as a component of a <see cref="BoardArray"/>.
	/// </summary>
	public class Board
	{
		/// <summary>
		/// Gets the status of a tile.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		public int this[int x, int y, int z] => _boardStatus[x, y, z];

		/// <summary/>
		public Board()
		{
			_boardStatus = new int[BoardSize, BoardSize, BoardSize];
		}

		/// <summary>
		/// The size of the board, in tiles length.
		/// </summary>
		public const int BoardSize = 4;
		int[,,] _boardStatus;
	}
}
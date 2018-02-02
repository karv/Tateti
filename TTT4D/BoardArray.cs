namespace TTT4D
{
	/// <summary>
	/// A full 4-Dimentional matrix representing the state of a run.
	/// </summary>
	public class BoardArray
	{
		/// <summary>
		/// Gets the index of the active <c>Board</c>.
		/// </summary>
		public int CurrentLayer { get; }
		/// <summary>
		/// Gets the <see cref="Board"/> at the specified <c>w</c> value.
		/// </summary>
		/// <param name="w">w value.</param>
		public Board this[int w] => _status[w];

		/// <summary>
		/// Gets the status of a tile.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="w">The w coordinate.</param>
		public int this[int x, int y, int z, int w] => _status[w][x, y, z];

		/// <summary>
		/// Converts bijectively coordinates in this board into a <c>int</c>.
		/// </summary>
		/// <seealso cref="Undigitalize"/>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="z">The z coordinate.</param>
		/// <param name="w">The w coordinate.</param>
		public static int Digitalize(int x, int y, int z, int w)
		{
			const int base_2 = Board.BoardSize * Board.BoardSize;
			const int base_3 = base_2 * Board.BoardSize;
			const int base_4 = base_3 * Board.BoardSize;

			return x + base_2 * y + base_3 * z + base_4 * w;
		}

		/// <summary>
		/// Converts bijectively a <c>int</c> into coordinates.
		/// </summary>
		/// <param name="index">Index.</param>
		public static (int x, int y, int z, int w) Undigitalize(int index)
		{
			(int x, int y, int z, int w) coords;
			coords.x = index % Board.BoardSize;
			index /= Board.BoardSize;
			coords.y = index % Board.BoardSize;
			index /= Board.BoardSize;
			coords.z = index % Board.BoardSize;
			index /= Board.BoardSize;
			coords.w = index % Board.BoardSize;

			return coords;
		}

		/// <summary/>
		public BoardArray()
		{ _status = new Board[Board.BoardSize]; }

		readonly Board[] _status;
	}
}
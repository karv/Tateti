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

		/// <summary/>
		public BoardArray()
		{ _status = new Board[Board.BoardSize]; }

		readonly Board[] _status;
	}
}
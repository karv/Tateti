namespace TTT4D
{
	public class BoardArray
	{
		public int CurrentLayer { get; }
		public Board this[int index] => _status[index];

		public BoardArray()
		{
			_status = new Board[Board.BoardSize];
		}

		Board[] _status;
	}
}
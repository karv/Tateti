namespace TTT4D
{
	public class Board
	{
		public int this[int x, int y, int z] => _boardStatus[x, y, z];

		public Board()
		{
			_boardStatus = new int[BoardSize, BoardSize, BoardSize];
		}

		public const int BoardSize = 4;
		int[,,] _boardStatus;
	}
}
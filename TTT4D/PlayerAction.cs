using System;

namespace TTT4D
{
	/// <summary>
	/// Represents a move of a <see cref="Player"/> in a <see cref="Match"/>.
	/// </summary>
	public struct PlayerAction
	{
		/// <summary>
		/// Gets the player who makes the move.
		/// </summary>
		public Player Actor { get; }
		/// <summary>
		/// Gets the x index of the move.
		/// </summary>
		public int X { get; }
		/// <summary>
		/// Gets the y index of the move.
		/// </summary>
		public int Y { get; }
		/// <summary>
		/// Gets the z index of the move.
		/// </summary>
		public int Z { get; }
		/// <summary>
		/// Gets the w index of the move.
		/// </summary>
		public int W { get; }

		public PlayerAction(Player actor, int x, int y, int z, int w)
		{
			Actor = actor ?? throw new ArgumentNullException(nameof(actor));
			X = x;
			Y = y;
			Z = z;
			W = w;
		}
	}
}
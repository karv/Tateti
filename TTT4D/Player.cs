namespace TTT4D
{
	/// <summary>
	/// General imutable status of a <c>player</c>.
	/// </summary>
	public class Player
	{
		/// <summary>
		/// Gets the name of the player.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Gets a string representing the color of the player
		/// </summary>
		public string Color { get; }

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:TTT4D.Player"/> is human.
		/// </summary>
		/// <value><c>true</c> if this player is human; otherwise, <c>false</c>.</value>
		public bool IsHuman { get; }

		/// <param name="name">Name of the player.</param>
		/// <param name="color">Color of the player.</param>
		/// <param name="isHuman">Set to <c>true</c> if this player is controlled by a human.</param>
		public Player(string name, string color, bool isHuman)
		{
			Name = name;
			Color = color;
			IsHuman = isHuman;
		}
	}
}
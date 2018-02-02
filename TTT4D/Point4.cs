using System;

namespace TTT4D
{
	/// <summary>
	/// A point in <c>int</c>⁴.
	/// </summary>
	public struct Point4 : IEquatable<Point4>
	{
		/// <summary>
		/// The X coordinate.
		/// </summary>
		public int X { get; }
		/// <summary>
		/// The Y coordinate.
		/// </summary>
		public int Y { get; }
		/// <summary>
		/// The Z coordinate.
		/// </summary>
		public int Z { get; }
		/// <summary>
		/// The W coordinate.
		/// </summary>
		public int W { get; }

		public Point4(int x, int y, int z, int w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}
		/// <summary>
		/// Compare to another <see cref="Point4"/>
		/// </summary>
		public bool Equals(Point4 other) => X == other.X && Y == other.Y && Z == other.Z && W == other.W;
		/// <summary>
		/// Compare to another <see cref="Point4"/>
		/// </summary>
		public override bool Equals(object obj) => obj is Point4 other && Equals(other);
		/// <summary>
		/// Serves as a hash function for a <see cref="Point4"/> object.
		/// </summary>
		public override int GetHashCode() => (X ^ Y) ^ (Z ^ W);
		/// <summary>
		/// Compares two <see cref="Point4"/>
		/// </summary>
		public static bool operator ==(Point4 left, Point4 right) => left.Equals(right);
		/// <summary>
		/// Compares two <see cref="Point4"/>
		/// </summary>
		public static bool operator !=(Point4 left, Point4 right) => !(left == right);

		public static Point4 Zero { get; }
		static Point4()
		{
			Zero = new Point4(0, 0, 0, 0);
		}

	}
}
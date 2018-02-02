using System;

namespace TTT4D
{
	/// <summary>
	/// A point in <c>int</c>³.
	/// </summary>
	public struct Point3 : IEquatable<Point3>
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

		public Point3(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		/// <summary>
		/// Compare to another <see cref="Point3"/>
		/// </summary>
		public bool Equals(Point3 other) => X == other.X && Y == other.Y && Z == other.Z;
		/// <summary>
		/// Compare to another <see cref="Point3"/>
		/// </summary>
		public override bool Equals(object obj) => obj is Point3 other && Equals(other);
		/// <summary>
		/// Serves as a hash function for a <see cref="T:TTT4D.Point3"/> object.
		/// </summary>
		public override int GetHashCode() => X ^ Y ^ Z;
		/// <summary>
		/// Compares two <see cref="Point3"/>
		/// </summary>
		public static bool operator ==(Point3 left, Point3 right) => left.Equals(right);
		/// <summary>
		/// Compares two <see cref="Point3"/>
		/// </summary>
		public static bool operator !=(Point3 left, Point3 right) => !(left == right);

		public static Point3 Zero { get; }
		static Point3()
		{
			Zero = new Point3(0, 0, 0);
		}
	}
}
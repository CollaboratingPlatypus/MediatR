using System;

namespace MediatR
{
    /// <summary>
    ///     Represents a Void type, since Void is not a valid type in C#
    /// </summary>
    public sealed class Unit : IComparable
    {
        /// <summary>
        ///     Default and only value of Unit type
        /// </summary>
        public static readonly Unit Value = new Unit();

        int IComparable.CompareTo(object obj)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return obj == null || obj is Unit;
        }
    }
}
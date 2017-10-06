using System;

namespace SortingTests
{
    internal class Comparable : IComparable, IEquatable<IComparable>
    {
        public double Value { get; }

        public Comparable(double value)
        {
            Value = value;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            if (!(obj is Comparable other))
            {
                throw new ArgumentException("Invalid parameter type");
            }
            return Value.CompareTo(other.Value);
        }

        public bool Equals(IComparable other)
        {
            if (other == null)
            {
                return false;
            }
            if (!(other is Comparable otherComparable))
            {
                return false;
            }
            return Value.Equals(otherComparable.Value);
        }
    }
}
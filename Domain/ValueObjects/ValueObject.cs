namespace Domain.ValueObjects
{
    /// <summary>
    /// the ValueObject<T> class is a generic class that takes a type parameter T which should be the class that inherits from ValueObject<T>. In other words, T is the derived class that inherits from the base ValueObject<T> class, so the derived class is essentially inheriting from itself. This allows each derived class to define its own set of equality components that are used to determine if two instances of the class are equal.
    /// </summary>
    /// <typeparam name="T"></typeparam>
  public abstract class ValueObject<T> where T : ValueObject<T>
    {
        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is T other))
            {
                return false;
            }

            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Aggregate(1, (current, obj) => current * 23 + (obj?.GetHashCode() ?? 0));
        }

        public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            {
                return true;
            }

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
        {
            return !(a == b);
        }
    }
}

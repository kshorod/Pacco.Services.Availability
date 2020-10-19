using System;

namespace Pacco.Services.Availability.Core.ValueObjects
{
    public struct Reservation : IEquatable<Reservation>
    {
        public DateTime DateTime { get; }
        public int Priority { get; }

        public Reservation(DateTime dateTime, int priority)
        {
            DateTime = dateTime;
            Priority = priority;
        }

        public bool Equals(Reservation other)
        {
            return DateTime.Equals(other.DateTime) && Priority == other.Priority;
        }

        public override bool Equals(object obj)
        {
            return obj is Reservation other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DateTime, Priority);
        }
    }
}
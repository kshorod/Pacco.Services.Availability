using System;

namespace Pacco.Services.Availability.Core.Exceptions
{
    public class CannotExpropriateReservationException : DomainException
    {
        public Guid ResourceId { get; }
        public DateTime DateTime { get; }

        public CannotExpropriateReservationException(Guid resourceId, DateTime dateTime) : base($"Cannot expropriate resource: {resourceId} reservation at: {dateTime}.")
        {
            ResourceId = resourceId;
            DateTime = dateTime;
        }

        public override string Code => "cannot_expropriate_reservation";
    }
}
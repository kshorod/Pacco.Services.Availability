using System;

namespace Pacco.Services.Availability.Application.Exceptions
{
    public class ResourceNotFoundException : AppException
    {
        public Guid ResourceId { get; }

        public ResourceNotFoundException(Guid resourceId) : base($"Resource with id: {resourceId} was not found.")
        {
            ResourceId = resourceId;
        }

        public override string Code => "resource_not_found";
    }
}
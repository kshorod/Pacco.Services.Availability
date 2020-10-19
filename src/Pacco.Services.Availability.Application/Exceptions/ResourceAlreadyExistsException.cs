using System;

namespace Pacco.Services.Availability.Application.Exceptions
{
    public class ResourceAlreadyExistsException : AppException
    {
        public ResourceAlreadyExistsException(Guid resourceId) : base($"Resource with id: {resourceId} already exsits.")
        {
            ResourceId = resourceId;
        }

        public Guid ResourceId { get; }
        public override string Code => "resource_already_exists";
    }
}
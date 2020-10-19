namespace Pacco.Services.Availability.Core.Exceptions
{
    public class InvalidResourceTagsException : DomainException
    {
        public InvalidResourceTagsException() : base("Resource tags are invalid.")
        {
        }

        public override string Code => "invalid_resource_tags";
    }
}
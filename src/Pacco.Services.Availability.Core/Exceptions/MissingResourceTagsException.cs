namespace Pacco.Services.Availability.Core.Exceptions
{
    public class MissingResourceTagsException : DomainException
    {
        public MissingResourceTagsException() : base("Resource tags are missing.")
        {
        }

        public override string Code => "missing_resource_tags";
    }
}
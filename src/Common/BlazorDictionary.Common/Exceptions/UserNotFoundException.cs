using BlazorDictionary.Common.Exceptions.Base;
using System.Runtime.Serialization;

namespace BlazorDictionary.Common.Exceptions
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException()
        {
        }

        public UserNotFoundException(string? message) : base(message)
        {
        }

        public UserNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UserNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

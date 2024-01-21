using BlazorDictionary.Common.Exceptions.Base;
using System.Runtime.Serialization;

namespace BlazorDictionary.Common.Exceptions
{
    public class UserEmailNotConfirmedException : ConditionsNotProvidedException
    {
        public UserEmailNotConfirmedException()
        {
        }

        public UserEmailNotConfirmedException(string? message) : base(message)
        {
        }

        public UserEmailNotConfirmedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UserEmailNotConfirmedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

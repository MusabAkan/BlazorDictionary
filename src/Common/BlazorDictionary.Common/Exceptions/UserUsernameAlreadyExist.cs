﻿using BlazorDictionary.Common.Exceptions.Base;
using System.Runtime.Serialization;

namespace BlazorDictionary.Common.Exceptions
{
    public class UserUsernameAlreadyExist : AlreadyExistException
    {
        public UserUsernameAlreadyExist()
        {
        }

        public UserUsernameAlreadyExist(string? message) : base(message)
        {
        }

        public UserUsernameAlreadyExist(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UserUsernameAlreadyExist(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

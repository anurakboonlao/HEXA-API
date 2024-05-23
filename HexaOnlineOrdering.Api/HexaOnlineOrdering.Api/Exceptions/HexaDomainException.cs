using System;
namespace HexaOnlineOrdering.Api.Exceptions
{
    public class HexaDomainException : Exception
    {
        public HexaDomainException()
        {
        }

        public HexaDomainException(string message) : base(message)
        {
        }

        public HexaDomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

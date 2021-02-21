namespace Telephony.Exceptions
{
    using System;
    public class InvalidNumberException : Exception
    {
        private const string invalidNumberMSG = "Invalid number!";
        public InvalidNumberException() : base(invalidNumberMSG)
        {

        }
        public InvalidNumberException(string message) : base(message)
        {

        }
    }
}

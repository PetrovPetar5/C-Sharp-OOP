namespace Telephony.Exceptions
{
    using System;

    public class InvalidURLException : Exception
    {
        private const string invalidURLMSG = "Invalid URL!";
        public InvalidURLException() : base(invalidURLMSG)
        {

        }

        public InvalidURLException(string message) : base(message)
        {

        }
    }
}

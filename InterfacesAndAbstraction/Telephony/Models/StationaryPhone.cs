namespace Telephony.Models
{
    using System.Text.RegularExpressions;
    using Telephony.Contracts;
    using Exceptions;
    public class StationaryPhone : IPhonable
    {
        public string call(string numberToDial)
        {
            string numberPattern = @"[0-9]+$";
            var numberRegex = new Regex(numberPattern);
            if (!numberRegex.IsMatch(numberToDial))
            {
                throw new InvalidNumberException();
            }

            return $"Dialing... {numberToDial}";
        }
    }
}

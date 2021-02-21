namespace Telephony.Models
{
    using System.Text.RegularExpressions;
    using Telephony.Contracts;
    using Telephony.Exceptions;
    using System.Linq;
    public class Smartphone : IPhonable, IBrowsable
    {
        public string Browse(string siteToVisit)
        {
            //string webPattern = @"^[^0-9]+$";
            //var webRegex = new Regex(webPattern);
            if (siteToVisit.Any(c => char.IsDigit(c)))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {siteToVisit}!";
        }

        public string call(string numberToDial)
        {
            //string numberPattern = @"[0-9]+$";
            //var numberRegex = new Regex(numberPattern);
            if (!numberToDial.All(d => char.IsDigit(d)))
            {
                throw new InvalidNumberException();
            }

            return $"Calling... {numberToDial}";
        }
    }
}

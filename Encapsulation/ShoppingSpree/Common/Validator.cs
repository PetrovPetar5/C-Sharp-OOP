namespace ShoppingSpree.Common
{
    using System;
    public static class Validator
    {
        public static void NameValidator(string value)
        {
            if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
            {
                throw new ArgumentException(GlobalConstants.NameExceptionMessage);
            }
        }
        public static void MoneyValidator(decimal value)
        {
            if (value < GlobalConstants.MoneyMinValue)
            {
                throw new ArgumentException(GlobalConstants.MoneyExceptionMessage);
            }
        }
    }
}

namespace PO8_Hospital.Global
{
    using System;
    public static class NameValidator
    {
        public static bool ValidateName(string name, int maxLength)
        {
            if (!(name.Length > 1 && name.Length < maxLength))
            {
                throw new ArgumentException("Name cannot be less than 1 symbol and longer than 19 symbols");
            }

            return true;
        }
    }
}

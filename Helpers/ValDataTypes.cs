using System;
using System.Text.RegularExpressions;

namespace ParserAPI.Helpers
{
    public static class ValDataTypes
    {
        public static bool ValInt(string value)
        {
            return int.TryParse(value, result: out _);
        }

        public static bool ValCurrency(string value)
        {
            Regex regex = new Regex(@"^\$?(\d{1,3}(\,\d{3})*|(\d+))(\.\d{0,2})?$");
            return regex.IsMatch(value);
        }
        public static bool ValNumeric(string value)
        {
            return Decimal.TryParse(value, out _);

           
        }
        public static bool ValDateTime(string value)
        {
            return DateTime.TryParse(value, out _);
        }

        public static bool Numeric(string value)
        {
           return Double.TryParse(value, out _);
         }
    }
}

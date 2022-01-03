using static ParserAPI.Helpers.EnumValues;

namespace ParserAPI.ParserText
{
    public static class ValidateField //: IValidateField
    {
       public static bool ValidateDataTypeField(string FieldValue, string dataType)
        {
            if (dataType  == "Integer")
            {
               return !Helpers.ValDataTypes.ValInt(FieldValue);
            }
            if (dataType == "Datetime")
            {
               return !Helpers.ValDataTypes.ValDateTime(FieldValue);
            }
            if (dataType == "Numeric")
            {
               return !Helpers.ValDataTypes.ValNumeric(FieldValue);
            }
            if (dataType == "Money")
            {
                return !Helpers.ValDataTypes.ValCurrency(FieldValue);
            }
            return false;
        }
    }
}

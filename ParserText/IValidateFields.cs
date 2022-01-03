using static ParserAPI.Helpers.EnumValues;

namespace ParserApi.ParserText
{

    public interface IValidateField
    {
        public bool ValidateDataTypeField(string FieldValue, FieldDataType dataType);
    }
}

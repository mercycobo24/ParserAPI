namespace ParserAPI
{
    public interface IParsingField
    {
        string DataType { get; set; }
        int Length { get; set; }
        int Position { get; set; }
    }
}
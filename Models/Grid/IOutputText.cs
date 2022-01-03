namespace ParserAPI.Models
{
    public interface IOutputText
    {
        string ColumnText { get; set; }
        bool IncorrectDataType { get; set; }
    }
}
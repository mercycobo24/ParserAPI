namespace ParserAPI.Models
{
    public interface IColumnLayoutDTO
    {
        string Caption { get; set; }
        int ColumnNumber { get; set; }
        string Datatype { get; set; }
        string InitialPosition { get; set; }
        string Length { get; set; }
    }
}
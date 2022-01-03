using ParserAPI.Models;

namespace ParserAPI
{
    public class OutputText : IOutputText
    {
        public string ColumnText { get; set; }
        public bool IncorrectDataType { get; set; }
    }
}

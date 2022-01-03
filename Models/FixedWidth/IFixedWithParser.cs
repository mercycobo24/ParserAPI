using System.Collections.Generic;

namespace ParserAPI.Models
{
    public interface IFixedWithParser
    {
        List<ColumnLayoutDTO> ColumnsLayout { get; set; }
        List<string> TextToParse { get; set; }
    }
}
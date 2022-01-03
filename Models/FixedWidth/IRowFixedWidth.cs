using ParserAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParserAPI
{
    public interface IRowFixedWidth
    {
        List<ColumnLayoutDTO> ColumnsLayout { get; set; }
        List<string> Text { get; set; }
        Task<List<OutputText>> GetTextColumns(string line);
    }
}
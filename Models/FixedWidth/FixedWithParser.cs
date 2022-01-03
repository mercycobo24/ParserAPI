using MediatR;
using System.Collections.Generic;

namespace ParserAPI
{
    public class FixedWithParser : IRequest<GridDataResponse>
    {
        public List<Models.ColumnLayoutDTO> ColumnsLayout { get; set; }
        public List<string> TextToParse { get; set; }
    }
}


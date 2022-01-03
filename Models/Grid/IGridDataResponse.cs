using System.Collections.Generic;

namespace ParserAPI
{
    public interface IGridDataResponse
    {
        List<OutputText>[] Rows { get; set;   }
    }
}
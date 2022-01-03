using System.Collections.Generic;

namespace ParserAPI
{
    public  class GridDataResponse : IGridDataResponse
    {
        public List<OutputText>[] Rows { get; set; }
    }
}



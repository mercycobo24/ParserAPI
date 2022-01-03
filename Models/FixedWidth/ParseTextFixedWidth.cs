using ParserAPI.Models;
using ParserAPI.Models.Grid;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParserAPI
{
    public class ParseTextFixedWidth : IParseText
    {
        readonly RowFixedWidth _rowFixWidth;
      
        public ParseTextFixedWidth(ServiceFactory serviceFactory)
        {
            _rowFixWidth = (RowFixedWidth)serviceFactory.GetInstance<IRowFixedWidth>();
        }
        public FixedWithParser Request { get; set; }
        public async Task<GridDataResponse> GetRows()
        {
            List<OutputText>[] outputTexts = GridDataFactory.CreateGridOuput(Request.TextToParse.Count);
            _rowFixWidth.ColumnsLayout = Request.ColumnsLayout;
            for (int i = 0; i < Request.TextToParse.Count; i++)
            {
                //  List<OutputText> row = _rowFixWidth.GetTextColumns(Request.TextToParse[i]);
                
                outputTexts[i] = await _rowFixWidth.GetTextColumns(Request.TextToParse[i]);
            }
            GridDataResponse gridDataResponse = GridDataFactory.CreateGridDataResponse();
            gridDataResponse.Rows = outputTexts;
            return gridDataResponse;
        }
    }
}

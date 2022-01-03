using System.Threading.Tasks;
using MediatR;
using System.Threading;
using ParserAPI;
using ParserAPI.Models.Grid;

namespace ParserAPI.Handlers
{
    public class FixedWidthHandler : IRequestHandler<FixedWithParser, GridDataResponse>
    {
        readonly ParseTextFixedWidth _parseText;
        public FixedWidthHandler(ParserAPI.ServiceFactory serviceFactory)
        {
            _parseText = (ParseTextFixedWidth)serviceFactory.GetInstance<IParseText>();
        }
        public async Task<GridDataResponse> Handle(FixedWithParser request, CancellationToken cancellationToken)
        {
            _parseText.Request = request;
            return await _parseText.GetRows();
        }
    }
}

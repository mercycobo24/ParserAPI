using System.Threading.Tasks;

namespace ParserAPI
{
    public interface IParseText
    {
        Task<GridDataResponse> GetRows();


    }
}

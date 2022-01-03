using System.Collections.Generic;

namespace ParserAPI.Models.Grid
{
    public static class GridDataFactory
    {
        public static List<OutputText>[] CreateGridOuput(int dim)
        {
            return new List<OutputText>[dim];
        }

        public static GridDataResponse CreateGridDataResponse()
        {
            return new GridDataResponse();
        }
    }
}

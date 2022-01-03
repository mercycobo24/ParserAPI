using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParserAPI
{
    public class ParsingField : IParsingField
    {
        public int Position { get; set; }
        public int Length { get; set; }
        public string DataType { get; set; }
        public ParsingField(int pPosition, int pLength)
        {
            Position = pPosition - 1; //the  -1 is to converte it to 0 base for the array
            Length = pLength;
          //  DataType = pDataType;
        }
     }
}

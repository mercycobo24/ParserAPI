using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParserAPI.Models
{
    public class ColumnLayoutDTO : IColumnLayoutDTO
    {
        public int ColumnNumber { get; set; }
        public string InitialPosition { get; set; }
        public string Length { get; set; }
        public string Caption { get; set; }
        public string Datatype { get; set; }
    }
}

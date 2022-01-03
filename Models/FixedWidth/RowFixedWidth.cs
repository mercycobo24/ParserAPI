using ParserAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Security.Cryptography;
using ParserAPI.ParserText;

namespace ParserAPI
{
    public class RowFixedWidth : IRowFixedWidth
    {
        public List<ColumnLayoutDTO> ColumnsLayout { get; set; }
        public List<string>  Text { get; set; }
        
        public async  Task<List<OutputText>> GetTextColumns(string line)
        {
            List<OutputText> lines = await GetLineColumns(line, ColumnsLayout);
             for (int i=0; i<lines.Count; i++)
            {
                
                lines[i].IncorrectDataType = ValidateField.ValidateDataTypeField(lines[i].ColumnText, ColumnsLayout[i].Datatype);
            }

            return lines;// GetLineColumns(line, ColumnsLayout);
         }

        private  async Task<List<OutputText>> GetLineColumns(string line, List<Models.ColumnLayoutDTO> columnsLayout)
        {
            ParsingField[] _pFields = new ParsingField[columnsLayout.Count()];
            List<OutputText> rowColumns;
            for (int j = 0; j < columnsLayout.Count(); j++)
            {
                _pFields[j] = new ParsingField(int.Parse(columnsLayout[j].InitialPosition), int.Parse(columnsLayout[j].Length));
            }
            rowColumns = AsFixed(line, _pFields);
            return rowColumns;
        }


        private List<OutputText> AsFixed(string s, params ParsingField[] widths)
        {
            try
            {
                var columns = new string[widths.Length];
                List<OutputText> colsData = new List<OutputText>();
                int i = 0;
                string columnText = "";
                for (; i < widths.Length; i++)
                {
                    if (s.Length < widths[i].Position)
                        columnText = "";
                    else if (s.Length < widths[i].Position + widths[i].Length)
                        columnText = s.Substring(widths[i].Position);
                    else
                    {
                        columnText = s.Substring(widths[i].Position, widths[i].Length);
                    }
                    colsData.Add(new OutputText { ColumnText = columnText });
                }
                return colsData;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message));
            }
        }
    }
}

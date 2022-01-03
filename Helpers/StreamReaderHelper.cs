using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ParserAPI.Helpers
{
    public static class StreamReaderHelper
    {
        public static IEnumerable<string[]> AsDelimited(this IEnumerable<string> strings, params char[] separators)
        {
            foreach (var line in strings.AsEnumerable())
            {
                yield return line.Split(separators);
            }
        }

        public static IEnumerable<string[]> AsFixed(this IEnumerable<string> strings, params ParsingField[] widths)
        {
            foreach (var s in strings.AsEnumerable())
            {
                yield return s.AsFixed(widths);
            }
        }

        public static IEnumerable<string[]> Where(this IEnumerable<string> strings, params ParsingField[] widths)
        {
            foreach (var s in strings.AsEnumerable())
            {
                yield return s.AsFixed(widths);
            }
        }

        public static string[] AsFixed(this string s, params ParsingField[] widths)
        {
            var columns = new string[widths.Length];
            int i = 0;
            for (; i < widths.Length; i++)
            {
                if (s.Length < widths[i].Position)
                    columns[i] = "";
                else if (s.Length < widths[i].Position + widths[i].Length)
                    columns[i] = s.Substring(widths[i].Position);
                else columns[i] = s.Substring(widths[i].Position, widths[i].Length);
            }
            return columns;
        }

        public static List<string> GetPartialReader(this StreamReader reader, int skip, int taken)
        {
            List<string> list = new List<string>();
            string line;
            int counter = 0;
            int takenCounter = 0;

            while ((line = reader.ReadLine()) != null)
            {
                counter++;

                if (counter > skip)
                {
                    list.Add(line);
                    takenCounter++;
                    if (takenCounter >= taken)
                    {
                        return list;
                    }

                }
            }
            return list;
        }
    }

    public class ParsingFieldaaa
    {
        public int Position { get; set; }
        public int Length { get; set; }
        public string DataType { get; set; }
        public ParsingFieldaaa(int pPosition, int pLength, string pDataType)
        {
            Position = pPosition - 1; //the  -1 is to converte it to 0 base for the array
            Length = pLength;
            DataType = pDataType;
        }
    }
}

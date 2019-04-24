using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public static class StringAdder
    {
        public static int SumString(string s)
        {
            return ParseString(s).ToArray().Sum();
        }

        public static List<int> ParseString(string s)
        {
            return Array.ConvertAll(s.Split(','), int.Parse).ToList();
        }

        public static string PreParseString(string s)
        {
            return null;
        }

        

        
    }
}

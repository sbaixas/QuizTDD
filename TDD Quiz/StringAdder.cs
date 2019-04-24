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
            return RemoveNegatives(ParseString(s)).ToArray().Sum();
        }

        public static List<int> ParseString(string s)
        {
            return Array.ConvertAll(PreParseString(s).Split(','), int.Parse).ToList();
        }

        public static string PreParseString(string s)
        {
            return !char.IsDigit(s.ToCharArray()[0]) ? s.Substring(1, s.Length - 1).Replace(s.ToCharArray()[0], ',') : s;
        }

        public static List<int> RemoveNegatives(List<int> list)
        {
            for(int i = 0; i < list.Count; i++) {
                if (list[i] < 0){
                    list[i] = 0;
                }
            }
            return list;
        }
    }
}

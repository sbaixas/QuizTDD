using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public static class StringAdder
    {
        public static List<int> ParseString(string s)
        {
            return Array.ConvertAll(s.Split(','), int.Parse).ToList();
        }

        public static int SumString(string s)
        {
            int result = 0;
            foreach(int i in ParseString(s))
            {
                result += i;
            }
            return result;
        }
    }
}

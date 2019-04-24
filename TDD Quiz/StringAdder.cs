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
            string[] splitedString = s.Split(',');
            return Array.ConvertAll<string,int>(splitedString, int.Parse).ToList<int>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinq.Extensions
{
    public static class ExtensionsMethods
    {
        public static int CountSymbols(this string s)
        {
            return s.Length;
        }
    }
}

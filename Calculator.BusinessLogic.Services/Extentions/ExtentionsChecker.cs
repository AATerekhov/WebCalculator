using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services.Extentions
{
    public static class ExtentionsChecker
    {
        public static char[] brackets = new char[] { '(', ')' };
        public static char[] operators = new char[] { '+', '-', '*', '/' };
        public static char[] seporators = new char[] { '.' };

        public static char[] GetAllSymbols() 
        {
            var result = new List<char>();
            result.AddRange(brackets);
            result.AddRange(operators);
            result.AddRange(seporators);
            return result.ToArray();
        }

        public static bool Appertain(this char[] chars, char value) 
        {
            if (chars.Count(x => x == value) > 0) return true;
            else return false;
        }
    }
}

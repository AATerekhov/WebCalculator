using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services.Extentions
{
    public static class ExtentionsChecker
    {
        static char[] brackets = new char[] { '(', ')' };
        static char[] operators = new char[] { '+', '-', '*', '/' };
        static char[] seporators = new char[] { '.' };
        public static bool CheckingNumberOfBrackets(this string value) 
        {           
            if (value.Count(x => x == brackets[0]) == value.Count(x => x == brackets[1])) return true;
            else return false;            
        }
        public static bool CheckingForAnOperation(this string value)
        {
            foreach (var oper in operators)
            {
                if (value.Count(x => x == oper) > 0) return true;               
            }
            return false;
        }
        public static bool CheckingForNumbers(this string value)
        {
            if (value.Count(predicate: char.IsLetter) > 0) return false;
            return true;
        }
        public static bool CheckingForUndefinedСharacters(this string value)
        {
            string result = string.Empty;
            result = new string((from c in value
                                 where !brackets.Appertain(c) &&
                                       !operators.Appertain(c) &&
                                       !seporators.Appertain(c) &&
                                       !char.IsNumber(c)
                                 select c).ToArray());
            if (result.Length > 0) return false;
            else return true;
        }

        static bool Appertain(this char[] chars, char value) 
        {
            if (chars.Count(x => x == value) > 0) return true;
            else return false;
        }
    }
}

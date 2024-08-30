using Calculator.BusinessLogic.Services.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services.Check
{
    public class CheckNumberOfBrackets:BaseCheck
    {
        public CheckNumberOfBrackets():base()
        {
           
        }
        public new bool Handle(string value)
        {
            if (value.Count(x => x == ExtentionsChecker.brackets[0]) == value.Count(x => x == ExtentionsChecker.brackets[1])) return base.Handle(value);
            else return false;
        }
    }
}

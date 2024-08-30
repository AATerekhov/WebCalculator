using Calculator.BusinessLogic.Services.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services.Check
{
    public class CheckForUndefinedСharacters:BaseCheck
    {
        public CheckForUndefinedСharacters():base()
        {
                
        }
        public new bool Handle(string value)
        {
            string result = string.Empty;
            result = new string((from c in value
                                 where !ExtentionsChecker.GetAllSymbols().Appertain(c) &&
                                       !char.IsNumber(c)
                                 select c).ToArray());
            if (result.Length > 0) return false;
            else return base.Handle(value);
        }
    }
}

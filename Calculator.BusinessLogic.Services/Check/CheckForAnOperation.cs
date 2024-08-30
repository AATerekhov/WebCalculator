using Calculator.BusinessLogic.Services.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services.Check
{
    public class CheckForAnOperation : BaseCheck
    {
        public CheckForAnOperation():base()
        {                
        }
        public new bool Handle(string value) 
        {
            foreach (var oper in ExtentionsChecker.operators)
            {
                if (value.Count(x => x == oper) > 0) return base.Handle(value);
            }
            return false;
        }
    }
}

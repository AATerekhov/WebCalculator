using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services.Check
{
    public class CheckForNumbers:BaseCheck
    {
        public CheckForNumbers():base()
        {
                
        }
        public new bool Handle(string value)
        {
            if (value.Count(predicate: char.IsLetter) > 0) return false;
            return base.Handle(value);
        }
    }
}

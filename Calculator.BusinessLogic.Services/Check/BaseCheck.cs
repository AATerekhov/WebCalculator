using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services.Check
{
    public class BaseCheck : IBaseCheck
    {
        private IBaseCheck? _next;
        public bool Handle(string value)
        {
            if (_next != null)
            {
                return _next.Handle(value);
            }
            else return true;
        }

        public void SetNext(IBaseCheck next)
        {
            _next = next;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator.BusinessLogic.Services.Check
{
    public interface IBaseCheck
    {
        public void SetNext(IBaseCheck next);

        public bool Handle(string value);
    }
}

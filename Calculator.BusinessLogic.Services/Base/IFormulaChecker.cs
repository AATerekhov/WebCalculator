using Calculator.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services.Base
{
    public interface IFormulaChecker
    {
        Task<bool> Check(FormulaModel formulaModel);
    }
}

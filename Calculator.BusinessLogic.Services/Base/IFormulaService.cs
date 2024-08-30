using Calculator.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services.Base
{
    public interface IFormulaService
    {
        Task<AnswerModel> SolveFormula(FormulaModel formulaModel);
    }
}

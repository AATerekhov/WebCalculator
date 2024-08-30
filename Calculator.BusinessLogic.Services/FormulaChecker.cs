using Calculator.BusinessLogic.Models;
using Calculator.BusinessLogic.Services.Base;
using Calculator.BusinessLogic.Services.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic.Services
{
    public class FormulaChecker : IFormulaChecker
    {
        public async Task<bool> Check(FormulaModel formulaModel)
        {
            var value = formulaModel.Value.Replace(" ", string.Empty);
            if (!value.CheckingNumberOfBrackets() ||
                !value.CheckingForAnOperation() ||
                !value.CheckingForNumbers() ||
                !value.CheckingForUndefinedСharacters()
                ) return false;
            else return true;
        }
    }
}

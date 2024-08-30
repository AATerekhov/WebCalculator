using AutoMapper;
using Calculator.BusinessLogic.Models;
using Calculator.BusinessLogic.Services.Base;

namespace Calculator.BusinessLogic.Services
{
    public class FormulaService(IFormulaChecker formulaChecker) : IFormulaService
    {
        public async Task<AnswerModel> SolveFormula(FormulaModel formulaModel)
        {
            var chackresult = await formulaChecker.Check(formulaModel);
            if (!chackresult) throw new FormatException("Formula entry error");
            return new AnswerModel() { Value = 100.5 };
        }
    }
}

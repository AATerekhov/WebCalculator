using Calculator.BusinessLogic.Models;
using Calculator.BusinessLogic.Services;
using Calculator.BusinessLogic.Services.Base;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{
    public class FormulaCheckerTests
    {
        IFormulaChecker _formulaChecker;
        public FormulaCheckerTests() 
        {
            _formulaChecker = new FormulaChecker(); 
        }

        [Theory]
        [InlineData("",false)]
        [InlineData("10* (5+5)",true)]
        [InlineData("10. 5", false)]
        [InlineData("asd/qwe",false)]
        [InlineData("10*(5 ",false)]
        [InlineData("10^(5-10)+(20+5*2)^0.5", false)]
        public async Task Validate_Formula_Value(string value, bool expectedValue) 
        {
            //Arragne
            var formula = new FormulaModel() { Value = value };
            //Act
            var result = await _formulaChecker.Check(formula);
            //Assert
            Assert.Equal(expectedValue,result);
        }

    }
}

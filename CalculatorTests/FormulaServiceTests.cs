using Calculator.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCalculator.Requests;
using Calculator.BusinessLogic.Services.Base;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using Calculator.BusinessLogic.Models;

namespace CalculatorTests
{
    public class FormulaServiceTests
    {
        private readonly IFormulaService _formulaService;

        public static readonly IEnumerable<object[]> FormulaData = new List<object[]>()
        {
            new object []
            {
                new List<FormulaModel>()
                {
                    new()
                    {
                        Value = "5/2+10/2"
                    },
                    new()
                    {
                        Value = "10-5.5"
                    }
                }
            },
            new object []
            {
                new List<AnswerModel>()
                {
                    new()
                    {
                        Value = 7.5
                    },
                    new()
                    {
                        Value = 4.5
                    }
                }
            }
        };

        public FormulaServiceTests() 
        {

            _formulaService = new FormulaService(new FormulaChecker());
        }

        [Fact]
        public async Task Formula_Should_Be_Null()
        {
            //Arrange
            var formula = new FormulaModel() { Value = "12+5" };
            //Act
            var result =await _formulaService.SolveFormula(formula);
            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Formula_Solve_Easy_Example() 
        {
            //Arrange
            var formule = new FormulaModel() {Value = "12+5-7"};
            //Act
            var result = await _formulaService.SolveFormula(formule);
            //Assert
            Assert.Equal( 10 , result.Value);
        }
    }
}

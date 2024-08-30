using AutoMapper;
using Calculator.BusinessLogic.Models;
using Calculator.BusinessLogic.Services.Base;
using Microsoft.AspNetCore.Mvc;
using WebCalculator.Requests;
using WebCalculator.Responses;

namespace WebCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormulaController(IFormulaService formulaServise, IMapper mapper) : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(AnswerRequest),201)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Calculation([FromBody] FormulaRequest formulaRequest) 
        {
            var answer = await formulaServise.SolveFormula(mapper.Map<FormulaModel>(formulaRequest));
            if (answer == null) return NotFound();
            return Ok(mapper.Map<AnswerRequest>(answer));
        }
    }
}

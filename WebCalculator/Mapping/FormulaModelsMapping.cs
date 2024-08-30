using AutoMapper;
using Calculator.BusinessLogic.Models;
using WebCalculator.Requests;
using WebCalculator.Responses;

namespace WebCalculator.Mapping
{
    public class FormulaModelsMapping : Profile
    {
        public FormulaModelsMapping()
        {
            CreateMap<FormulaRequest, FormulaModel>();
            CreateMap<AnswerModel, AnswerRequest>();
        }
    }
}

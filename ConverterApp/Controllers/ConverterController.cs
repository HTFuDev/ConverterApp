using ConverterApp.Models;
using ConverterApp.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ConverterApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConverterController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public ConverterController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public IActionResult GetConversion(ConverterViewModel converterView)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var metrics = _appDbContext.Metrics.SingleOrDefault(x => x.SourceId == converterView.SourceUnit && x.TargetId == converterView.TargetUnit);

                if (metrics == null)
                    return BadRequest(ModelState);

                string sourceUnit = _appDbContext.Units.Where(x => x.Id == metrics.SourceId).Select(x => x.UnitName).SingleOrDefault();

                string targetUnit = _appDbContext.Units.Where(x => x.Id == metrics.TargetId).Select(x => x.UnitName).SingleOrDefault();

                string formula = metrics.Formula.Trim();
                string sen = formula.Replace("value", Convert.ToString(converterView.Value));
                double result = Convert.ToDouble(StringMath.SMath.Evaluate(sen));
                
                return Ok($"Conversion of {converterView.Value} {sourceUnit} to {targetUnit} is {Math.Round((Double)result,2)}");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CalculatorApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger _logger;

        public CalculatorController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strnumber)
        {
            double number;
            bool isNumber = double.TryParse(strnumber, 
                NumberStyles.Any,
                NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strnumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strnumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
    }
}

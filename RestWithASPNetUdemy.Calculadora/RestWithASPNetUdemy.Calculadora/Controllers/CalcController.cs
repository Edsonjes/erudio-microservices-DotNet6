using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNetUdemy.Calculadora.Controllers;

[ApiController]
[Route("[controller]")]
{
    public class CalcController : ControllerBase
    {
        private readonly ILogger<CalcController> _logger;
        public CalcController(ILogger<CalcController> logger)
    {
        _logger = logger;
    }
        
    [HttpGet("Sum{FirstNumber}/{SecondNumber}")]

    public IActionResult Sum(string FirstNumber , string SecondNumber )
    {
        if(IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
        {
            var Sum = ConvertToDecimal(FirstNumber) + ConvertToDecimal(SecondNumber);
            return Ok(Sum.ToString());

        }


        return BadRequest("Invalid Input");

    }
    [HttpGet("Sub{FirstNumber}/{SecondNumber}")]

    public IActionResult Sub(string FirstNumber , string SecondNumber )
    {
        if(IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
        {
            var Sub = ConvertToDecimal(FirstNumber) - ConvertToDecimal(SecondNumber);
            return Ok(Sub.ToString());

        }


        return BadRequest("Invalid Input");

    }
    [HttpGet("Mut{FirstNumber}/{SecondNumber}")]

    public IActionResult Mut(string FirstNumber , string SecondNumber )
    {
        if(IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
        {
            var Mut = ConvertToDecimal(FirstNumber) * ConvertToDecimal(SecondNumber);
            return Ok(Mut.ToString());

        }


        return BadRequest("Invalid Input");

    }
     [HttpGet("Div{FirstNumber}/{SecondNumber}")]

    public IActionResult Div(string FirstNumber , string SecondNumber )
    {
        if(IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
        {
            var Div = ConvertToDecimal(FirstNumber) / ConvertToDecimal(SecondNumber);
            return Ok(Div.ToString());

        }


        return BadRequest("Invalid Input");

    }
    
       private bool IsNumeric(string strNumber)
    {
         double number;
        bool isNumber = double.TryParse(strNumber, 
        System.Globalization.NumberStyles.Any,
        System.Globalization.NumberFormatInfo.InvariantInfo,
        out number);
        return isNumber;
    }

    private Decimal  ConvertToDecimal(string strNumber)
    {
       decimal DecimalValue;
       if(decimal.TryParse(strNumber, out DecimalValue)){
        return DecimalValue;
       }
       return 0;
    }

 
}
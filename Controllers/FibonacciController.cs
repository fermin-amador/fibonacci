using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase
    {
        
        public FibonacciController()
        {
        }
        [HttpGet]
        public async Task<IActionResult> index([FromQuery] int index = 3)
        {
            if(index == 0) return Ok(0);
            Int64 number1 = 0;
            Int64 number2 = 1;
            
            List<Int64> ArrayFibonacci = new List<Int64> { number1, number2  };
            Int64 nextNumber = 0;
            for (int x = 0; x < index; x++)
            {
                nextNumber = number1 + number2;
                number1 = number2;
                number2 = nextNumber;
                ArrayFibonacci.Add(number1);
                
            } 
            return Ok(ArrayFibonacci.Last());
        }
    }
}
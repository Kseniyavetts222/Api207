using Microsoft.AspNetCore.Mvc;

namespace ApiMath.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        calc2.Math clsMathService=new calc2.Math();
        [HttpGet("SumNumber")]
        public int plus(double num1, int num2) => (int)clsMathService.sum(num1, num2);
        [HttpGet("MinusNumber")]
        public int mins(double num1, int num2) => (int)clsMathService.minus(num1, num2);
        [HttpGet("DelNumber")]
        public int delenie(double num1, int num2) => (int)clsMathService.del(num1, num2);
        [HttpGet("MultiplicationNumber")]
        public int umnoz(double num1, int num2) => (int)clsMathService.multiplication(num1, num2);
        [HttpGet("ExdivNumber")]
        public int ExDiv(double num1, int num2) => (int)clsMathService.Exdiv(num1, num2);
        [HttpGet("PercentNumber")]
        public int perc(double num1, int num2) => (int)clsMathService.percent(num1, num2);
        [HttpGet("DepercentNumber")]
        public int deperc(double num1, int num2) => (int)clsMathService.depercent(num1, num2);
        [HttpGet("factorial_aNumber")]
        public int factorial_a(int num1) => (int)clsMathService.factorial_a(num1);
        [HttpGet("MaxNumber")]
        public double max([FromQuery] double[]numbers) =>clsMathService.Max(numbers);
        [HttpGet("MinNumber")]
        public double min([FromQuery] double[] numbers) => clsMathService.Min(numbers);
        [HttpGet("CountNumber")]
        public double count([FromQuery] double[] numbers) => clsMathService.Count(numbers);
        [HttpGet("SummNumber")]
        public double Sumar([FromQuery] double[] numbers) => clsMathService.Summ(numbers);






















    }
}

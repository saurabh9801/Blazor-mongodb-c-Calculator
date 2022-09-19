using CalculatorClassLibrary;
using CalculatorWebApp.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public  class CalculatorController : ControllerBase
    {
        CalculatorDataAccessLayer objCalculator = new CalculatorDataAccessLayer();

       

        //[HttpGet("{id}")]
        ////[Route("api/Calculator/Index")]
        //public IEnumerable<Calculator> Index()
        //{
        //    return objCalculator.GetAllCalculators();

        //}

        [HttpPost]
        [Route("api/Calculator/Create")]
        public double Create([FromBody] CalculatorMessage calculator)
        {




            Calculator calculator1 = new Calculator();
            //calculator1.Id = "1";
            calculator1.FirstNum = calculator.FirstNum;
            calculator1.SecondNum = calculator.SecondNum;
            calculator1.Operator = calculator.Operator;
            //calculator1.Result= calculator.Result;
            //calculator1.Operator = "+";
            //calculator1.Result = 0;
            //calculator1.Result = calculator1.FirstNum + calculator1.SecondNum;
            //calculator1.Result = calculator1.FirstNum - calculator1.SecondNum;
            //calculator1.Result = calculator1.FirstNum * calculator1.SecondNum;
            //calculator1.Result = calculator1.FirstNum / calculator1.SecondNum;

            //Outr out= new Outr(calculator1.FirstNum, calculator1.SecondNum, calculator1.Operator);
            
            //Result r= new Result();
            switch (calculator1.Operator)
            {

                case "+":

                    calculator1.Result = calculator1.FirstNum + calculator1.SecondNum;

                    break;

                case "-":
                    calculator1.Result = calculator1.FirstNum - calculator1.SecondNum;
                    break;

                case "*":
                    calculator1.Result = calculator1.FirstNum * calculator1.SecondNum;
                    break;

                case "/":
                    calculator1.Result = calculator1.FirstNum / calculator1.SecondNum;

                    break;


            }
            objCalculator.AddCalculator(calculator1);
            return calculator1.Result;
            //    public int  Outr(int FirstNum, int SecondNum, string Operator)
            //{
            //    Calculator calculator1 = new Calculator();
            //    }
        }
            
    }
}


    






     
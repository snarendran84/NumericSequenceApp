using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NumericSequenceApp.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NumericSequenceApp.Controllers
{
    [Route("api/[controller]")]
    public class NumericSequenceApiController : Controller
    {
        private ISequenceGenerator _sequenceGenerator;
        public NumericSequenceApiController(ISequenceGenerator sequenceGenerator)
        {
            _sequenceGenerator = sequenceGenerator;
        }

        [HttpGet("GetNumericSequence/{inputNumber}")]
        public IEnumerable<int> GetNumericSequence(int inputNumber)
        {
            return _sequenceGenerator.GetNumericSequence(inputNumber);
        }

        [HttpGet("GetOddNumberSequence/{inputNumber}")]
        public IEnumerable<int> GetOddNumberSequence(int inputNumber)
        {
            return _sequenceGenerator.GetOddNumberSequence(inputNumber);
        }

        [HttpGet("GetEvenNumberSequence/{inputNumber}")]
        public IEnumerable<int> GetEvenNumberSequence(int inputNumber)
        {
            return _sequenceGenerator.GetEvenNumberSequence(inputNumber);
        }

        [HttpGet("GetFibonacciSequence/{inputNumber}")]
        public IEnumerable<int> GetFibonacciSequence(int inputNumber)
        {
            return _sequenceGenerator.GetFibonacciSequence(inputNumber);
        }
    }
}

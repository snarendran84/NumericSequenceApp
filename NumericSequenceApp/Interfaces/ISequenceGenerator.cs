using System.Collections.Generic;

namespace NumericSequenceApp.Interfaces
{
    public interface ISequenceGenerator
    {
        IEnumerable<int> GetNumericSequence(int input);
        IEnumerable<int> GetOddNumberSequence(int input);
        IEnumerable<int> GetEvenNumberSequence(int input);
        IEnumerable<int> GetFibonacciSequence(int input);
    }
}

using NumericSequenceApp.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NumericSequenceApp.Implementations
{
    public class SequenceGenerator : ISequenceGenerator
    {
        public IEnumerable<int> GetEvenNumberSequence(int input)
        {
            IEnumerable<int> numericalSequence = Enumerable.Range(1, input).Where(x => x % 2 == 0 && x <= input);

            return numericalSequence;
        }

        public IEnumerable<int> GetFibonacciSequence(int input)
        {
            IList<int> fibSequence = new List<int>();
            var lastSeq = 0;
            for (int start = 0; start <= input && lastSeq <= input; start++)
            {
                lastSeq = fibnacciGenerator(start);
                if (lastSeq <= input)
                {
                    fibSequence.Add(lastSeq);
                }
            }

            return fibSequence;
        }

        private static int fibnacciGenerator(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;
            return fibnacciGenerator(number - 1) + fibnacciGenerator(number - 2);
        }


        public IEnumerable<int> GetNumericSequence(int input)
        {
            IEnumerable<int> numericalSequence = Enumerable.Range(0, input).Select(x => x + 1).Where(x => x <= input);

            return numericalSequence;
        }

        public IEnumerable<int> GetOddNumberSequence(int input)
        {
            IEnumerable<int> numericalSequence = Enumerable.Range(1, input).Where(x => x % 2 != 0 && x <= input);
            return numericalSequence.ToArray<int>();
        }
    }
}

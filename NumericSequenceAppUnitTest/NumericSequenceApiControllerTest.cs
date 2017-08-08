using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceApp.Controllers;
using System.Collections.Generic;
using NumericSequenceApp.Implementations;

namespace NumericSequenceAppUnitTest
{
    [TestClass]
    public class SequenceGeneratorTest
    {

        [TestMethod]
        public void TestNumericSequence()
        {
            var sequence = new List<int> { 1, 2, 3, 4, 5 };

            var generator = new SequenceGenerator();

            var result = generator.GetNumericSequence(5);

            CollectionAssert.AreEqual(sequence, result.ToList());
        }

        [TestMethod]
        public void TestOddNumericSequence()
        {
            var numericSequence = new List<int> { 1, 3, 5, 7, 9 };

            var controller = new SequenceGenerator();

            var result = controller.GetOddNumberSequence(10);

            CollectionAssert.AreEqual(numericSequence, result.ToList());
        }

        [TestMethod]
        public void TestEvenNumericSequence()
        {
            var sequence = new List<int> { 2, 4, 6, 8, 10 };

            var controller = new SequenceGenerator();

            var result = controller.GetEvenNumberSequence(10);

            CollectionAssert.AreEqual(sequence, result.ToList());
        }

        [TestMethod]
        public void TestFibonacciSequence()
        {
            var sequence = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };

            var controller = new SequenceGenerator();

            var result = controller.GetFibonacciSequence(15);

            CollectionAssert.AreEqual(sequence, result.ToList());
        }
    }
}

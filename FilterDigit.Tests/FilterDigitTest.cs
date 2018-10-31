using System.Collections.Generic;
using NUnit.Framework;

namespace FilterDigit.Tests
{
    [TestFixture]
    public class FilterDigitTest
    {
        [Test]
        public void FilterDigit_7()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17, -5, -27 };
            IEnumerable<int> result = Filter.ByDigit(numbers, 7);
            CollectionAssert.AreEqual(new[] { 7, 70, 17, -27 }, result);
        }

        [Test]
        public void FilterDigit_0()
        {
            int[] numbers = { 1, 2, 3, 40, 5, 6, 7, 0, 50, 70, 15, 17, -5, -20 };
            IEnumerable<int> result = Filter.ByDigit(numbers, 0);
            CollectionAssert.AreEqual(new[] { 40, 0, 50, 70, -20 }, result);
        }
    }
}

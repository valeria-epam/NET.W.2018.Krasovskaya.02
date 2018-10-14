using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FindNextBiggerNumber.Tests
{
    [TestFixture]
    public class FindNumberTest
    {
        [Test]
        [Sequential]
        public void FindNextBiggerNumber(
            [Values(12,513,2017,414,144,1234321,1234126,3456432,10,20)] int number, 
            [Values(21,531,2071,441,414,1241233,1234162,3462345,-1,-1)] int expected)
        {
            int result = FindNumber.FindNextBiggerNumber(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FindNextBiggerNumberWithTimeOutParam()
        {
            TimeSpan time;
            int result = FindNumber.FindNextBiggerNumberWithTime(12, out time);
            Assert.AreEqual(21, result);
            Assert.That(time, Is.GreaterThan(TimeSpan.Zero));
        }

        [Test]
        public void FindNextBiggerNumberWithTimeTuple()
        {
            (int result, TimeSpan time) = FindNumber.FindNextBiggerNumberWithTime(12);
            Assert.AreEqual(21, result);
            Assert.That(time, Is.GreaterThan(TimeSpan.Zero));
        }
    }
}

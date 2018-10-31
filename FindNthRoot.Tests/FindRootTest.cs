using System;
using NUnit.Framework;

namespace FindNthRoot.Tests
{
    [TestFixture]
    public class FindRootTest
    {
        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]
       
        public void FindRoot(double number, int rootPower, double epsilon, double expected)
        {
            double actual = FindNRoot.FindRoot(number, rootPower, epsilon);
            Assert.AreEqual(expected, actual, epsilon);
        }

        [TestCase(8, 15, -7)]
        [TestCase(8, 15, -0.6)]
        public void FindRootArgumentOutOfRangeException(double number, int rootPower, double epsilon)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FindNRoot.FindRoot(number, rootPower, epsilon));
        }
    }
}

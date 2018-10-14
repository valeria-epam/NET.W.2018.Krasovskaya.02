
using NUnit.Framework;


namespace InsertNumber.Tests
{
    [TestFixture]
    public class InsertNumberTestNunit
    {
        [Test]
        public void InsertNumber1()
        {
            int result = InsertNumberTask.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(120, result);
        }

        [Test]
        public void InsertNumber2()
        {
            int result = InsertNumberTask.InsertNumber(8, 15, 0, 0);
            Assert.AreEqual(9, result);
        }
    }
}

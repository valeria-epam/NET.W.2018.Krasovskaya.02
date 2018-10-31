using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsertNumber.Tests
{
    [TestClass]
    public class InsertNumberTestMSunit
    {
        [TestMethod]
        public void InsertNumber1()
        {
            int result = InsertNumberTask.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void InsertNumber2()
        {
            int result = InsertNumberTask.InsertNumber(8, 15, 0, 0);
            Assert.AreEqual(9, result);
        }
    }
}

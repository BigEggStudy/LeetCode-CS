using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0258_AddDigits_Test
    {
        [TestMethod]
        public void AddDigits_1()
        {
            var solution = new _0258_AddDigits();
            var result = solution.AddDigits(38);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void AddDigits_2()
        {
            var solution = new _0258_AddDigits();
            var result = solution.AddDigits(0);
            Assert.AreEqual(0, result);
        }
    }
}

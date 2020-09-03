using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0693_BinaryNumberWithAlternatingBits_Test
    {
        [TestMethod]
        public void HasAlternatingBits_1()
        {
            var solution = new _0693_BinaryNumberWithAlternatingBits();
            var result = solution.HasAlternatingBits(5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasAlternatingBits_2()
        {
            var solution = new _0693_BinaryNumberWithAlternatingBits();
            var result = solution.HasAlternatingBits(7);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasAlternatingBits_3()
        {
            var solution = new _0693_BinaryNumberWithAlternatingBits();
            var result = solution.HasAlternatingBits(11);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasAlternatingBits_4()
        {
            var solution = new _0693_BinaryNumberWithAlternatingBits();
            var result = solution.HasAlternatingBits(10);
            Assert.IsTrue(result);
        }
    }
}

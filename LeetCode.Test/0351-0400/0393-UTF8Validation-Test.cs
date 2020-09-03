using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0393_UTF8Validation_Test
    {
        [TestMethod]
        public void ValidUtf8_1()
        {
            var solution = new _0393_UTF8Validation();
            var result = solution.ValidUtf8(new int[] { 197, 130, 1 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidUtf8_2()
        {
            var solution = new _0393_UTF8Validation();
            var result = solution.ValidUtf8(new int[] { 235, 140, 4 });
            Assert.IsFalse(result);
        }
    }
}

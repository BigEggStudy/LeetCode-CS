using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0443_StringCompression_Test
    {
        [TestMethod]
        public void Compress_1()
        {
            var input = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };

            var solution = new _0443_StringCompression();
            var result = solution.Compress(input);
            Assert.AreEqual(6, result);
            AssertHelper.AssertArray(new char[] { 'a', '2', 'b', '2', 'c', '3' }, input, true);
        }

        [TestMethod]
        public void Compress_2()
        {
            var input = new char[] { 'a' };

            var solution = new _0443_StringCompression();
            var result = solution.Compress(input);
            Assert.AreEqual(1, result);
            AssertHelper.AssertArray(new char[] { 'a' }, input, true);
        }

        [TestMethod]
        public void Compress_3()
        {
            var input = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };

            var solution = new _0443_StringCompression();
            var result = solution.Compress(input);
            Assert.AreEqual(4, result);
            AssertHelper.AssertArray(new char[] { 'a', 'b', '1', '2' }, input, true);
        }
    }
}

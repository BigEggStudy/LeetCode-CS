using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0493_ReversePairs_Test
    {
        [TestMethod]
        public void ReversePairs_1()
        {
            var solution = new _0493_ReversePairs();
            var result = solution.ReversePairs(new int[] { 1, 3, 2, 3, 1 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ReversePairs_2()
        {
            var solution = new _0493_ReversePairs();
            var result = solution.ReversePairs(new int[] { 2, 4, 3, 5, 1 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ReversePairs_3()
        {
            var solution = new _0493_ReversePairs();
            var result = solution.ReversePairs(new int[] { 2147483647, 2147483647, 2147483647, 2147483647, 2147483647, 2147483647 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [Timeout(100)]
        public void ReversePairs_4()
        {
            var input = new int[10000];
            for (int i = 0; i < 10000; i++)
                input[i] = i;

            var solution = new _0493_ReversePairs();
            var result = solution.ReversePairs(input);
            Assert.AreEqual(0, result);
        }
    }
}

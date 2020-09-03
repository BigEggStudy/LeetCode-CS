using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1128_NumberOfEquivalentDominoPairs_Test
    {
        [TestMethod]
        public void NumEquivDominoPairs_1()
        {
            var solution = new _1128_NumberOfEquivalentDominoPairs();
            var result = solution.NumEquivDominoPairs(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 1 },
                new int[] { 3, 4 },
                new int[] { 5, 6 },
            });
            Assert.AreEqual(1, result);
        }
    }
}

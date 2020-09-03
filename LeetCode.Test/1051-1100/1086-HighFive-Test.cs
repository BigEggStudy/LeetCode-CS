using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1086_HighFive_Test
    {
        [TestMethod]
        public void HighFive_1()
        {
            var solution = new _1086_HighFive();
            var result = solution.HighFive(new int[][]
                {
                    new int[] { 1, 91},
                    new int[] { 1, 92 },
                    new int[] { 2, 93 },
                    new int[] { 2, 97 },
                    new int[] { 1, 60 },
                    new int[] { 2, 77 },
                    new int[] { 1, 65 },
                    new int[] { 1, 87 },
                    new int[] { 1, 100 },
                    new int[] { 2, 100 },
                    new int[] { 2, 76 },
                });
            AssertHelper.AssertArray(
                new int[][]
                {
                    new int[] { 1, 87 },
                    new int[] { 2, 88 },
            }, result);
        }
    }
}

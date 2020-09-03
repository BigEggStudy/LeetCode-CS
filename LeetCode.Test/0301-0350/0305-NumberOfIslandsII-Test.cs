using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0305_NumberOfIslandsII_Test
    {
        [TestMethod]
        public void NumIslands2_1()
        {
            var solution = new _0305_NumberOfIslandsII();
            var result = solution.NumIslands2(3, 3, new int[][] {
                new int[] { 0, 0 },
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 1 },
            });
            AssertHelper.AssertList(new int[] { 1, 1, 2, 3 }, result);
        }

        [TestMethod]
        public void NumIslands2_2()
        {
            var solution = new _0305_NumberOfIslandsII();
            var result = solution.NumIslands2(2, 2, new int[][] {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 0, 1 },
            });
            AssertHelper.AssertList(new int[] { 1, 2, 1 }, result);
        }

        [TestMethod]
        public void NumIslands2_3()
        {
            var solution = new _0305_NumberOfIslandsII();
            var result = solution.NumIslands2(3, 3, new int[][] {
                new int[] { 0, 0 },
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 1, 2 },
            });
            AssertHelper.AssertList(new int[] { 1, 1, 2, 2 }, result);
        }

        [TestMethod]
        public void NumIslands2_4()
        {
            var solution = new _0305_NumberOfIslandsII();
            var result = solution.NumIslands2(8, 6, new int[][] {
                new int[] { 0, 5 },
                new int[] { 5, 4 },
                new int[] { 5, 2 },
                new int[] { 7, 3 },
                new int[] { 6, 0 },
                new int[] { 5, 3 },
                new int[] { 5, 1 },
                new int[] { 1, 3 },
                new int[] { 4, 3 },
                new int[] { 2, 3 },
                new int[] { 3, 5 },
                new int[] { 3, 2 },
                new int[] { 3, 0 },
                new int[] { 2, 4 },
                new int[] { 0, 1 },
            });
            AssertHelper.AssertList(new int[] { 1, 2, 3, 4, 5, 4, 4, 5, 5, 5, 6, 7, 8, 8, 9 }, result);
        }
    }
}

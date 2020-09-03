using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0497_RandomPointInNonOverlappingRectangles_Test
    {
        [TestMethod]
        public void Pick_1()
        {
            var solution = new _0497_RandomPointInNonOverlappingRectangles(new int[][] {
                new int[] { 1, 1, 5, 5 },
            });

            for (int i = 0; i < 100; i++)
            {
                var result = solution.Pick();
                Assert.IsTrue(result[0] >= 1 && result[0] <= 5 && result[1] >= 1 && result[1] <= 5);
            }
        }

        [TestMethod]
        public void Pick_2()
        {
            var solution = new _0497_RandomPointInNonOverlappingRectangles(new int[][] {
                new int[] { -2, -2, -1, -1 },
                new int[] { 1, 0, 3, 0 },
            });

            for (int i = 0; i < 100; i++)
            {
                var result = solution.Pick();
                Assert.IsTrue((result[0] >= -2 && result[0] <= -1 && result[1] >= -2 && result[1] <= -1)
                           || (result[0] >= 1 && result[0] <= 3 && result[1] == 0));
            }
        }
    }
}

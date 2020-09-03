using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1042_FlowerPlantingWithNoAdjacent_Test
    {
        [TestMethod]
        public void GardenNoAdj_1()
        {
            var solution = new _1042_FlowerPlantingWithNoAdjacent();
            var result = solution.GardenNoAdj(3, new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 1 },
            });
            AssertHelper.AssertArray(new int[] { 1, 2, 3 }, result);
        }

        [TestMethod]
        public void GardenNoAdj_2()
        {
            var solution = new _1042_FlowerPlantingWithNoAdjacent();
            var result = solution.GardenNoAdj(4, new int[][] {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
            });
            AssertHelper.AssertArray(new int[] { 1, 2, 1, 2 }, result);
        }

        [TestMethod]
        public void GardenNoAdj_3()
        {
            var solution = new _1042_FlowerPlantingWithNoAdjacent();
            var result = solution.GardenNoAdj(4, new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 1 },
                new int[] { 1, 3 },
                new int[] { 2, 4 },
            });
            AssertHelper.AssertArray(new int[] { 1, 2, 3, 4 }, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1007_MinimumDominoRotationsForEqualRow_Test
    {
        [TestMethod]
        public void MinDominoRotationsTest_1()
        {
            var solution = new _1007_MinimumDominoRotationsForEqualRow();
            var result = solution.MinDominoRotations(new int[] { 2, 1, 2, 4, 2, 2 }, new int[] { 5, 2, 6, 2, 3, 2 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MinDominoRotationsTest_2()
        {
            var solution = new _1007_MinimumDominoRotationsForEqualRow();
            var result = solution.MinDominoRotations(new int[] { 3, 5, 1, 2, 3 }, new int[] { 3, 6, 3, 3, 4 });
            Assert.AreEqual(-1, result);
        }
    }
}

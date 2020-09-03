using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0913_CatAndMouse_Test
    {
        [TestMethod]
        public void CatMouseGameTest()
        {
            var solution = new _0913_CatAndMouse();
            var result = solution.CatMouseGame(
                new int[][] {
                    new int[] { 2, 5 },
                    new int[] { 3 },
                    new int[] { 0, 4, 5 },
                    new int[] { 1, 4, 5 },
                    new int[] { 2, 3 },
                    new int[] { 0, 2, 3}
                });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CatMouseGameTest_2()
        {
            var solution = new _0913_CatAndMouse();
            var result = solution.CatMouseGame(
                new int[][] {
                    new int[] { 2, 3 },
                    new int[] { 3, 4 },
                    new int[] { 0, 4 },
                    new int[] { 0, 1 },
                    new int[] { 1, 2 },
                });
            Assert.AreEqual(1, result);
        }
    }
}

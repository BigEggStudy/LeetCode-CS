using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0453_MinimumMovesToEqualArrayElements_Test
    {
        [TestMethod]
        public void MinMoves_1()
        {
            var solution = new _0453_MinimumMovesToEqualArrayElements();
            var result = solution.MinMoves(new int[] { 1, 2, 3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MinMoves_2()
        {
            var solution = new _0453_MinimumMovesToEqualArrayElements();
            var result = solution.MinMoves(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(6, result);
        }
    }
}

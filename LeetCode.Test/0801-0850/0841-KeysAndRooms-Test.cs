using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0841_KeysAndRooms_Test
    {
        [TestMethod]
        public void CanVisitAllRooms_1()
        {
            var solution = new _0841_KeysAndRooms();
            var result = solution.CanVisitAllRooms(new List<IList<int>> {
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
                new int[] { },
            });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanVisitAllRooms_2()
        {
            var solution = new _0841_KeysAndRooms();
            var result = solution.CanVisitAllRooms(new List<IList<int>> {
                new int[] { 1, 3 },
                new int[] { 3, 0, 1 },
                new int[] { 2 },
                new int[] { 0, },
            });
            Assert.IsFalse(result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0624_MaximumDistanceInArrays_Test
    {
        [TestMethod]
        public void MaxDistance_1()
        {
            var solution = new _0624_MaximumDistanceInArrays();
            var result = solution.MaxDistance(new List<IList<int>>()
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 1, 2, 3 },
            });
            Assert.AreEqual(4, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Test
{
    [TestClass]
    public class _0528_RandomPickWithWeight_Test
    {
        [TestMethod]
        public void PickIndex_1()
        {
            var solution = new _0528_RandomPickWithWeight(new int[] { 1 });
            var result = solution.PickIndex();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void PickIndex_2()
        {
            var solution = new _0528_RandomPickWithWeight(new int[] { 1, 3 });
            var results = new List<int>();
            for (int i = 0; i < 100; i++)
                results.Add(solution.PickIndex());

            Assert.IsTrue(results.Sum() > 50);
        }
    }
}

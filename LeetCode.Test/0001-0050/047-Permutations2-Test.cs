using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _047_Permutations2_Test
    {
        [TestMethod]
        public void PermuteUniqueTest()
        {
            var input = new int[] { 1, 1, 2 };

            var solution = new _047_Permutations2();
            var result = solution.PermuteUnique(input);

            Assert.AreEqual(3, result.Count);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int> { 1, 1, 2 },
                new List<int> { 2, 1, 1 },
                new List<int> { 1, 2, 1 }
            }, result);
        }

        [TestMethod]
        public void PermuteUniqueTest_2()
        {
            var input = new int[] { 1, 1, 2, 2, 3 };

            var solution = new _047_Permutations2();
            var result = solution.PermuteUnique(input);

            Assert.AreEqual(30, result.Count);
        }

        [TestMethod]
        public void PermuteUniqueTest_3()
        {
            var input = new int[] { 1, 2, 2, 3 };

            var solution = new _047_Permutations2();
            var result = solution.PermuteUnique(input);

            Assert.AreEqual(12, result.Count);
        }

        [TestMethod]
        public void PermuteUniqueTest_NotOrdered()
        {
            var input = new int[] { 3, 1, 2, 1, 2 };

            var solution = new _047_Permutations2();
            var result = solution.PermuteUnique(input);

            Assert.AreEqual(30, result.Count);
        }

        [TestMethod]
        public void PermuteUniqueTest_WithNavigateNumber()
        {
            var input = new int[] { -1, 2, 0, -1, 1, 0, 1 };

            var solution = new _047_Permutations2();
            var result = solution.PermuteUnique(input);

            Assert.AreEqual(630, result.Count);
        }

        [TestMethod]
        public void PermuteUniqueTest_OneItem()
        {
            var input = new int[] { 1 };

            var solution = new _047_Permutations2();
            var result = solution.PermuteUnique(input);

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void PermuteUniqueTest_AllSame()
        {
            var input = new int[] { 1, 1 };

            var solution = new _047_Permutations2();
            var result = solution.PermuteUnique(input);

            Assert.AreEqual(1, result.Count);
        }
    }
}

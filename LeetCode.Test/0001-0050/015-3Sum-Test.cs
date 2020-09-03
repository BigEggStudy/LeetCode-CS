using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _015_3Sum_Test
    {
        [TestMethod]
        public void ThreeSumTest()
        {
            int[] input = { -1, 0, 1, 2, -1, -4 };

            var solution = new _015_3Sum();
            var result = solution.ThreeSum(input);

            Assert.AreEqual(2, result.Count);
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { -1, -1, 2 },
                new List<int> { -1, 0, 1 }
            }, result);
        }

        [TestMethod]
        public void ThreeSumTest_AllPositive()
        {
            int[] input = { 1, 0, 1, 2, 1, 4 };

            var solution = new _015_3Sum();
            var result = solution.ThreeSum(input);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void ThreeSumTest_AllNagative()
        {
            int[] input = { -1, 0, -1, -2, -1, -4 };

            var solution = new _015_3Sum();
            var result = solution.ThreeSum(input);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void ThreeSumTest_Empty()
        {
            int[] input = { };

            var solution = new _015_3Sum();
            var result = solution.ThreeSum(input);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void ThreeSumTest_NotEnough()
        {
            var solution = new _015_3Sum();

            int[] input1 = { -1 };
            var result = solution.ThreeSum(input1);
            Assert.AreEqual(0, result.Count);

            int[] input2 = { -1, 0 };
            result = solution.ThreeSum(input2);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void ThreeSumTest_AllZero()
        {
            int[] input = { 0, 0, 0, 0, 0, 0 };

            var solution = new _015_3Sum();
            var result = solution.ThreeSum(input);

            Assert.AreEqual(1, result.Count);
            AssertHelper.AssertList(new List<IList<int>>
            {
                new List<int> { 0, 0, 0 }
            }, result);
        }

        [TestMethod]
        public void ThreeSumTest_2()
        {
            int[] input = { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 };

            var solution = new _015_3Sum();
            var result = solution.ThreeSum(input);

            Assert.AreEqual(6, result.Count);
        }

        [TestMethod]
        public void ThreeSumTest_LargeArray()
        {
            int[] input = { -13, 5, 13, 12, -2, -11, -1, 12, -3, 0, -3, -7, -7, -5, -3, -15, -2, 14, 14, 13, 6, -11, -11, 5, -15, -14, 5, -5, -2, 0, 3, -8, -10, -7, 11, -5, -10, -5, -7, -6, 2, 5, 3, 2, 7, 7, 3, -10, -2, 2, -12, -11, -1, 14, 10, -9, -15, -8, -7, -9, 7, 3, -2, 5, 11, -13, -15, 8, -3, -7, -12, 7, 5, -2, -6, -3, -10, 4, 2, -5, 14, -3, -1, -10, -3, -14, -4, -3, -7, -4, 3, 8, 14, 9, -2, 10, 11, -10, -4, -15, -9, -1, -1, 3, 4, 1, 8, 1 };

            var solution = new _015_3Sum();
            var result = solution.ThreeSum(input);

            Assert.AreEqual(118, result.Count);
        }
    }
}

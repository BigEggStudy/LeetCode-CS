using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1460_MakeTwoArraysEqualByReversingSubArrays_Test
    {
        [TestMethod]
        public void CanBeEqual_1()
        {
            var solution = new _1460_MakeTwoArraysEqualByReversingSubArrays();
            var result = solution.CanBeEqual(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 1, 3 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeEqual_2()
        {
            var solution = new _1460_MakeTwoArraysEqualByReversingSubArrays();
            var result = solution.CanBeEqual(new int[] { 7 }, new int[] { 7 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeEqual_3()
        {
            var solution = new _1460_MakeTwoArraysEqualByReversingSubArrays();
            var result = solution.CanBeEqual(new int[] { 1, 12 }, new int[] { 12, 1 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeEqual_4()
        {
            var solution = new _1460_MakeTwoArraysEqualByReversingSubArrays();
            var result = solution.CanBeEqual(new int[] { 3, 7, 9 }, new int[] { 3, 7, 11 });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeEqual_5()
        {
            var solution = new _1460_MakeTwoArraysEqualByReversingSubArrays();
            var result = solution.CanBeEqual(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 });
            Assert.IsTrue(result);
        }
    }
}

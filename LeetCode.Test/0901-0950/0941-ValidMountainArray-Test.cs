using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0941_ValidMountainArray_Test
    {
        [TestMethod]
        public void ValidMountainArray_1()
        {
            var solution = new _0941_ValidMountainArray();
            var result = solution.ValidMountainArray(new int[] { 2, 1 });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidMountainArray_2()
        {
            var solution = new _0941_ValidMountainArray();
            var result = solution.ValidMountainArray(new int[] { 3, 5, 5 });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidMountainArray_3()
        {
            var solution = new _0941_ValidMountainArray();
            var result = solution.ValidMountainArray(new int[] { 0, 3, 2, 1 });
            Assert.IsTrue(result);
        }
    }
}

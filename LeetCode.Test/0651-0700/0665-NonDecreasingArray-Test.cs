using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0665_NonDecreasingArray_Test
    {
        [TestMethod]
        public void CheckPossibility_1()
        {
            var solution = new _0665_NonDecreasingArray();
            var result = solution.CheckPossibility(new int[] { 4, 2, 3 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckPossibility_2()
        {
            var solution = new _0665_NonDecreasingArray();
            var result = solution.CheckPossibility(new int[] { 4, 2, 1 });
            Assert.IsFalse(result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0217_ContainsDuplicate_Test
    {
        [TestMethod]
        public void ContainsDuplicate_1()
        {
            var solution = new _0217_ContainsDuplicate();
            var result = solution.ContainsDuplicate(new int[] { 1, 2, 3, 1 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsDuplicate_2()
        {
            var solution = new _0217_ContainsDuplicate();
            var result = solution.ContainsDuplicate(new int[] { 1, 2, 3, 4 });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ContainsDuplicate_3()
        {
            var solution = new _0217_ContainsDuplicate();
            var result = solution.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
            Assert.IsTrue(result);
        }
    }
}

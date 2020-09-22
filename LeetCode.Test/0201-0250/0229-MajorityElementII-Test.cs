using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0229_MajorityElementII_Test
    {
        [TestMethod]
        public void MajorityElement_1()
        {
            var solution = new _0229_MajorityElementII();
            var result = solution.MajorityElement(new int[] { 3, 2, 3 });
            AssertHelper.AssertList(new int[] { 3 }, result);
        }

        [TestMethod]
        public void MajorityElement_2()
        {
            var solution = new _0229_MajorityElementII();
            var result = solution.MajorityElement(new int[] { 1, 1, 1, 3, 3, 2, 2, 2 });
            AssertHelper.AssertList(new int[] { 1, 2 }, result);
        }
    }
}

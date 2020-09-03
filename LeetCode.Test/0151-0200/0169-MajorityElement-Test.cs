using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0169_MajorityElement_Test
    {
        [TestMethod]
        public void MajorityElementTest_1()
        {
            var solution = new _0169_MajorityElement();
            var result = solution.MajorityElement(new int[] { 3, 2, 3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MajorityElementTest_2()
        {
            var solution = new _0169_MajorityElement();
            var result = solution.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
            Assert.AreEqual(2, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0274_HIndex_Test
    {
        [TestMethod]
        public void HIndex_1()
        {
            var solution = new _0274_HIndex();
            var result = solution.HIndex(new int[] { 3,0,6,1,5});
            Assert.AreEqual(3, result);
        }
    }
}

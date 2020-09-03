using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0942_DIStringMatch_Test
    {
        [TestMethod]
        public void DiStringMatch_1()
        {
            var solution = new _0942_DIStringMatch();
            var result = solution.DiStringMatch("IDID");
            AssertHelper.AssertArray(new int[] { 0, 4, 1, 3, 2 }, result);
        }

        [TestMethod]
        public void DiStringMatch_2()
        {
            var solution = new _0942_DIStringMatch();
            var result = solution.DiStringMatch("III");
            AssertHelper.AssertArray(new int[] { 0, 1, 2, 3 }, result);
        }

        [TestMethod]
        public void DiStringMatch_3()
        {
            var solution = new _0942_DIStringMatch();
            var result = solution.DiStringMatch("DDI");
            AssertHelper.AssertArray(new int[] { 3, 2, 0, 1 }, result);
        }
    }
}

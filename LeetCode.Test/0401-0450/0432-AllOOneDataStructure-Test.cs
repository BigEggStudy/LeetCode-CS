using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0432_AllOOneDataStructure_Test
    {
        [TestMethod]
        public void AllOne_1()
        {
            var solution = new _0432_AllOOneDataStructure();
            solution.Inc("abc");
            string abc = solution.GetMaxKey();
            abc = solution.GetMinKey();
            abc = solution.GetMaxKey();

            Assert.AreEqual("abc", abc);
            solution.Dec("abc");

            abc = solution.GetMaxKey();
            Assert.IsTrue(string.IsNullOrEmpty(abc));
            abc = solution.GetMinKey();
            Assert.IsTrue(string.IsNullOrEmpty(abc));
        }
    }
}

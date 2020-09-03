using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1433_CheckIfAStringCanBreakAnotherString_Test
    {
        [TestMethod]
        public void CheckIfCanBreak_1()
        {
            var solution = new _1433_CheckIfAStringCanBreakAnotherString();
            var result = solution.CheckIfCanBreak("abc", "xya");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfCanBreak_2()
        {
            var solution = new _1433_CheckIfAStringCanBreakAnotherString();
            var result = solution.CheckIfCanBreak("abe", "acd");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfCanBreak_3()
        {
            var solution = new _1433_CheckIfAStringCanBreakAnotherString();
            var result = solution.CheckIfCanBreak("leetcodee", "interview");
            Assert.IsTrue(result);
        }
    }
}

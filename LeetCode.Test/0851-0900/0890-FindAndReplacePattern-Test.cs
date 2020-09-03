using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0890_FindAndReplacePattern_Test
    {
        [TestMethod]
        public void FindAndReplacePattern_1()
        {
            var solution = new _0890_FindAndReplacePattern();
            var result = solution.FindAndReplacePattern(new string[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" }, "abb");
            AssertHelper.AssertList(new string[] { "mee", "aqq" }, result);
        }
    }
}

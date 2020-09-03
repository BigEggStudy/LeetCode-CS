using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0500_KeyboardRow_Test
    {
        [TestMethod]
        public void FindWords_1()
        {
            var solution = new _0500_KeyboardRow();
            var result = solution.FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });
            AssertHelper.AssertArray(new string[] { "Alaska", "Dad" }, result);
        }
    }
}

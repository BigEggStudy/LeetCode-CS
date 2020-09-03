using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0535_EncodeAndDecodeTinyURL_Test
    {
        [TestMethod]
        public void EncodeAndDecodeTinyURLTest()
        {
            var input = "https://leetcode.com/problems/design-tinyurl";

            var solution = new _0535_EncodeAndDecodeTinyURL();
            var result = solution.decode(solution.encode(input));
            Assert.AreEqual(result, input);
        }
    }
}

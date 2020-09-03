using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0271_EncodeAndDecodeStrings_Test
    {
        [TestMethod]
        public void EncodeDecodeTest()
        {
            var input = new string[] { "Hello", "", "World" };

            var solution = new _0271_EncodeAndDecodeStrings();
            var result = solution.decode(solution.encode(input));
            AssertHelper.AssertList(input, result);
        }
    }
}

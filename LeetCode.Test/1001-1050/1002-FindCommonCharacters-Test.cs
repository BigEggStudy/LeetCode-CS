using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1002_FindCommonCharacters_Test
    {
        [TestMethod]
        public void CommonChars_1()
        {
            var solution = new _1002_FindCommonCharacters();
            var result = solution.CommonChars(new string[] { "bella", "label", "roller" });
            AssertHelper.AssertList(new string[] { "e", "l", "l" }, result);
        }

        [TestMethod]
        public void CommonChars_2()
        {
            var solution = new _1002_FindCommonCharacters();
            var result = solution.CommonChars(new string[] { "cool", "lock", "cook" });
            AssertHelper.AssertList(new string[] { "c", "o" }, result);
        }
    }
}

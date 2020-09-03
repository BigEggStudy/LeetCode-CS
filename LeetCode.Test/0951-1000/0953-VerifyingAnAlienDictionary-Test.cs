using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0953_VerifyingAnAlienDictionary_Test
    {
        [TestMethod]
        public void IsAlienSorted_1()
        {
            var solution = new _0953_VerifyingAnAlienDictionary();
            var result = solution.IsAlienSorted(new string[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAlienSorted_2()
        {
            var solution = new _0953_VerifyingAnAlienDictionary();
            var result = solution.IsAlienSorted(new string[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsAlienSorted_3()
        {
            var solution = new _0953_VerifyingAnAlienDictionary();
            var result = solution.IsAlienSorted(new string[] { "apple", "app" }, "abcdefghijklmnopqrstuvwxyz");
            Assert.IsFalse(result);
        }
    }
}

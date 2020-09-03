using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0242_ValidAnagram_Test
    {
        [TestMethod]
        public void IsAnagram_1()
        {
            var solution = new _0242_ValidAnagram();
            var result = solution.IsAnagram("anagram", "nagaram");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAnagram_2()
        {
            var solution = new _0242_ValidAnagram();
            var result = solution.IsAnagram("rat", "car");
            Assert.IsFalse(result);
        }
    }
}

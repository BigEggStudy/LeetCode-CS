using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0859_BuddyStrings_Test
    {
        [TestMethod]
        public void BuddyStrings_1()
        {
            var solution = new _0859_BuddyStrings();
            var result = solution.BuddyStrings("ab", "ba");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BuddyStrings_2()
        {
            var solution = new _0859_BuddyStrings();
            var result = solution.BuddyStrings("ab", "ab");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void BuddyStrings_3()
        {
            var solution = new _0859_BuddyStrings();
            var result = solution.BuddyStrings("aa", "aa");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BuddyStrings_4()
        {
            var solution = new _0859_BuddyStrings();
            var result = solution.BuddyStrings("aaaaaaabc", "aaaaaaacb");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BuddyStrings_5()
        {
            var solution = new _0859_BuddyStrings();
            var result = solution.BuddyStrings("", "aa");
            Assert.IsFalse(result);
        }
    }
}

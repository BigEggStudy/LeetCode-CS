using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0893_GroupsOfSpecialEquivalentStrings_Test
    {
        [TestMethod]
        public void NumSpecialEquivGroups_1()
        {
            var solution = new _0893_GroupsOfSpecialEquivalentStrings();
            var result = solution.NumSpecialEquivGroups(new string[] { "abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx" });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumSpecialEquivGroups_2()
        {
            var solution = new _0893_GroupsOfSpecialEquivalentStrings();
            var result = solution.NumSpecialEquivGroups(new string[] { "abc", "acb", "bac", "bca", "cab", "cba" });
            Assert.AreEqual(3, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1100_FindKLengthSubstringsWithNoRepeatedCharacters_Test
    {
        [TestMethod]
        public void NumKLenSubstrNoRepeats_1()
        {
            var solution = new _1100_FindKLengthSubstringsWithNoRepeatedCharacters();
            var result = solution.NumKLenSubstrNoRepeats("havefunonleetcode", 5);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void NumKLenSubstrNoRepeats_2()
        {
            var solution = new _1100_FindKLengthSubstringsWithNoRepeatedCharacters();
            var result = solution.NumKLenSubstrNoRepeats("home", 5);
            Assert.AreEqual(0, result);
        }
    }
}

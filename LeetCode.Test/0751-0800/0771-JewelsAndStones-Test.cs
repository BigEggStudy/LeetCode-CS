using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0771_JewelsAndStones_Test
    {
        [TestMethod]
        public void NumJewelsInStonesTest_1()
        {
            var solution = new _0771_JewelsAndStones();
            var result = solution.NumJewelsInStones("aA", "aAAbbbb");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NumJewelsInStonesTest_2()
        {
            var solution = new _0771_JewelsAndStones();
            var result = solution.NumJewelsInStones("z", "ZZ");
            Assert.AreEqual(0, result);
        }
    }
}

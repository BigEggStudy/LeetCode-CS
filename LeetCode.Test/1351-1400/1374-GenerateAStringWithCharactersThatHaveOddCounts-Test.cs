using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1374_GenerateAStringWithCharactersThatHaveOddCounts_Test
    {
        [TestMethod]
        public void GenerateTheString_1()
        {
            var solution = new _1374_GenerateAStringWithCharactersThatHaveOddCounts();
            var result = solution.GenerateTheString(4);
            Assert.AreEqual("aaab", result);
        }

        [TestMethod]
        public void GenerateTheString_2()
        {
            var solution = new _1374_GenerateAStringWithCharactersThatHaveOddCounts();
            var result = solution.GenerateTheString(2);
            Assert.AreEqual("ab", result);
        }

        [TestMethod]
        public void GenerateTheString_3()
        {
            var solution = new _1374_GenerateAStringWithCharactersThatHaveOddCounts();
            var result = solution.GenerateTheString(7);
            Assert.AreEqual("aaaaaaa", result);
        }
    }
}

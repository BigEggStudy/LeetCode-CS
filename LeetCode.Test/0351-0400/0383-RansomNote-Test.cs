using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0383_RansomNote_Test
    {
        [TestMethod]
        public void CanConstruct_1()
        {
            var solution = new _0383_RansomNote();
            var result = solution.CanConstruct("a", "b");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanConstruct_2()
        {
            var solution = new _0383_RansomNote();
            var result = solution.CanConstruct("aa", "ab");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanConstruct_3()
        {
            var solution = new _0383_RansomNote();
            var result = solution.CanConstruct("aa", "aab");
            Assert.IsTrue(result);
        }
    }
}

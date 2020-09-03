using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _028_ImplementStrStr_Test
    {
        [TestMethod]
        public void StrStrTest()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("abcdefg", "bcd");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void StrStrTest_EmptyNeedle()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("abcdefg", "");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void StrStrTest_NeedleLongerThanRest()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("abcdefg", "gh");

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void StrStrTest_SingleCharacterNeedle()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("abcdefg", "b");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void StrStrTest_JumpCheck()
        {
            var solution = new _028_ImplementStrStr();
            var result = solution.StrStr("mississippi", "issip");

            Assert.AreEqual(4, result);
        }
    }
}

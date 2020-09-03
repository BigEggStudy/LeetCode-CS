using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0408_ValidWordAbbreviation_Test
    {
        [TestMethod]
        public void ValidWordAbbreviation_1()
        {
            var solution = new _0408_ValidWordAbbreviation();
            var result = solution.ValidWordAbbreviation("internationalization", "i12iz4n");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidWordAbbreviation_2()
        {
            var solution = new _0408_ValidWordAbbreviation();
            var result = solution.ValidWordAbbreviation("apple", "a2e");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidWordAbbreviation_3()
        {
            var solution = new _0408_ValidWordAbbreviation();
            var result = solution.ValidWordAbbreviation("internationalization", "i5a11o1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidWordAbbreviation_4()
        {
            var solution = new _0408_ValidWordAbbreviation();
            var result = solution.ValidWordAbbreviation("a", "01");
            Assert.IsFalse(result);
        }
    }
}

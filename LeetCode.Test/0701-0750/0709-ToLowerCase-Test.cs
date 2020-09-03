using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0709_ToLowerCase_Test
    {
        [TestMethod]
        public void ToLowerCase_1()
        {
            var solution = new _0709_ToLowerCase();
            var result = solution.ToLowerCase("Hello");
            Assert.AreEqual("hello", result);
        }

        [TestMethod]
        public void ToLowerCase_2()
        {
            var solution = new _0709_ToLowerCase();
            var result = solution.ToLowerCase("here");
            Assert.AreEqual("here", result);
        }

        [TestMethod]
        public void ToLowerCase_3()
        {
            var solution = new _0709_ToLowerCase();
            var result = solution.ToLowerCase("LOVELY");
            Assert.AreEqual("lovely", result);
        }
    }
}

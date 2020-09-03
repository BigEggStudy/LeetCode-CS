using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0837_New21Game_Test
    {
        [TestMethod]
        public void New21GameTest_1()
        {
            var solution = new _0837_New21Game();
            var result = solution.New21Game(10, 1, 10);
            Assert.AreEqual(1.0, result, 0.00001);
        }

        [TestMethod]
        public void New21GameTest_2()
        {
            var solution = new _0837_New21Game();
            var result = solution.New21Game(6, 1, 10);
            Assert.AreEqual(0.6, result, 0.00001);
        }

        [TestMethod]
        public void New21GameTest_3()
        {
            var solution = new _0837_New21Game();
            var result = solution.New21Game(21, 17, 10);
            Assert.AreEqual(0.73278, result, 0.00001);
        }
    }
}

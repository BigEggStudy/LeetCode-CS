using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0904_FruitIntoBaskets_Test
    {
        [TestMethod]
        public void TotalFruitTest_1()
        {
            var solution = new _0904_FruitIntoBaskets();
            var result = solution.TotalFruit(new int[] { 1, 2, 1 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TotalFruitTest_2()
        {
            var solution = new _0904_FruitIntoBaskets();
            var result = solution.TotalFruit(new int[] { 0, 1, 2, 2 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TotalFruitTest_3()
        {
            var solution = new _0904_FruitIntoBaskets();
            var result = solution.TotalFruit(new int[] { 1, 2, 3, 2, 2 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TotalFruitTest_4()
        {
            var solution = new _0904_FruitIntoBaskets();
            var result = solution.TotalFruit(new int[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TotalFruitTest_5()
        {
            var solution = new _0904_FruitIntoBaskets();
            var result = solution.TotalFruit(new int[] { 1, 0, 3, 4, 3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TotalFruitTest_6()
        {
            var solution = new _0904_FruitIntoBaskets();
            var result = solution.TotalFruit(new int[] { 1, 0, 1, 4, 1, 4, 1, 2, 3 });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TotalFruitTest_7()
        {
            var solution = new _0904_FruitIntoBaskets();
            var result = solution.TotalFruit(new int[] { 1 });
            Assert.AreEqual(1, result);
        }
    }
}

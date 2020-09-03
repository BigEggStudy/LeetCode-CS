using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1196_HowManyApplesCanYouPutIntoTheBasket_Test
    {
        [TestMethod]
        public void MaxNumberOfApples_1()
        {
            var solution = new _1196_HowManyApplesCanYouPutIntoTheBasket();
            var result = solution.MaxNumberOfApples(new int[] { 100, 200, 150, 1000 });
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MaxNumberOfApples_2()
        {
            var solution = new _1196_HowManyApplesCanYouPutIntoTheBasket();
            var result = solution.MaxNumberOfApples(new int[] { 900, 950, 800, 1000, 700, 800 });
            Assert.AreEqual(5, result);
        }
    }
}

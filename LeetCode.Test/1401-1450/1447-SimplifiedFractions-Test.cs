using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1447_SimplifiedFractions_Test
    {
        [TestMethod]
        public void SimplifiedFractions_1()
        {
            var solution = new _1447_SimplifiedFractions();
            var result = solution.SimplifiedFractions(2);
            AssertHelper.AssertList(new string[] { "1/2" }, result);
        }

        [TestMethod]
        public void SimplifiedFractions_2()
        {
            var solution = new _1447_SimplifiedFractions();
            var result = solution.SimplifiedFractions(3);
            AssertHelper.AssertList(new string[] { "1/2", "1/3", "2/3" }, result);
        }

        [TestMethod]
        public void SimplifiedFractions_3()
        {
            var solution = new _1447_SimplifiedFractions();
            var result = solution.SimplifiedFractions(4);
            AssertHelper.AssertList(new string[] { "1/2", "1/3", "2/3", "1/4", "3/4" }, result);
        }

        [TestMethod]
        public void SimplifiedFractions_4()
        {
            var solution = new _1447_SimplifiedFractions();
            var result = solution.SimplifiedFractions(1);
            AssertHelper.AssertList(new string[] { }, result);
        }
    }
}

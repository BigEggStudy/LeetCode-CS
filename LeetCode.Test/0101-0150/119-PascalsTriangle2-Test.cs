using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _119_PascalsTriangle2_Test
    {
        [TestMethod]
        public void GenerateTest_0()
        {
            var solution = new _119_PascalsTriangle2();
            var result = solution.GetRow(0);
            AssertHelper.AssertList(new int[] { 1 }, result);
        }

        [TestMethod]
        public void GenerateTest_1()
        {
            var solution = new _119_PascalsTriangle2();
            var result = solution.GetRow(1);
            AssertHelper.AssertList(new int[] { 1, 1 }, result);
        }

        [TestMethod]
        public void GenerateTest_2()
        {
            var solution = new _119_PascalsTriangle2();
            var result = solution.GetRow(2);
            AssertHelper.AssertList(new int[] { 1, 2, 1 }, result);
        }

        [TestMethod]
        public void GenerateTest_3()
        {
            var solution = new _119_PascalsTriangle2();
            var result = solution.GetRow(3);
            AssertHelper.AssertList(new int[] { 1, 3, 3, 1 }, result);
        }

        [TestMethod]
        public void GenerateTest_4()
        {
            var solution = new _119_PascalsTriangle2();
            var result = solution.GetRow(4);
            AssertHelper.AssertList(new int[] { 1, 4, 6, 4, 1 }, result);
        }

        [TestMethod]
        public void GenerateTest_5()
        {
            var solution = new _119_PascalsTriangle2();
            var result = solution.GetRow(5);
            AssertHelper.AssertList(new int[] { 1, 5, 10, 10, 5, 1 }, result);
        }

        [TestMethod]
        public void GenerateTest_6()
        {
            var solution = new _119_PascalsTriangle2();
            var result = solution.GetRow(6);
            AssertHelper.AssertList(new int[] { 1, 6, 15, 20, 15, 6, 1 }, result);
        }
    }
}

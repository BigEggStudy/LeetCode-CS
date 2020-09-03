using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _118_PascalsTriangle_Test
    {
        [TestMethod]
        public void GenerateTest_0()
        {
            var solution = new _118_PascalsTriangle();
            var result = solution.Generate(0);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GenerateTest_1()
        {
            var solution = new _118_PascalsTriangle();
            var result = solution.Generate(1);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 1 }
            }, result);
        }

        [TestMethod]
        public void GenerateTest_2()
        {
            var solution = new _118_PascalsTriangle();
            var result = solution.Generate(2);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 }
            }, result);
        }

        [TestMethod]
        public void GenerateTest_3()
        {
            var solution = new _118_PascalsTriangle();
            var result = solution.Generate(3);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
                new List<int>() { 1, 2, 1 }
            }, result);
        }

        [TestMethod]
        public void GenerateTest_4()
        {
            var solution = new _118_PascalsTriangle();
            var result = solution.Generate(4);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
                new List<int>() { 1, 2, 1 },
                new List<int>() { 1, 3, 3, 1 }
            }, result);
        }

        [TestMethod]
        public void GenerateTest_5()
        {
            var solution = new _118_PascalsTriangle();
            var result = solution.Generate(5);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
                new List<int>() { 1, 2, 1 },
                new List<int>() { 1, 3, 3, 1 },
                new List<int>() { 1, 4, 6, 4, 1 },
            }, result);
        }

        [TestMethod]
        public void GenerateTest_6()
        {
            var solution = new _118_PascalsTriangle();
            var result = solution.Generate(6);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
                new List<int>() { 1, 2, 1 },
                new List<int>() { 1, 3, 3, 1 },
                new List<int>() { 1, 4, 6, 4, 1 },
                new List<int>() { 1, 5, 10, 10, 5, 1 }
            }, result);
        }

        [TestMethod]
        public void GenerateTest_7()
        {
            var solution = new _118_PascalsTriangle();
            var result = solution.Generate(7);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1, 1 },
                new List<int>() { 1, 2, 1 },
                new List<int>() { 1, 3, 3, 1 },
                new List<int>() { 1, 4, 6, 4, 1 },
                new List<int>() { 1, 5, 10, 10, 5, 1 },
                new List<int>() { 1, 6, 15, 20, 15, 6, 1 }
            }, result);
        }

        [TestMethod]
        public void GenerateTest_Negative()
        {
            var solution = new _118_PascalsTriangle();
            var result = solution.Generate(-1);
            Assert.AreEqual(0, result.Count);
        }
    }
}

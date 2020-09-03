using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0364_NestedListWeightSumII;

namespace LeetCode.Test
{
    [TestClass]
    public class _0364_NestedListWeightSumII_Test
    {
        [TestMethod]
        public void DepthSumInverse_1()
        {
            var input1 = new NestedInteger();
            input1.Add(new NestedInteger(1));
            input1.Add(new NestedInteger(1));
            var input2 = new NestedInteger(2);
            var input3 = new NestedInteger();
            input3.Add(new NestedInteger(1));
            input3.Add(new NestedInteger(1));

            var solution = new _0364_NestedListWeightSumII();
            var result = solution.DepthSumInverse(new List<NestedInteger>() { input1, input2, input3 });
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void DepthSumInverse_2()
        {
            var input3 = new NestedInteger();
            input3.Add(new NestedInteger(6));
            var input2 = new NestedInteger();
            input2.Add(new NestedInteger(4));
            input2.Add(input3);
            var input1 = new NestedInteger(1);

            var solution = new _0364_NestedListWeightSumII();
            var result = solution.DepthSumInverse(new List<NestedInteger>() { input1, input2 });
            Assert.AreEqual(17, result);
        }

        [TestMethod]
        public void DepthSumInverse_3()
        {
            var solution = new _0364_NestedListWeightSumII();
            var result = solution.DepthSumInverse(new List<NestedInteger>() { });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void DepthSumInverse_4()
        {
            var solution = new _0364_NestedListWeightSumII();
            var result = solution.DepthSumInverse(new List<NestedInteger>() { new NestedInteger(), new NestedInteger(), new NestedInteger() });
            Assert.AreEqual(0, result);
        }
    }
}

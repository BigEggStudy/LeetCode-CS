using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0339_NestedListWeightSum;

namespace LeetCode.Test
{
    [TestClass]
    public class _0339_NestedListWeightSum_Test
    {
        [TestMethod]
        public void DepthSum_1()
        {
            var input1 = new NestedInteger();
            input1.Add(new NestedInteger(1));
            input1.Add(new NestedInteger(1));
            var input2 = new NestedInteger(2);
            var input3 = new NestedInteger();
            input3.Add(new NestedInteger(1));
            input3.Add(new NestedInteger(1));

            var solution = new _0339_NestedListWeightSum();
            var result = solution.DepthSum(new List<NestedInteger>() { input1, input2, input3 });
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void DepthSum_2()
        {
            var input3 = new NestedInteger();
            input3.Add(new NestedInteger(6));
            var input2 = new NestedInteger();
            input2.Add(new NestedInteger(4));
            input2.Add(input3);
            var input1 = new NestedInteger(1);

            var solution = new _0339_NestedListWeightSum();
            var result = solution.DepthSum(new List<NestedInteger>() { input1, input2 });
            Assert.AreEqual(27, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0341_FlattenNestedListIterator;

namespace LeetCode.Test
{
    [TestClass]
    public class _0341_FlattenNestedListIterator_Test
    {
        [TestMethod]
        public void NestedIterator_1()
        {
            var input1 = new NestedInteger();
            input1.Add(new NestedInteger(1));
            input1.Add(new NestedInteger(1));
            var input2 = new NestedInteger(2);
            var input3 = new NestedInteger();
            input3.Add(new NestedInteger(1));
            input3.Add(new NestedInteger(1));

            var solution = new _0341_FlattenNestedListIterator(new List<NestedInteger>() { input1, input2, input3 });
            Assert.IsTrue(solution.HasNext());
            Assert.AreEqual(1, solution.Next());
            Assert.IsTrue(solution.HasNext());
            Assert.AreEqual(1, solution.Next());
            Assert.IsTrue(solution.HasNext());
            Assert.AreEqual(2, solution.Next());
            Assert.IsTrue(solution.HasNext());
            Assert.AreEqual(1, solution.Next());
            Assert.IsTrue(solution.HasNext());
            Assert.AreEqual(1, solution.Next());
            Assert.IsFalse(solution.HasNext());
        }

        [TestMethod]
        public void NestedIterator_2()
        {
            var input3 = new NestedInteger();
            input3.Add(new NestedInteger(6));
            var input2 = new NestedInteger();
            input2.Add(new NestedInteger(4));
            input2.Add(input3);
            var input1 = new NestedInteger(1);


            var solution = new _0341_FlattenNestedListIterator(new List<NestedInteger>() { input1, input2 });
            Assert.IsTrue(solution.HasNext());
            Assert.AreEqual(1, solution.Next());
            Assert.IsTrue(solution.HasNext());
            Assert.AreEqual(4, solution.Next());
            Assert.IsTrue(solution.HasNext());
            Assert.AreEqual(6, solution.Next());
            Assert.IsFalse(solution.HasNext());
        }

        [TestMethod]
        public void NestedIterator_3()
        {
            var input1 = new NestedInteger();

            var solution = new _0341_FlattenNestedListIterator(new List<NestedInteger>() { input1 });
            Assert.IsFalse(solution.HasNext());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestClass]
    public class _090_Subsets2_Test
    {
        [TestMethod]
        public void SubsetsTest()
        {
            var solution = new _090_Subsets2();
            var result = solution.SubsetsWithDup(new int[] { 1, 2, 3 });

            Assert.AreEqual(8, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
            AssertHelper.AssertList(new int[] { 1 }, result[1]);
            AssertHelper.AssertList(new int[] { 2 }, result[2]);
            AssertHelper.AssertList(new int[] { 1, 2 }, result[3]);
            AssertHelper.AssertList(new int[] { 3 }, result[4]);
            AssertHelper.AssertList(new int[] { 1, 3 }, result[5]);
            AssertHelper.AssertList(new int[] { 2, 3 }, result[6]);
            AssertHelper.AssertList(new int[] { 1, 2, 3 }, result[7]);
        }

        [TestMethod]
        public void SubsetsTest_NotOrdered()
        {
            var solution = new _090_Subsets2();
            var result = solution.SubsetsWithDup(new int[] { 3, 2, 1 });

            Assert.AreEqual(8, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
            AssertHelper.AssertList(new int[] { 1 }, result[1]);
            AssertHelper.AssertList(new int[] { 2 }, result[2]);
            AssertHelper.AssertList(new int[] { 1, 2 }, result[3]);
            AssertHelper.AssertList(new int[] { 3 }, result[4]);
            AssertHelper.AssertList(new int[] { 1, 3 }, result[5]);
            AssertHelper.AssertList(new int[] { 2, 3 }, result[6]);
            AssertHelper.AssertList(new int[] { 1, 2, 3 }, result[7]);
        }

        [TestMethod]
        public void SubsetsTest_EmptyNums()
        {
            var solution = new _090_Subsets2();
            var result = solution.SubsetsWithDup(new int[] { });

            Assert.AreEqual(1, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
        }

        [TestMethod]
        public void SubsetsTest_OneItem()
        {
            var solution = new _090_Subsets2();
            var result = solution.SubsetsWithDup(new int[] { 1 });

            Assert.AreEqual(2, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
            AssertHelper.AssertList(new int[] { 1 }, result[1]);
        }

        [TestMethod]
        public void SubsetsTest_Duplicate()
        {
            var solution = new _090_Subsets2();
            var result = solution.SubsetsWithDup(new int[] { 1, 1 });

            Assert.AreEqual(3, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
            AssertHelper.AssertList(new int[] { 1 }, result[1]);
            AssertHelper.AssertList(new int[] { 1, 1 }, result[2]);
        }

        [TestMethod]
        public void SubsetsTest_Duplicate_2()
        {
            var solution = new _090_Subsets2();
            var result = solution.SubsetsWithDup(new int[] { 1, 2, 2 });

            Assert.AreEqual(6, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
            AssertHelper.AssertList(new int[] { 1 }, result[1]);
            AssertHelper.AssertList(new int[] { 2 }, result[2]);
            AssertHelper.AssertList(new int[] { 1, 2 }, result[3]);
            AssertHelper.AssertList(new int[] { 2, 2 }, result[4]);
            AssertHelper.AssertList(new int[] { 1, 2, 2 }, result[5]);
        }

        [TestMethod]
        public void SubsetsTest_Duplicate_3()
        {
            var solution = new _090_Subsets2();
            var result = solution.SubsetsWithDup(new int[] { 1, 2, 2, 3 });

            Assert.AreEqual(12, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
            AssertHelper.AssertList(new int[] { 1 }, result[1]);
            AssertHelper.AssertList(new int[] { 2 }, result[2]);
            AssertHelper.AssertList(new int[] { 1, 2 }, result[3]);
            AssertHelper.AssertList(new int[] { 2, 2 }, result[4]);
            AssertHelper.AssertList(new int[] { 1, 2, 2 }, result[5]);
            AssertHelper.AssertList(new int[] { 3 }, result[6]);
            AssertHelper.AssertList(new int[] { 1, 3 }, result[7]);
            AssertHelper.AssertList(new int[] { 2, 3 }, result[8]);
            AssertHelper.AssertList(new int[] { 1, 2, 3 }, result[9]);
            AssertHelper.AssertList(new int[] { 2, 2, 3 }, result[10]);
            AssertHelper.AssertList(new int[] { 1, 2, 2, 3 }, result[11]);
        }
    }
}

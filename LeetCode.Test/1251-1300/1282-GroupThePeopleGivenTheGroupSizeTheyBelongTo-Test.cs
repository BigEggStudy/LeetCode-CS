using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1282_GroupThePeopleGivenTheGroupSizeTheyBelongTo_Test
    {
        [TestMethod]
        public void GroupThePeople_1()
        {
            var solution = new _1282_GroupThePeopleGivenTheGroupSizeTheyBelongTo();
            var result = solution.GroupThePeople(new int[] { 3, 3, 3, 3, 3, 1, 3 });
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 6 },
                new int[] { 5 },
            }, result);
        }

        [TestMethod]
        public void GroupThePeople_2()
        {
            var solution = new _1282_GroupThePeopleGivenTheGroupSizeTheyBelongTo();
            var result = solution.GroupThePeople(new int[] { 2, 1, 3, 3, 3, 2 });
            AssertHelper.AssertList(new List<IList<int>> {
                new int[] { 0, 5 },
                new int[] { 1 },
                new int[] { 2, 3, 4 },
            }, result);
        }
    }
}

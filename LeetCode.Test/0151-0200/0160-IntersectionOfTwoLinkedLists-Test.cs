using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0160_IntersectionOfTwoLinkedLists_Test
    {
        [TestMethod]
        public void GetIntersectionNode_1()
        {
            var root3 = TestHelper.GenerateList(new int[] { 8, 4, 5 });
            var root1 = TestHelper.GenerateList(new int[] { 4, 1 });
            var root2 = TestHelper.GenerateList(new int[] { 5, 0, 1 });
            root1.next.next = root3;
            root2.next.next.next = root3;

            var solution = new _0160_IntersectionOfTwoLinkedLists();
            var result = solution.GetIntersectionNode(root1, root2);
            Assert.AreEqual(8, result.val);
        }

        [TestMethod]
        public void GetIntersectionNode_2()
        {
            var root3 = TestHelper.GenerateList(new int[] { 2, 4 });
            var root1 = TestHelper.GenerateList(new int[] { 0, 9, 1 });
            var root2 = TestHelper.GenerateList(new int[] { 3 });
            root1.next.next.next = root3;
            root2.next = root3;

            var solution = new _0160_IntersectionOfTwoLinkedLists();
            var result = solution.GetIntersectionNode(root1, root2);
            Assert.AreEqual(2, result.val);
        }

        [TestMethod]
        public void GetIntersectionNode_3()
        {
            var root1 = TestHelper.GenerateList(new int[] { 2, 6, 4 });
            var root2 = TestHelper.GenerateList(new int[] { 1, 5 });

            var solution = new _0160_IntersectionOfTwoLinkedLists();
            var result = solution.GetIntersectionNode(root1, root2);
            Assert.IsNull(result);
        }
    }
}

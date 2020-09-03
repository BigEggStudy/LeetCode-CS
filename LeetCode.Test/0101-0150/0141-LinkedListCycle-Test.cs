using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0141_LinkedListCycle_Test
    {
        [TestMethod]
        public void HasCycle_1()
        {
            var root = TestHelper.GenerateList(new int[] { 3, 2, 0, -4 });
            root.next.next.next.next = root.next;

            var solution = new _0141_LinkedListCycle();
            var result = solution.HasCycle(root);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasCycle_2()
        {
            var root = TestHelper.GenerateList(new int[] { 1, 2 });
            root.next.next = root;

            var solution = new _0141_LinkedListCycle();
            var result = solution.HasCycle(root);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasCycle_3()
        {
            var root = TestHelper.GenerateList(new int[] { 1 });

            var solution = new _0141_LinkedListCycle();
            var result = solution.HasCycle(root);
            Assert.IsFalse(result);
        }
    }
}

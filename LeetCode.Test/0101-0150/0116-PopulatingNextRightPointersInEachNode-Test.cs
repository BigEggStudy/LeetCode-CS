using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0116_PopulatingNextRightPointersInEachNode_Test
    {
        [TestMethod]
        public void ConnectTest()
        {
            var solution = new _0116_PopulatingNextRightPointersInEachNode();
            var root = TestHelper.GenerateLinkTree(new int?[] { 1, 2, 3, 4, 5, 6, 7 });
            var newRoot = solution.Connect(root);

            Assert.AreEqual(1, newRoot.val);
            Assert.IsNull(newRoot.next);
            Assert.AreEqual(2, newRoot.left.val);
            Assert.AreEqual(3, newRoot.right.val);

            var node2 = newRoot.left;
            Assert.AreEqual(2, node2.val);
            Assert.AreEqual(3, node2.next.val);
            Assert.AreEqual(4, node2.left.val);
            Assert.AreEqual(5, node2.right.val);
            var node3 = newRoot.right;
            Assert.AreEqual(3, node3.val);
            Assert.IsNull(node3.next);
            Assert.AreEqual(6, node3.left.val);
            Assert.AreEqual(7, node3.right.val);

            var node4 = node2.left;
            Assert.AreEqual(4, node4.val);
            Assert.AreEqual(5, node4.next.val);
            var node5 = node2.right;
            Assert.AreEqual(5, node5.val);
            Assert.AreEqual(6, node5.next.val);
            var node6 = node3.left;
            Assert.AreEqual(6, node6.val);
            Assert.AreEqual(7, node6.next.val);
            var node7 = node3.right;
            Assert.AreEqual(7, node7.val);
            Assert.IsNull(node7.next);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode._0138_CopyListWithRandomPointer;

namespace LeetCode.Test
{
    [TestClass]
    public class _0138_CopyListWithRandomPointer_Test
    {
        [TestMethod]
        public void CopyRandomList_1()
        {
            var node1 = new Node(7);
            var node2 = new Node(13);
            var node3 = new Node(11);
            var node4 = new Node(10);
            var node5 = new Node(1);
            node1.next = node2;
            node2.next = node3;
            node2.random = node1;
            node3.next = node4;
            node3.random = node5;
            node4.next = node5;
            node4.random = node3;
            node5.random = node1;

            var solution = new _0138_CopyListWithRandomPointer();
            var resultNode1 = solution.CopyRandomList(node1);
            Assert.AreEqual(7, resultNode1.val);
            Assert.AreEqual(13, resultNode1.next.val);
            Assert.IsNull(resultNode1.random);

            var resultNode2 = resultNode1.next;
            Assert.AreEqual(13, resultNode2.val);
            Assert.AreEqual(11, resultNode2.next.val);
            Assert.AreEqual(7, resultNode2.random.val);

            var resultNode3 = resultNode2.next;
            Assert.AreEqual(11, resultNode3.val);
            Assert.AreEqual(10, resultNode3.next.val);
            Assert.AreEqual(1, resultNode3.random.val);

            var resultNode4 = resultNode3.next;
            Assert.AreEqual(10, resultNode4.val);
            Assert.AreEqual(1, resultNode4.next.val);
            Assert.AreEqual(11, resultNode4.random.val);

            var resultNode5 = resultNode4.next;
            Assert.AreEqual(1, resultNode5.val);
            Assert.IsNull(resultNode5.next);
            Assert.AreEqual(7, resultNode5.random.val);
        }

        [TestMethod]
        public void CopyRandomList_2()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            node1.next = node2;
            node1.random = node2;
            node2.random = node2;

            var solution = new _0138_CopyListWithRandomPointer();
            var resultNode1 = solution.CopyRandomList(node1);
            Assert.AreEqual(1, resultNode1.val);
            Assert.AreEqual(2, resultNode1.next.val);
            Assert.AreEqual(2, resultNode1.random.val);

            var resultNode2 = resultNode1.next;
            Assert.AreEqual(2, resultNode2.val);
            Assert.IsNull(resultNode2.next);
            Assert.AreEqual(2, resultNode2.random.val);
        }

        [TestMethod]
        public void CopyRandomList_3()
        {
            var node1 = new Node(3);
            var node2 = new Node(3);
            var node3 = new Node(3);
            node1.next = node2;
            node2.next = node3;
            node2.random = node1;

            var solution = new _0138_CopyListWithRandomPointer();
            var resultNode1 = solution.CopyRandomList(node1);
            Assert.AreEqual(3, resultNode1.val);
            Assert.AreEqual(3, resultNode1.next.val);
            Assert.IsNull(resultNode1.random);

            var resultNode2 = resultNode1.next;
            Assert.AreEqual(3, resultNode2.val);
            Assert.AreEqual(3, resultNode2.next.val);
            Assert.AreEqual(3, resultNode2.random.val);

            var resultNode3 = resultNode2.next;
            Assert.AreEqual(3, resultNode3.val);
            Assert.IsNull(resultNode3.next);
            Assert.IsNull(resultNode3.random);
        }

        [TestMethod]
        public void CopyRandomList_4()
        {
            var solution = new _0138_CopyListWithRandomPointer();
            var resultNode1 = solution.CopyRandomList(null);
            Assert.IsNull(resultNode1);
        }
    }
}

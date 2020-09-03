using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode._0426_ConvertBinarySearchTreeToSortedDoublyLinkedList;

namespace LeetCode.Test
{
    [TestClass]
    public class _0426_ConvertBinarySearchTreeToSortedDoublyLinkedList_Test
    {
        [TestMethod]
        public void TreeToDoublyList_1()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);

            node4.left = node2;
            node4.right = node5;
            node2.left = node1;
            node2.right = node3;

            var solution = new _0426_ConvertBinarySearchTreeToSortedDoublyLinkedList();
            var result = solution.TreeToDoublyList(node4);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.right.val);
            Assert.AreEqual(5, result.left.val);

            var result2 = result.right;
            Assert.AreEqual(3, result2.right.val);
            Assert.AreEqual(1, result2.left.val);

            var result3 = result2.right;
            Assert.AreEqual(4, result3.right.val);
            Assert.AreEqual(2, result3.left.val);

            var result4 = result3.right;
            Assert.AreEqual(5, result4.right.val);
            Assert.AreEqual(3, result4.left.val);

            var result5 = result4.right;
            Assert.AreEqual(1, result5.right.val);
            Assert.AreEqual(4, result5.left.val);
        }

        [TestMethod]
        public void TreeToDoublyList_2()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);

            node2.left = node1;
            node2.right = node3;

            var solution = new _0426_ConvertBinarySearchTreeToSortedDoublyLinkedList();
            var result = solution.TreeToDoublyList(node2);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(2, result.right.val);
            Assert.AreEqual(3, result.left.val);

            var result2 = result.right;
            Assert.AreEqual(3, result2.right.val);
            Assert.AreEqual(1, result2.left.val);

            var result3 = result2.right;
            Assert.AreEqual(1, result3.right.val);
            Assert.AreEqual(2, result3.left.val);
        }

        [TestMethod]
        public void TreeToDoublyList_3()
        {
            var solution = new _0426_ConvertBinarySearchTreeToSortedDoublyLinkedList();
            var result = solution.TreeToDoublyList(null);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TreeToDoublyList_4()
        {
            var root = new Node(1);

            var solution = new _0426_ConvertBinarySearchTreeToSortedDoublyLinkedList();
            var result = solution.TreeToDoublyList(root);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(1, result.left.val);
            Assert.AreEqual(1, result.right.val);
        }
    }
}

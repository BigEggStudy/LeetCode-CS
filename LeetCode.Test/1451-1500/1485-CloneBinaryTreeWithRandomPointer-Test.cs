using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode._1485_CloneBinaryTreeWithRandomPointer;

namespace LeetCode.Test
{
    [TestClass]
    public class _1485_CloneBinaryTreeWithRandomPointer_Test
    {
        [TestMethod]
        public void CopyRandomBinaryTree_1()
        {
            var node1 = new Node(1);
            var node2 = new Node(4);
            var node3 = new Node(7);

            node1.right = node2;
            node2.left = node3;
            node2.random = node3;
            node3.random = node1;

            var solution = new _1485_CloneBinaryTreeWithRandomPointer();
            var newNode1 = solution.CopyRandomBinaryTree(node1);
            var newNode2 = newNode1.right;
            var newNode3 = newNode2.left;

            Assert.IsInstanceOfType(newNode1, typeof(NodeCopy));
            Assert.AreEqual(1, newNode1.val);
            Assert.IsNull(newNode1.random);
            Assert.IsNull(newNode1.left);

            Assert.IsInstanceOfType(newNode2, typeof(NodeCopy));
            Assert.AreEqual(4, newNode2.val);
            Assert.IsNotNull(newNode2.random);
            Assert.AreEqual(newNode3, newNode2.random);
            Assert.IsNull(newNode2.right);

            Assert.IsInstanceOfType(newNode3, typeof(NodeCopy));
            Assert.AreEqual(7, newNode3.val);
            Assert.IsNotNull(newNode3.random);
            Assert.AreEqual(newNode1, newNode3.random);
            Assert.IsNull(newNode3.left);
            Assert.IsNull(newNode3.right);
        }

        [TestMethod]
        public void CopyRandomBinaryTree_2()
        {
            var node1 = new Node(1);
            var node2 = new Node(1);
            var node3 = new Node(1);
            var node4 = new Node(1);

            node1.right = node2;
            node1.random = node3;
            node2.right = node3;
            node2.random = node1;
            node3.left = node4;
            node3.random = node4;
            node4.random = node4;

            var solution = new _1485_CloneBinaryTreeWithRandomPointer();
            var newNode1 = solution.CopyRandomBinaryTree(node1);
            var newNode2 = newNode1.right;
            var newNode3 = newNode2.right;
            var newNode4 = newNode3.left;

            Assert.IsInstanceOfType(newNode1, typeof(NodeCopy));
            Assert.AreEqual(1, newNode1.val);
            Assert.AreEqual(newNode3, newNode1.random);
            Assert.IsNull(newNode1.left);

            Assert.IsInstanceOfType(newNode2, typeof(NodeCopy));
            Assert.AreEqual(1, newNode2.val);
            Assert.AreEqual(newNode1, newNode2.random);
            Assert.IsNull(newNode2.left);

            Assert.IsInstanceOfType(newNode3, typeof(NodeCopy));
            Assert.AreEqual(1, newNode3.val);
            Assert.AreEqual(newNode4, newNode3.random);
            Assert.IsNull(newNode3.right);

            Assert.IsInstanceOfType(newNode4, typeof(NodeCopy));
            Assert.AreEqual(1, newNode4.val);
            Assert.AreEqual(newNode4, newNode4.random);
            Assert.IsNull(newNode4.left);
            Assert.IsNull(newNode4.right);
        }

        [TestMethod]
        public void CopyRandomBinaryTree_3()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);
            var node6 = new Node(6);
            var node7 = new Node(7);

            node1.left = node2;
            node1.right = node3;
            node1.random = node7;
            node2.left = node4;
            node2.right = node5;
            node2.random = node6;
            node3.left = node6;
            node3.right = node7;
            node3.random = node5;
            node4.random = node4;
            node5.random = node3;
            node6.random = node2;
            node7.random = node1;

            var solution = new _1485_CloneBinaryTreeWithRandomPointer();
            var newNode1 = solution.CopyRandomBinaryTree(node1);
            var newNode2 = newNode1.left;
            var newNode3 = newNode1.right;
            var newNode4 = newNode2.left;
            var newNode5 = newNode2.right;
            var newNode6 = newNode3.left;
            var newNode7 = newNode3.right;

            Assert.IsInstanceOfType(newNode1, typeof(NodeCopy));
            Assert.AreEqual(1, newNode1.val);
            Assert.AreEqual(newNode7, newNode1.random);

            Assert.IsInstanceOfType(newNode2, typeof(NodeCopy));
            Assert.AreEqual(2, newNode2.val);
            Assert.AreEqual(newNode6, newNode2.random);

            Assert.IsInstanceOfType(newNode3, typeof(NodeCopy));
            Assert.AreEqual(3, newNode3.val);
            Assert.AreEqual(newNode5, newNode3.random);

            Assert.IsInstanceOfType(newNode4, typeof(NodeCopy));
            Assert.AreEqual(4, newNode4.val);
            Assert.AreEqual(newNode4, newNode4.random);
            Assert.IsNull(newNode4.left);
            Assert.IsNull(newNode4.right);

            Assert.IsInstanceOfType(newNode5, typeof(NodeCopy));
            Assert.AreEqual(5, newNode5.val);
            Assert.AreEqual(newNode3, newNode5.random);
            Assert.IsNull(newNode5.left);
            Assert.IsNull(newNode5.right);

            Assert.IsInstanceOfType(newNode6, typeof(NodeCopy));
            Assert.AreEqual(6, newNode6.val);
            Assert.AreEqual(newNode2, newNode6.random);
            Assert.IsNull(newNode6.left);
            Assert.IsNull(newNode6.right);

            Assert.IsInstanceOfType(newNode7, typeof(NodeCopy));
            Assert.AreEqual(7, newNode7.val);
            Assert.AreEqual(newNode1, newNode7.random);
            Assert.IsNull(newNode7.left);
            Assert.IsNull(newNode7.right);
        }

        [TestMethod]
        public void CopyRandomBinaryTree_4()
        {
            var solution = new _1485_CloneBinaryTreeWithRandomPointer();
            var newNode1 = solution.CopyRandomBinaryTree(null);
            Assert.IsNull(newNode1);
        }

        [TestMethod]
        public void CopyRandomBinaryTree_5()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(1);

            node1.right = node2;
            node2.right = node3;

            var solution = new _1485_CloneBinaryTreeWithRandomPointer();
            var newNode1 = solution.CopyRandomBinaryTree(node1);
            var newNode2 = newNode1.right;
            var newNode3 = newNode2.right;

            Assert.IsInstanceOfType(newNode1, typeof(NodeCopy));
            Assert.AreEqual(1, newNode1.val);
            Assert.IsNull(newNode1.random);
            Assert.IsNull(newNode1.left);

            Assert.IsInstanceOfType(newNode2, typeof(NodeCopy));
            Assert.AreEqual(2, newNode2.val);
            Assert.IsNull(newNode2.random);
            Assert.IsNull(newNode2.left);

            Assert.IsInstanceOfType(newNode3, typeof(NodeCopy));
            Assert.AreEqual(1, newNode3.val);
            Assert.IsNull(newNode3.random);
            Assert.IsNull(newNode3.left);
            Assert.IsNull(newNode3.right);
        }
    }
}

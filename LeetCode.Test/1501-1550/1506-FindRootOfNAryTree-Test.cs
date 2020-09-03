using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._1506_FindRootOfNAryTree;

namespace LeetCode.Test
{
    [TestClass]
    public class _1506_FindRootOfNAryTree_Test
    {
        [TestMethod]
        public void FindRoot_1()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);
            var node6 = new Node(6);

            node1.children.Add(node3);
            node1.children.Add(node2);
            node1.children.Add(node4);
            node3.children.Add(node5);
            node3.children.Add(node6);

            var list = new List<Node>() { node1, node2, node3, node4, node5, node6 };

            var solution = new _1506_FindRootOfNAryTree();
            var result = solution.FindRoot(list);
            Assert.AreEqual(1, result.val);
        }

        [TestMethod]
        public void FindRoot_2()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);
            var node6 = new Node(6);
            var node7 = new Node(7);
            var node8 = new Node(8);
            var node9 = new Node(9);
            var node10 = new Node(10);
            var node11 = new Node(11);
            var node12 = new Node(12);
            var node13 = new Node(13);
            var node14 = new Node(14);

            node1.children.Add(node2);
            node1.children.Add(node3);
            node1.children.Add(node4);
            node1.children.Add(node5);
            node3.children.Add(node6);
            node3.children.Add(node7);
            node4.children.Add(node8);
            node5.children.Add(node9);
            node5.children.Add(node10);
            node7.children.Add(node11);
            node8.children.Add(node12);
            node9.children.Add(node13);
            node11.children.Add(node14);

            var list = new List<Node>() { node1, node2, node3, node4, node5, node6, node7, node8, node9, node10, node11, node12, node13, node14 };

            var solution = new _1506_FindRootOfNAryTree();
            var result = solution.FindRoot(list);
            Assert.AreEqual(1, result.val);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0428_SerializeAndDeserializeNAryTree;

namespace LeetCode.Test
{
    [TestClass]
    public class _0428_SerializeAndDeserializeNAryTree_Test
    {
        [TestMethod]
        public void SerializeAndDeserializeNAryTreeTest_1()
        {
            var node1 = new Node(1, new List<Node>());
            var node2 = new Node(2, new List<Node>());
            var node3 = new Node(3, new List<Node>());
            var node4 = new Node(4, new List<Node>());
            var node5 = new Node(5, new List<Node>());
            var node6 = new Node(6, new List<Node>());

            node1.children.Add(node3);
            node1.children.Add(node2);
            node1.children.Add(node4);
            node3.children.Add(node5);
            node3.children.Add(node6);

            var solution = new _0428_SerializeAndDeserializeNAryTree();
            var node = solution.deserialize(solution.serialize(node1));

            Assert.AreEqual(1, node.val);
            Assert.AreEqual(3, node.children.Count);

            Assert.AreEqual(3, node.children[0].val);
            Assert.AreEqual(2, node.children[0].children.Count);
            Assert.AreEqual(2, node.children[1].val);
            Assert.AreEqual(0, node.children[1].children.Count);
            Assert.AreEqual(4, node.children[2].val);
            Assert.AreEqual(0, node.children[2].children.Count);

            Assert.AreEqual(5, node.children[0].children[0].val);
            Assert.AreEqual(0, node.children[0].children[0].children.Count);
            Assert.AreEqual(6, node.children[0].children[1].val);
            Assert.AreEqual(0, node.children[0].children[1].children.Count);
        }

        [TestMethod]
        public void SerializeAndDeserializeNAryTreeTest_2()
        {
            var node1 = new Node(1, new List<Node>());
            var node2 = new Node(2, new List<Node>());
            var node3 = new Node(3, new List<Node>());
            var node4 = new Node(4, new List<Node>());
            var node5 = new Node(5, new List<Node>());
            var node6 = new Node(6, new List<Node>());
            var node7 = new Node(7, new List<Node>());
            var node8 = new Node(8, new List<Node>());
            var node9 = new Node(9, new List<Node>());
            var node10 = new Node(10, new List<Node>());
            var node11 = new Node(11, new List<Node>());
            var node12 = new Node(12, new List<Node>());
            var node13 = new Node(13, new List<Node>());
            var node14 = new Node(14, new List<Node>());

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

            var solution = new _0428_SerializeAndDeserializeNAryTree();
            var node = solution.deserialize(solution.serialize(node1));

            Assert.AreEqual(1, node.val);
            Assert.AreEqual(4, node.children.Count);

            Assert.AreEqual(2, node.children[0].val);
            Assert.AreEqual(0, node.children[0].children.Count);
            Assert.AreEqual(3, node.children[1].val);
            Assert.AreEqual(2, node.children[1].children.Count);
            Assert.AreEqual(4, node.children[2].val);
            Assert.AreEqual(1, node.children[2].children.Count);
            Assert.AreEqual(5, node.children[3].val);
            Assert.AreEqual(2, node.children[3].children.Count);

            Assert.AreEqual(6, node.children[1].children[0].val);
            Assert.AreEqual(0, node.children[1].children[0].children.Count);
            Assert.AreEqual(7, node.children[1].children[1].val);
            Assert.AreEqual(1, node.children[1].children[1].children.Count);

            Assert.AreEqual(8, node.children[2].children[0].val);
            Assert.AreEqual(1, node.children[2].children[0].children.Count);

            Assert.AreEqual(9, node.children[3].children[0].val);
            Assert.AreEqual(1, node.children[3].children[0].children.Count);
            Assert.AreEqual(10, node.children[3].children[1].val);
            Assert.AreEqual(0, node.children[3].children[1].children.Count);

            Assert.AreEqual(11, node.children[1].children[1].children[0].val);
            Assert.AreEqual(1, node.children[1].children[1].children[0].children.Count);

            Assert.AreEqual(12, node.children[2].children[0].children[0].val);
            Assert.AreEqual(0, node.children[2].children[0].children[0].children.Count);

            Assert.AreEqual(13, node.children[3].children[0].children[0].val);
            Assert.AreEqual(0, node.children[3].children[0].children[0].children.Count);

            Assert.AreEqual(14, node.children[1].children[1].children[0].children[0].val);
            Assert.AreEqual(0, node.children[1].children[1].children[0].children[0].children.Count);
        }
    }
}

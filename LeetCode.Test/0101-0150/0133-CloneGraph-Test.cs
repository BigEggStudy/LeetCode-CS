using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0133_CloneGraph;

namespace LeetCode.Test
{
    [TestClass]
    public class _0133_CloneGraph_Test
    {
        [TestMethod]
        public void CloneGraphTest()
        {
            var node1 = new Node(1, new List<Node>());
            var node2 = new Node(2, new List<Node>());
            var node3 = new Node(3, new List<Node>());
            var node4 = new Node(4, new List<Node>());
            node1.neighbors.Add(node2); node1.neighbors.Add(node4);
            node2.neighbors.Add(node1); node2.neighbors.Add(node3);
            node3.neighbors.Add(node2); node3.neighbors.Add(node4);
            node4.neighbors.Add(node1); node4.neighbors.Add(node3);

            var solution = new _0133_CloneGraph();
            var newNode = solution.CloneGraph(node1);
            Assert.AreEqual(1, newNode.val);
            Assert.AreEqual(2, newNode.neighbors[0].val);
            Assert.AreEqual(4, newNode.neighbors[1].val);
            Assert.AreEqual(1, newNode.neighbors[0].neighbors[0].val);
            Assert.AreEqual(3, newNode.neighbors[0].neighbors[1].val);
            Assert.AreEqual(1, newNode.neighbors[1].neighbors[0].val);
            Assert.AreEqual(3, newNode.neighbors[1].neighbors[1].val);
            Assert.AreEqual(2, newNode.neighbors[0].neighbors[1].neighbors[0].val);
            Assert.AreEqual(4, newNode.neighbors[0].neighbors[1].neighbors[1].val);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0559_MaximumDepthOfNAryTree;

namespace LeetCode.Test
{
    [TestClass]
    public class _0559_MaximumDepthOfNAryTree_Test
    {
        [TestMethod]
        public void MaxDepth_1()
        {
            var root = new Node(1, new List<Node>()
            {
                new Node(3, new List<Node>()
                {
                    new Node(5),
                    new Node(6),
                }),
                new Node(2),
                new Node(4),
            });

            var solution = new _0559_MaximumDepthOfNAryTree();
            var result = solution.MaxDepth(root);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MaxDepth_2()
        {
            var root = new Node(1, new List<Node>()
            {
                new Node(2),
                new Node(3, new List<Node>()
                {
                    new Node(6),
                    new Node(7, new List<Node>()
                    {
                        new Node(11, new List<Node>()
                        {
                            new Node(14),
                        })
                    }),
                }),
                new Node(4, new List<Node>()
                {
                    new Node(8, new List<Node>()
                    {
                        new Node(12),
                    })
                }),
                new Node(5, new List<Node>()
                {
                    new Node(9, new List<Node>()
                    {
                        new Node(13),
                    }),
                    new Node(10),
                }),
            });

            var solution = new _0559_MaximumDepthOfNAryTree();
            var result = solution.MaxDepth(root);
            Assert.AreEqual(5, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0429_NAryTreeLevelOrderTraversal;

namespace LeetCode.Test
{
    [TestClass]
    public class _0429_NAryTreeLevelOrderTraversal_Test
    {
        [TestMethod]
        public void LevelOrder_1()
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


            var solution = new _0429_NAryTreeLevelOrderTraversal();
            var result = solution.LevelOrder(root);
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 1 },
                new int[] { 3, 2, 4 },
                new int[] { 5, 6 },
            }, result);
        }

        [TestMethod]
        public void LevelOrder_2()
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

            var solution = new _0429_NAryTreeLevelOrderTraversal();
            var result = solution.LevelOrder(root);
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 1 },
                new int[] { 2, 3, 4, 5 },
                new int[] { 6, 7, 8, 9, 10 },
                new int[] { 11, 12, 13 },
                new int[] { 14 },
            }, result);
        }
    }
}

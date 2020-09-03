using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0590_NAryTreePostorderTraversal;

namespace LeetCode.Test
{
    [TestClass]
    public class _0590_NAryTreePostorderTraversal_Test
    {
        [TestMethod]
        public void Postorder_1()
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

            var solution = new _0590_NAryTreePostorderTraversal();
            var result = solution.Postorder(root);
            AssertHelper.AssertList(new int[] { 5, 6, 3, 2, 4, 1 }, result);
        }

        [TestMethod]
        public void Postorder_2()
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

            var solution = new _0590_NAryTreePostorderTraversal();
            var result = solution.Postorder(root);
            AssertHelper.AssertList(new int[] { 2, 6, 14, 11, 7, 3, 12, 8, 4, 13, 9, 10, 5, 1 }, result);
        }

        [TestMethod]
        public void Postorder_3()
        {
            var solution = new _0590_NAryTreePostorderTraversal();
            var result = solution.Postorder(null);
            Assert.AreEqual(0, result.Count);
        }
    }
}

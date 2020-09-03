using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0589_NAryTreePreorderTraversal;

namespace LeetCode.Test
{
    [TestClass]
    public class _0589_NAryTreePreorderTraversal_Test
    {
        [TestMethod]
        public void Preorder_1()
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

            var solution = new _0589_NAryTreePreorderTraversal();
            var result = solution.Preorder(root);
            AssertHelper.AssertList(new int[] { 1, 3, 5, 6, 2, 4 }, result);
        }

        [TestMethod]
        public void Preorder_2()
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

            var solution = new _0589_NAryTreePreorderTraversal();
            var result = solution.Preorder(root);
            AssertHelper.AssertList(new int[] { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 }, result);
        }

        [TestMethod]
        public void Preorder_3()
        {
            var solution = new _0589_NAryTreePreorderTraversal();
            var result = solution.Preorder(null);
            Assert.AreEqual(0, result.Count);
        }
    }
}

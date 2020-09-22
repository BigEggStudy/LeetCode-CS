using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode._0510_InorderSuccessorInBSTII;

namespace LeetCode.Test
{
    [TestClass]
    public class _0510_InorderSuccessorInBSTII_Test
    {
        [TestMethod]
        public void InorderSuccessor_1()
        {
            var node1 = new Node() { val = 1 };
            var node2 = new Node() { val = 2 };
            var node3 = new Node() { val = 3 };

            node2.left = node1;
            node2.right = node3;
            node1.parent = node2;
            node3.parent = node2;

            var solution = new _0510_InorderSuccessorInBSTII();
            var result = solution.InorderSuccessor(node1);
            Assert.AreEqual(2, result.val);
        }

        [TestMethod]
        public void InorderSuccessor_2()
        {
            var node1 = new Node() { val = 1 };
            var node2 = new Node() { val = 2 };
            var node3 = new Node() { val = 3 };
            var node4 = new Node() { val = 4 };
            var node5 = new Node() { val = 5 };
            var node6 = new Node() { val = 6 };

            node2.left = node1;
            node1.parent = node2;

            node3.left = node2;
            node2.parent = node3;
            node3.right = node4;
            node4.parent = node3;

            node5.left = node3;
            node3.parent = node5;
            node5.right = node6;
            node6.parent = node5;

            var solution = new _0510_InorderSuccessorInBSTII();
            var result = solution.InorderSuccessor(node6);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void InorderSuccessor_3()
        {
            var node2 = new Node() { val = 2 };
            var node3 = new Node() { val = 3 };
            var node4 = new Node() { val = 4 };
            var node6 = new Node() { val = 6 };
            var node7 = new Node() { val = 7 };
            var node9 = new Node() { val = 9 };
            var node13 = new Node() { val = 13 };
            var node15 = new Node() { val = 15 };
            var node17 = new Node() { val = 17 };
            var node18 = new Node() { val = 18 };
            var node20 = new Node() { val = 20 };

            node3.left = node2;
            node2.parent = node3;
            node3.right = node4;
            node4.parent = node3;

            node13.left = node9;
            node9.parent = node13;

            node7.right = node13;
            node13.parent = node7;

            node6.left = node3;
            node3.parent = node6;
            node6.right = node7;
            node7.parent = node6;

            node18.left = node17;
            node17.parent = node18;
            node18.right = node20;
            node20.parent = node18;

            node15.left = node6;
            node6.parent = node15;
            node15.right = node18;
            node18.parent = node15;

            var solution = new _0510_InorderSuccessorInBSTII();
            var result = solution.InorderSuccessor(node15);
            Assert.AreEqual(17, result.val);
        }

        [TestMethod]
        public void InorderSuccessor_4()
        {
            var node2 = new Node() { val = 2 };
            var node3 = new Node() { val = 3 };
            var node4 = new Node() { val = 4 };
            var node6 = new Node() { val = 6 };
            var node7 = new Node() { val = 7 };
            var node9 = new Node() { val = 9 };
            var node13 = new Node() { val = 13 };
            var node15 = new Node() { val = 15 };
            var node17 = new Node() { val = 17 };
            var node18 = new Node() { val = 18 };
            var node20 = new Node() { val = 20 };

            node3.left = node2;
            node2.parent = node3;
            node3.right = node4;
            node4.parent = node3;

            node13.left = node9;
            node9.parent = node13;

            node7.right = node13;
            node13.parent = node7;

            node6.left = node3;
            node3.parent = node6;
            node6.right = node7;
            node7.parent = node6;

            node18.left = node17;
            node17.parent = node18;
            node18.right = node20;
            node20.parent = node18;

            node15.left = node6;
            node6.parent = node15;
            node15.right = node18;
            node18.parent = node15;

            var solution = new _0510_InorderSuccessorInBSTII();
            var result = solution.InorderSuccessor(node13);
            Assert.AreEqual(15, result.val);
        }

        [TestMethod]
        public void InorderSuccessor_5()
        {
            var node0 = new Node() { val = 0 };

            var solution = new _0510_InorderSuccessorInBSTII();
            var result = solution.InorderSuccessor(node0);
            Assert.AreEqual(null, result);
        }
    }
}

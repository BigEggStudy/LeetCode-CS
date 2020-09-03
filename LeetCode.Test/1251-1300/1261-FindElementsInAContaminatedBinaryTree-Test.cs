using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1261_FindElementsInAContaminatedBinaryTree_Test
    {
        [TestMethod]
        public void FindElementsInAContaminatedBinaryTree_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { -1, null, -1 });

            var solution = new _1261_FindElementsInAContaminatedBinaryTree(root);
            Assert.IsFalse(solution.Find(1));
            Assert.IsTrue(solution.Find(2));
        }

        [TestMethod]
        public void FindElementsInAContaminatedBinaryTree_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { -1, -1, -1, -1, -1 });

            var solution = new _1261_FindElementsInAContaminatedBinaryTree(root);
            Assert.IsTrue(solution.Find(1));
            Assert.IsTrue(solution.Find(3));
            Assert.IsFalse(solution.Find(5));
        }

        [TestMethod]
        public void FindElementsInAContaminatedBinaryTree_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { -1, null, -1, -1, null, -1 });

            var solution = new _1261_FindElementsInAContaminatedBinaryTree(root);
            Assert.IsTrue(solution.Find(2));
            Assert.IsFalse(solution.Find(3));
            Assert.IsFalse(solution.Find(4));
            Assert.IsTrue(solution.Find(5));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1457_PseudoPalindromicPathsInABinaryTree_Test
    {
        [TestMethod]
        public void PseudoPalindromicPaths_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 2, 3, 1, 3, 1, null, 1 });

            var solution = new _1457_PseudoPalindromicPathsInABinaryTree();
            var result = solution.PseudoPalindromicPaths(root);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void PseudoPalindromicPaths_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 2, 1, 1, 1, 3, null, null, null, null, null, 1 });

            var solution = new _1457_PseudoPalindromicPathsInABinaryTree();
            var result = solution.PseudoPalindromicPaths(root);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void PseudoPalindromicPaths_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 9 });

            var solution = new _1457_PseudoPalindromicPathsInABinaryTree();
            var result = solution.PseudoPalindromicPaths(root);
            Assert.AreEqual(1, result);
        }
    }
}

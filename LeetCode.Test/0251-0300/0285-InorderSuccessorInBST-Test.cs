using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0285_InorderSuccessorInBST_Test
    {
        [TestMethod]
        public void InorderSuccessor_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 2, 1, 3 });

            var solution = new _0285_InorderSuccessorInBST();
            var result = solution.InorderSuccessor(root, root.left);
            Assert.AreEqual(2, result.val);
        }

        [TestMethod]
        public void InorderSuccessor_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 5, 3, 6, 2, 4, null, null, 1 });

            var solution = new _0285_InorderSuccessorInBST();
            var result = solution.InorderSuccessor(root, root.right);
            Assert.IsNull(result);
        }
    }
}

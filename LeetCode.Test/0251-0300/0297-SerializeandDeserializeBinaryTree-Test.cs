using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0297_SerializeandDeserializeBinaryTree_Test
    {
        [TestMethod]
        public void SerializeandDeserializeBinaryTreeTest()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, null, null, 4, 5 });
            var solution = new _0297_SerializeandDeserializeBinaryTree();
            var newRoot = solution.Deserialize(solution.Serialize(root));

            AssertHelper.AssertTree(root, newRoot);
        }
    }
}

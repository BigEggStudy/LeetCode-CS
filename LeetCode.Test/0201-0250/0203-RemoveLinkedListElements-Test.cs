using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0203_RemoveLinkedListElements_Test
    {
        [TestMethod]
        public void RemoveElements_1()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2, 6, 3, 4, 5, 6 });

            var solution = new _0203_RemoveLinkedListElements();
            var result = solution.RemoveElements(head, 6);
            AssertHelper.AssertLinkList(new int[] { 1, 2, 3, 4, 5 }, result);
        }
    }
}

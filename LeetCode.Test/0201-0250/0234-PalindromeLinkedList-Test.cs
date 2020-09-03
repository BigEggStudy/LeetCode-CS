using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0234_PalindromeLinkedList_Test
    {
        [TestMethod]
        public void IsPalindrome_1()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2 });

            var solution = new _0234_PalindromeLinkedList();
            var result = solution.IsPalindrome(head);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_2()
        {
            var head = TestHelper.GenerateList(new int[] { 1, 2, 2, 1 });

            var solution = new _0234_PalindromeLinkedList();
            var result = solution.IsPalindrome(head);
            Assert.IsTrue(result);
        }
    }
}

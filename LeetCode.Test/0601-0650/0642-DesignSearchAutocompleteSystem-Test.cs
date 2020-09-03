using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0642_DesignSearchAutocompleteSystem_Test
    {
        [TestMethod]
        public void InputTest()
        {
            var solution = new _0642_DesignSearchAutocompleteSystem(new string[] { "i love you", "island", "ironman", "i love leetcode" }, new int[] { 5, 3, 2, 2 });

            // Round 1
            var result = solution.Input('i');
            AssertHelper.AssertList(new string[] { "i love you", "island", "i love leetcode" }, result);

            result = solution.Input(' ');
            AssertHelper.AssertList(new string[] { "i love you", "i love leetcode" }, result);

            result = solution.Input('a');
            AssertHelper.AssertList(new string[] { }, result);

            result = solution.Input('#');
            AssertHelper.AssertList(new string[] { }, result);

            // Round 2
            result = solution.Input('i');
            AssertHelper.AssertList(new string[] { "i love you", "island", "i love leetcode" }, result);

            result = solution.Input(' ');
            AssertHelper.AssertList(new string[] { "i love you", "i love leetcode", "i a" }, result);

            result = solution.Input('a');
            AssertHelper.AssertList(new string[] { "i a" }, result);

            result = solution.Input('#');
            AssertHelper.AssertList(new string[] { }, result);

            // Round 3
            result = solution.Input('i');
            AssertHelper.AssertList(new string[] { "i love you", "island", "i a" }, result);

            result = solution.Input(' ');
            AssertHelper.AssertList(new string[] { "i love you", "i a", "i love leetcode" }, result);

            result = solution.Input('a');
            AssertHelper.AssertList(new string[] { "i a" }, result);

            result = solution.Input('#');
            AssertHelper.AssertList(new string[] { }, result);

            // Round 4
            result = solution.Input('i');
            AssertHelper.AssertList(new string[] { "i love you", "i a", "island" }, result);

            result = solution.Input(' ');
            AssertHelper.AssertList(new string[] { "i love you", "i a", "i love leetcode" }, result);

            result = solution.Input('a');
            AssertHelper.AssertList(new string[] { "i a" }, result);

            result = solution.Input('#');
            AssertHelper.AssertList(new string[] { }, result);
        }
    }
}

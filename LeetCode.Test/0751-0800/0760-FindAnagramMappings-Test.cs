using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0760_FindAnagramMappings_Test
    {
        [TestMethod]
        public void AnagramMappings_1()
        {
            var solution = new _0760_FindAnagramMappings();
            var result = solution.AnagramMappings(new int[] { 12, 28, 46, 32, 50 }, new int[] { 50, 12, 32, 46, 28 });
            AssertHelper.AssertArray(new int[] { 1, 4, 3, 2, 0 }, result);
        }
    }
}

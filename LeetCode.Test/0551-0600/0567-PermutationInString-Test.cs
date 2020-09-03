using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0567_PermutationInString_Test
    {
        [TestMethod]
        public void CheckInclusion_1()
        {
            var solution = new _0567_PermutationInString();
            var result = solution.CheckInclusion("ab" , "eidbaooo");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckInclusion_2()
        {
            var solution = new _0567_PermutationInString();
            var result = solution.CheckInclusion("ab", "eidboaoo");
            Assert.IsFalse(result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1087_BraceExpansion_Test
    {
        [TestMethod]
        public void Expand_1()
        {
            var solution = new _1087_BraceExpansion();
            var result = solution.Expand("{a,b}c{d,e}f");
            AssertHelper.AssertArray(new string[] { "acdf", "acef", "bcdf", "bcef" }, result);
        }

        [TestMethod]
        public void Expand_2()
        {
            var solution = new _1087_BraceExpansion();
            var result = solution.Expand("abcd");
            AssertHelper.AssertArray(new string[] { "abcd" }, result);
        }

        [TestMethod]
        public void Expand_3()
        {
            var solution = new _1087_BraceExpansion();
            var result = solution.Expand("{a,b}{z,x,y}");
            AssertHelper.AssertArray(new string[] { "ax", "ay", "az", "bx", "by", "bz" }, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0917_ReverseOnlyLetters_Test
    {
        [TestMethod]
        public void ReverseOnlyLetters_1()
        {
            var solution = new _0917_ReverseOnlyLetters();
            var result = solution.ReverseOnlyLetters("ab-cd");
            Assert.AreEqual("dc-ba", result);
        }

        [TestMethod]
        public void ReverseOnlyLetters_2()
        {
            var solution = new _0917_ReverseOnlyLetters();
            var result = solution.ReverseOnlyLetters("a-bC-dEf-ghIj");
            Assert.AreEqual("j-Ih-gfE-dCba", result);
        }

        [TestMethod]
        public void ReverseOnlyLetters_3()
        {
            var solution = new _0917_ReverseOnlyLetters();
            var result = solution.ReverseOnlyLetters("Test1ng-Leet=code-Q!");
            Assert.AreEqual("Qedo1ct-eeLg=ntse-T!", result);
        }
    }
}

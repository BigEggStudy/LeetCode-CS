using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0824_GoatLatin_Test
    {
        [TestMethod]
        public void ToGoatLatin_1()
        {
            var solution = new _0824_GoatLatin();
            var result = solution.ToGoatLatin("I speak Goat Latin");
            Assert.AreEqual("Imaa peaksmaaa oatGmaaaa atinLmaaaaa", result);
        }

        [TestMethod]
        public void ToGoatLatin_2()
        {
            var solution = new _0824_GoatLatin();
            var result = solution.ToGoatLatin("The quick brown fox jumped over the lazy dog");
            Assert.AreEqual("heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa", result);
        }
    }
}

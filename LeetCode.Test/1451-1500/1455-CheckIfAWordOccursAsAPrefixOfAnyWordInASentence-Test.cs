using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence_Test
    {
        [TestMethod]
        public void IsPrefixOfWord_1()
        {
            var solution = new _1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence();
            var result = solution.IsPrefixOfWord("i love eating burger", "burg");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void IsPrefixOfWord_2()
        {
            var solution = new _1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence();
            var result = solution.IsPrefixOfWord("this problem is an easy problem", "pro");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void IsPrefixOfWord_3()
        {
            var solution = new _1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence();
            var result = solution.IsPrefixOfWord("i am tired", "you");
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void IsPrefixOfWord_4()
        {
            var solution = new _1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence();
            var result = solution.IsPrefixOfWord("i use triple pillow", "pill");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void IsPrefixOfWord_5()
        {
            var solution = new _1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence();
            var result = solution.IsPrefixOfWord("hello from the other side", "they");
            Assert.AreEqual(-1, result);
        }
    }
}

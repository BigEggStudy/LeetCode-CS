using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0734_SentenceSimilarity_Test
    {
        [TestMethod]
        public void AreSentencesSimilar_1()
        {
            var solution = new _0734_SentenceSimilarity();
            var result = solution.AreSentencesSimilar(new string[] { "great", "acting", "skills" }, new string[] { "fine", "drama", "talent" }, new string[][] {
                new string[] { "great", "fine" },
                new string[] { "acting", "drama" },
                new string[] { "skills", "talent" },
            });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreSentencesSimilar_2()
        {
            var solution = new _0734_SentenceSimilarity();
            var result = solution.AreSentencesSimilar(new string[] { "great", "acting", "skills" }, new string[] { "good", "drama", "talent" }, new string[][] {
                new string[] { "great", "fine" },
                new string[] { "fine", "good" },
                new string[] { "acting", "drama" },
                new string[] { "skills", "talent" },
            });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreSentencesSimilar_3()
        {
            var solution = new _0734_SentenceSimilarity();
            var result = solution.AreSentencesSimilar(new string[] { "great" }, new string[] { "great" }, new string[][] { });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreSentencesSimilar_4()
        {
            var solution = new _0734_SentenceSimilarity();
            var result = solution.AreSentencesSimilar(new string[] { "great" }, new string[] { "doubleplus", "good" }, new string[][] { });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreSentencesSimilar_5()
        {
            var solution = new _0734_SentenceSimilarity();
            var result = solution.AreSentencesSimilar(new string[] { "doubleplus", "great" }, new string[] { "doubleplus", "good" }, new string[][] { });
            Assert.IsFalse(result);
        }
    }
}

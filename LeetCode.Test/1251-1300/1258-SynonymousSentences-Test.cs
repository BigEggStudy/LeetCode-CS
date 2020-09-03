using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1258_SynonymousSentences_Test
    {
        [TestMethod]
        public void GenerateSentences_1()
        {
            var solution = new _1258_SynonymousSentences();
            var result = solution.GenerateSentences(new List<IList<string>>()
            {
                new string[] { "happy", "joy" },
                new string[] { "sad", "sorrow" },
                new string[] { "joy", "cheerful" },
            }, "I am happy today but was sad yesterday");
            AssertHelper.AssertList(new string[] {
                "I am cheerful today but was sad yesterday",
                "I am cheerful today but was sorrow yesterday",
                "I am happy today but was sad yesterday",
                "I am happy today but was sorrow yesterday",
                "I am joy today but was sad yesterday",
                "I am joy today but was sorrow yesterday"
            }, result);
        }

        [TestMethod]
        public void GenerateSentences_2()
        {
            var solution = new _1258_SynonymousSentences();
            var result = solution.GenerateSentences(new List<IList<string>>()
            {
                new string[] { "a", "QrbCl" },
            }, "d QrbCl ya ya NjZQ");
            AssertHelper.AssertList(new string[] {
                "d QrbCl ya ya NjZQ",
                "d a ya ya NjZQ"
            }, result);
        }
    }
}

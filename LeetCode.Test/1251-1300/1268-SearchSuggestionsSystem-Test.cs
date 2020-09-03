using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1268_SearchSuggestionsSystem_Test
    {
        [TestMethod]
        public void SuggestedProducts_1()
        {
            var solution = new _1268_SearchSuggestionsSystem();
            var result = solution.SuggestedProducts(new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse");
            AssertHelper.AssertList(new List<IList<string>>() {
                new string[] { "mobile", "moneypot", "monitor" },
                new string[] { "mobile", "moneypot", "monitor" },
                new string[] { "mouse", "mousepad" },
                new string[] { "mouse", "mousepad" },
                new string[] { "mouse", "mousepad" },
            }, result);
        }

        [TestMethod]
        public void SuggestedProducts_2()
        {
            var solution = new _1268_SearchSuggestionsSystem();
            var result = solution.SuggestedProducts(new string[] { "havana" }, "havana");
            AssertHelper.AssertList(new List<IList<string>>() {
                new string[] { "havana" },
                new string[] { "havana" },
                new string[] { "havana" },
                new string[] { "havana" },
                new string[] { "havana" },
                new string[] { "havana" },
            }, result);
        }

        [TestMethod]
        public void SuggestedProducts_3()
        {
            var solution = new _1268_SearchSuggestionsSystem();
            var result = solution.SuggestedProducts(new string[] { "bags", "baggage", "banner", "box", "cloths" }, "bags");
            AssertHelper.AssertList(new List<IList<string>>() {
                new string[] { "baggage", "bags", "banner" },
                new string[] { "baggage", "bags", "banner" },
                new string[] { "baggage", "bags" },
                new string[] { "bags" },
            }, result);
        }

        [TestMethod]
        public void SuggestedProducts_4()
        {
            var solution = new _1268_SearchSuggestionsSystem();
            var result = solution.SuggestedProducts(new string[] { "havana" }, "tatiana");
            AssertHelper.AssertList(new List<IList<string>>() {
                new string[] {  },
                new string[] {  },
                new string[] {  },
                new string[] {  },
                new string[] {  },
                new string[] {  },
                new string[] {  },
            }, result);
        }
    }
}

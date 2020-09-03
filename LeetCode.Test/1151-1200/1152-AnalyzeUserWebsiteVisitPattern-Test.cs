using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1152_AnalyzeUserWebsiteVisitPattern_Test
    {
        [TestMethod]
        public void MostVisitedPattern_1()
        {
            var solution = new _1152_AnalyzeUserWebsiteVisitPattern();
            var result = solution.MostVisitedPattern(
                new string[] { "joe", "joe", "joe", "james", "james", "james", "james", "mary", "mary", "mary" },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                new string[] { "home", "about", "career", "home", "cart", "maps", "home", "home", "about", "career" });
            AssertHelper.AssertList(new string[] { "home", "about", "career" }, result);
        }

        [TestMethod]
        public void MostVisitedPattern_2()
        {
            var solution = new _1152_AnalyzeUserWebsiteVisitPattern();
            var result = solution.MostVisitedPattern(
                new string[] { "u1", "u1", "u1", "u2", "u2", "u2" },
                new int[] { 1, 2, 3, 4, 5, 6 },
                new string[] { "a", "b", "c", "a", "b", "a" });
            AssertHelper.AssertList(new string[] { "a", "b", "a" }, result);
        }

        [TestMethod]
        public void MostVisitedPattern_3()
        {
            var solution = new _1152_AnalyzeUserWebsiteVisitPattern();
            var result = solution.MostVisitedPattern(
                new string[] { "h", "eiy", "cq", "h", "cq", "txldsscx", "cq", "txldsscx", "h", "cq", "cq" },
                new int[] { 527896567, 334462937, 517687281, 134127993, 859112386, 159548699, 51100299, 444082139, 926837079, 317455832, 411747930 },
                new string[] { "hibympufi", "hibympufi", "hibympufi", "hibympufi", "hibympufi", "hibympufi", "hibympufi", "hibympufi", "yljmntrclw", "hibympufi", "yljmntrclw" });
            AssertHelper.AssertList(new string[] { "hibympufi", "hibympufi", "yljmntrclw" }, result);
        }

        [TestMethod]
        public void MostVisitedPattern_4()
        {
            var solution = new _1152_AnalyzeUserWebsiteVisitPattern();
            var result = solution.MostVisitedPattern(
                new string[] { "lpgbr", "by", "by", "lpgbr", "by", "ditctqnahs", "by" },
                new int[] { 117853717, 760542754, 858167998, 235286033, 992196098, 273717872, 792447849 },
                new string[] { "inc", "inc", "inc", "ftd", "inc", "ftd", "inc" });
            AssertHelper.AssertList(new string[] { "inc", "inc", "inc" }, result);
        }
    }
}

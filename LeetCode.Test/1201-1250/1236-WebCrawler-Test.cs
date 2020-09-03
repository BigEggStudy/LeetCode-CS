using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._1236_WebCrawler;

namespace LeetCode.Test
{
    [TestClass]
    public class _1236_WebCrawler_Test
    {
        [TestMethod]
        public void CrawlTest_1()
        {
            var parser = new HtmlParser(new List<string>() {
                "http://news.yahoo.com",
                "http://news.yahoo.com/news",
                "http://news.yahoo.com/news/topics/",
                "http://news.google.com",
                "http://news.yahoo.com/us"
            }, new List<int[]>() {
                new int[] { 2, 0 },
                new int[] { 2, 1 },
                new int[] { 3, 2 },
                new int[] { 3, 1 },
                new int[] { 0, 4 },
            });

            var solution = new _1236_WebCrawler();
            var result = solution.Crawl("http://news.yahoo.com/news/topics/", parser);
            AssertHelper.AssertList(new string[] {
                "http://news.yahoo.com/news/topics/",
                "http://news.yahoo.com",
                "http://news.yahoo.com/news",
                "http://news.yahoo.com/us"
            }, result);
        }

        [TestMethod]
        public void CrawlTest_2()
        {
            var parser = new HtmlParser(new List<string>() {
                "http://news.yahoo.com",
                "http://news.yahoo.com/news",
                "http://news.yahoo.com/news/topics/",
                "http://news.google.com"
            }, new List<int[]>() {
                new int[] { 0, 2 },
                new int[] { 2, 1 },
                new int[] { 3, 2 },
                new int[] { 3, 1 },
                new int[] { 3, 0 },
            });

            var solution = new _1236_WebCrawler();
            var result = solution.Crawl("http://news.google.com", parser);
            AssertHelper.AssertList(new string[] {
                "http://news.google.com"
            }, result);
        }
    }
}

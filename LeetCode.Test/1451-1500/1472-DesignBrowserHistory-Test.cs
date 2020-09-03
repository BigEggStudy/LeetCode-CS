using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1472_DesignBrowserHistory_Test
    {
        [TestMethod]
        public void BrowserHistoryTest_1()
        {
            var browserHistory = new _1472_DesignBrowserHistory("leetcode.com");

            browserHistory.Visit("google.com");       // You are in "leetcode.com". Visit "google.com"
            browserHistory.Visit("facebook.com");     // You are in "google.com". Visit "facebook.com"
            browserHistory.Visit("youtube.com");      // You are in "facebook.com". Visit "youtube.com"
            Assert.AreEqual("facebook.com", browserHistory.Back(1));                   // You are in "youtube.com", move back to "facebook.com" return "facebook.com"
            Assert.AreEqual("google.com", browserHistory.Back(1));                   // You are in "facebook.com", move back to "google.com" return "google.com"
            Assert.AreEqual("facebook.com", browserHistory.Forward(1));                // You are in "google.com", move forward to "facebook.com" return "facebook.com"
            browserHistory.Visit("linkedin.com");     // You are in "facebook.com". Visit "linkedin.com"
            Assert.AreEqual("linkedin.com", browserHistory.Forward(2));                // You are in "linkedin.com", you cannot move forward any steps.
            Assert.AreEqual("google.com", browserHistory.Back(2));                   // You are in "linkedin.com", move back two steps to "facebook.com" then to "google.com". return "google.com"
            Assert.AreEqual("leetcode.com", browserHistory.Back(7));                   // You are in "google.com", you can move back only one step to "leetcode.com". return "leetcode.com"
        }
    }
}

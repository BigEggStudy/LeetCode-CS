using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0355_DesignTwitter_Test
    {
        [TestMethod]
        public void Twitter_1()
        {
            _0355_DesignTwitter twitter = new _0355_DesignTwitter();

            // User 1 posts a new tweet (id = 5).
            twitter.PostTweet(1, 5);

            // User 1's news feed should return a list with 1 tweet id -> [5].
            var newsFeed = twitter.GetNewsFeed(1);
            Assert.AreEqual(1, newsFeed.Count);
            Assert.AreEqual(5, newsFeed[0]);

            // User 1 follows user 2.
            twitter.Follow(1, 2);

            // User 2 posts a new tweet (id = 6).
            twitter.PostTweet(2, 6);

            // User 1's news feed should return a list with 2 tweet ids -> [6, 5].
            // Tweet id 6 should precede tweet id 5 because it is posted after tweet id 5.
            newsFeed = twitter.GetNewsFeed(1);
            Assert.AreEqual(2, newsFeed.Count);
            Assert.AreEqual(6, newsFeed[0]);
            Assert.AreEqual(5, newsFeed[1]);

            // User 1 unfollows user 2.
            twitter.Unfollow(1, 2);

            // User 1's news feed should return a list with 1 tweet id -> [5],
            // since user 1 is no longer following user 2.
            newsFeed = twitter.GetNewsFeed(1);
            Assert.AreEqual(1, newsFeed.Count);
            Assert.AreEqual(5, newsFeed[0]);
        }
    }
}

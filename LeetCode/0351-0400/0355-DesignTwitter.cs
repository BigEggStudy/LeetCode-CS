//-----------------------------------------------------------------------------
// Runtime: 308ms
// Memory Usage: 42.7 MB
// Link: https://leetcode.com/submissions/detail/382886622/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0355_DesignTwitter
    {
        private readonly Dictionary<int, User> users;
        private int timestamp = 0;

        /** Initialize your data structure here. */
        public _0355_DesignTwitter()
        {
            users = new Dictionary<int, User>();
        }

        /** Compose a new tweet. */
        public void PostTweet(int userId, int tweetId)
        {
            if (!users.ContainsKey(userId))
                users[userId] = new User(userId);
            users[userId].post(tweetId, timestamp++);
        }

        /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
        public IList<int> GetNewsFeed(int userId)
        {
            if (!users.ContainsKey(userId))
            {
                users[userId] = new User(userId);
                return new List<int>();
            }

            var followers = new HashSet<int>(users[userId].Followed);
            followers.Add(userId);
            var tweets = new SortedDictionary<Tweet, int>(Comparer<Tweet>.Create((a, b) => b.Time.CompareTo(a.Time)));
            foreach (var id in followers)
            {
                if (users[id].TweetHead != null)
                    tweets.Add(users[id].TweetHead, 1);
            }

            var count = 10;
            var results = new List<int>();
            while (tweets.Count > 0 && count > 0)
            {
                var t = tweets.Keys.First();
                results.Add(t.Id);
                tweets.Remove(t);

                if (t.Next != null)
                    tweets.Add(t.Next, 1);

                count--;
            }

            return results;
        }

        /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
        public void Follow(int followerId, int followeeId)
        {
            if (followerId == followeeId) return;

            if (!users.ContainsKey(followerId))
                users[followerId] = new User(followerId);
            if (!users.ContainsKey(followeeId))
                users[followeeId] = new User(followeeId);

            users[followerId].Follow(followeeId);
        }

        /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
        public void Unfollow(int followerId, int followeeId)
        {
            if (!users.ContainsKey(followerId))
                users[followerId] = new User(followerId);
            if (!users.ContainsKey(followeeId))
                users[followeeId] = new User(followeeId);

            users[followerId].Unfollow(followeeId);
        }

        public class Tweet
        {
            public Tweet(int id, int timestamp)
            {
                Id = id;
                Time = timestamp;
                Next = null;
            }

            public int Id { get; private set; }
            public int Time { get; private set; }
            public Tweet Next { get; set; }
        }

        public class User
        {
            public int Id { get; private set; }
            public HashSet<int> Followed { get; } = new HashSet<int>();
            public Tweet TweetHead { get; private set; }

            public User(int id)
            {
                Id = id;
            }

            public void Follow(int id)
            {
                Followed.Add(id);
            }

            public void Unfollow(int id)
            {
                Followed.Remove(id);
            }


            // everytime user post a new tweet, add it to the head of tweet list.
            public void post(int id, int timestamp)
            {
                Tweet newTweet = new Tweet(id, timestamp);
                newTweet.Next = TweetHead;
                TweetHead = newTweet;
            }
        }
    }

    /**
     * Your Twitter object will be instantiated and called as such:
     * Twitter obj = new Twitter();
     * obj.PostTweet(userId,tweetId);
     * IList<int> param_2 = obj.GetNewsFeed(userId);
     * obj.Follow(followerId,followeeId);
     * obj.Unfollow(followerId,followeeId);
     */
}

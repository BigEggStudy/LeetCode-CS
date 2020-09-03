//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.1 MB
// Link: https://leetcode.com/submissions/detail/262781663/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0535_EncodeAndDecodeTinyURL
    {
        private const string ALPHABET = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string DOMAIN = "http://tinyurl.com/";

        private readonly IDictionary<string, string> map = new Dictionary<string, string>();
        private readonly Random random = new Random();

        public string GetKey()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 8; i++)
                sb.Append(ALPHABET[random.Next(62)]);

            return sb.ToString();
        }

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            var key = string.Empty;
            do
            {
                key = GetKey();
            } while (map.ContainsKey(key));

            map[key] = longUrl;
            return DOMAIN + key;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            var key = shortUrl.Replace(DOMAIN, "");
            map.TryGetValue(key, out var value);
            return value;
        }
    }
}

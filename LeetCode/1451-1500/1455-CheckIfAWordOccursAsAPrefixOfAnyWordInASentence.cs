//-----------------------------------------------------------------------------
// Runtime: 64ms
// Memory Usage: 21.9 MB
// Link: https://leetcode.com/submissions/detail/344137060/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var search = new Trie();
            var curr = search;
            foreach (var ch in searchWord)
            {
                curr.Next[ch - 'a'] = new Trie();
                curr = curr.Next[ch - 'a'];
            }
            curr.Finish = true;

            curr = search;
            var index = 1;
            for (var i = 0; i < sentence.Length; i++)
            {
                var ch = sentence[i];
                if (ch == ' ')
                {
                    curr = search;
                    index++;
                    continue;
                }
                if (curr.Next[ch - 'a'] == null)
                {
                    while (i + 1 < sentence.Length && sentence[i + 1] != ' ')
                        i++;
                    continue;
                }
                curr = curr.Next[ch - 'a'];
                if (curr.Finish) return index;
            }

            return -1;
        }

        private class Trie
        {
            public Trie[] Next = new Trie[26];
            public bool Finish = false;
        }
    }
}

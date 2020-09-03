//-----------------------------------------------------------------------------
// Runtime: 160ms
// Memory Usage: 29.4 MB
// Link: https://leetcode.com/submissions/detail/358686477/
//-----------------------------------------------------------------------------

using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode
{
    public class _0604_DesignCompressedStringIterator
    {
        private int index = 0;
        private char[] chArray;
        private int[] counts;

        public _0604_DesignCompressedStringIterator(string compressedString)
        {
            index = 0;
            var slit = Regex.Split(compressedString, "[0-9]+");
            chArray = Regex.Split(compressedString, "[0-9]+").Where(s => !string.IsNullOrEmpty(s)).Select(s => s[0]).ToArray();
            counts = Regex.Split(compressedString, "[a-zA-Z]+").Where(s => !string.IsNullOrEmpty(s)).Select(s => int.Parse(s)).ToArray();
        }

        public char Next()
        {
            if (!HasNext()) return ' ';

            var ch = chArray[index];
            counts[index]--;

            if (counts[index] == 0)
                index++;

            return ch;
        }

        public bool HasNext()
        {
            return index < counts.Length;
        }
    }

    /**
     * Your StringIterator object will be instantiated and called as such:
     * StringIterator obj = new StringIterator(compressedString);
     * char param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
}

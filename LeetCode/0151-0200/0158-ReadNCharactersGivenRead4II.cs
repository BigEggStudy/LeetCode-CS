//-----------------------------------------------------------------------------
// Runtime: 264ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    /**
     * The Read4 API is defined in the parent class Reader4.
     *     int Read4(char[] buf);
     */
    public class _0158_ReadNCharactersGivenRead4II : Reader4
    {
        private char[] cache = new char[4];
        private int start = 0;
        private int end = 0;

        /**
         * @param buf Destination buffer
         * @param n   Number of characters to read
         * @return    The number of actual characters read
         */
        public int Read(char[] buf, int n)
        {
            if (n == 0) return 0;
            var length = 0;

            while (n > 0)
            {
                while (end > start && n > 0)
                {
                    buf[length++] = cache[start++];
                    n--;
                }

                if (n == 0) return length;

                start = 0;
                end = Read4(cache);

                if (end == 0) return length;
            }

            return length;
        }
    }

    public class Reader4
    {
        private string str = string.Empty;
        private int index = 0;

        public void FillData(string s)
        {
            str = s;
            index = 0;
        }

        public int Read4(char[] buf)
        {
            if (index >= str.Length) return 0;
            var length = Math.Min(4, str.Length - index);
            var data = str.Substring(index, Math.Min(4, str.Length - index));

            index += length;
            for (int i = 0; i < data.Length; i++)
                buf[i] = data[i];
            return data.Length;
        }
    }
}

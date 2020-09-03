//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 22.7 MB
// Link: https://leetcode.com/submissions/detail/389654223/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * The Read4 API is defined in the parent class Reader4.
     *     int Read4(char[] buf);
     */

    public class _0157_ReadNCharactersGivenRead4
    {
        private readonly string str;
        private int index;

        public _0157_ReadNCharactersGivenRead4(string str)
        {
            index = 0;
            this.str = str;
        }


        /**
         * @param buf Destination buffer
         * @param n   Number of characters to read
         * @return    The number of actual characters read
         */
        public int Read(char[] buf, int n)
        {
            if (n == 0) return 0;

            char[] myBuf = new char[4];
            int idx = 0;
            while (idx < n)
            {
                int curr = Read4(myBuf);
                for (int i = 0; i < curr && idx < n; i++)
                {
                    buf[idx] = myBuf[i];
                    idx++;
                }
                if (curr < 4) break;
            }
            return idx;
        }

        public int Read4(char[] buf)
        {
            for (int i = 0; i < 4; i++)
            {
                if (index < str.Length)
                    buf[i] = str[index++];
                else
                    return i;
            }

            return 4;
        }
    }
}

//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 22.6 MB
// Link: https://leetcode.com/submissions/detail/354663426/
//-----------------------------------------------------------------------------

using System;
using System.Linq;

namespace LeetCode
{
    public class _0468_ValidateIPAddress
    {
        public string ValidIPAddress(string IP)
        {
            if (IP.Count(ch => ch == '.') == 3)
                return ValidateIPv4(IP) ? "IPv4" : "Neither";
            if (IP.Count(ch => ch == ':') == 7)
                return ValidateIPv6(IP) ? "IPv6" : "Neither";
            return "Neither";
        }

        private bool ValidateIPv4(string IP)
        {
            var nums = IP.Split(new char[] { '.' }, StringSplitOptions.None);
            foreach (var x in nums)
            {
                if (x.Length == 0 || x.Length > 3) return false;
                if (x[0] == '0' && x.Length != 1) return false;
                foreach (var ch in x)
                    if (!char.IsDigit(ch)) return false;
                if (int.Parse(x) > 255) return false;
            }
            return true;
        }

        private bool ValidateIPv6(string IP)
        {
            string hexdigits = "0123456789abcdefABCDEF";

            var nums = IP.Split(new char[] { ':' }, StringSplitOptions.None);
            foreach (var x in nums)
            {
                if (x.Length == 0 || x.Length > 4) return false;
                foreach (var ch in x)
                    if (hexdigits.IndexOf(ch) == -1) return false;
            }
            return true;
        }
    }
}

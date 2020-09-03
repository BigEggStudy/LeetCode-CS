//-----------------------------------------------------------------------------
// Runtime: 320ms
// Memory Usage: 47.3 MB
// Link: https://leetcode.com/submissions/detail/368946120/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1472_DesignBrowserHistory
    {
        private readonly string[] urls = new string[200];
        private int current;
        private int size;

        public _1472_DesignBrowserHistory(string homepage)
        {
            current = 0;
            size = 1;
            urls[current] = homepage;
        }

        public void Visit(string url)
        {
            urls[++current] = url;
            size = current + 1;
        }

        public string Back(int steps)
        {
            current -= steps;
            if (current < 0) current = 0;
            return urls[current];
        }

        public string Forward(int steps)
        {
            current += steps;
            if (current >= size) current = size - 1;
            return urls[current];
        }
    }

    /**
     * Your BrowserHistory object will be instantiated and called as such:
     * BrowserHistory obj = new BrowserHistory(homepage);
     * obj.Visit(url);
     * string param_2 = obj.Back(steps);
     * string param_3 = obj.Forward(steps);
     */
}

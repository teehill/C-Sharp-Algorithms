using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public static class FirstUniqueChar
    {
        public static int FirstUniqChar(string s)
        {
            var uniqueChars = new Dictionary<char, int>();
            var charHash = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (charHash.Add(s[i]))
                {
                    uniqueChars.Add(s[i], i);
                }
                else
                {
                    uniqueChars.Remove(s[i]);
                }

            }

            var minimumIndex = -1;

            foreach (var c in uniqueChars)
            {
                if (c.Value < minimumIndex || minimumIndex == -1)
                    minimumIndex = c.Value;
            }

            return minimumIndex;
        }
    }
}
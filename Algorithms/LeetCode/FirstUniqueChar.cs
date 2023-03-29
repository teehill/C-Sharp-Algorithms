using System.Collections.Generic;

namespace Algorithms.LeetCode
{
    public static class FirstUniqueChar
    {
        public static int FirstUniqChar(string s)
        {
            var charMap = new Dictionary<char, CharacterCount>();

            for (int i = 0; i < s.Length; i++)
            {
                if (charMap.ContainsKey(s[i]))
                {
                    charMap[s[i]].Count++;
                }
                else
                {
                    charMap[s[i]] = new CharacterCount { Count = 1, Index = i };
                }
            }

            foreach (var c in s)
            {
                if (charMap.ContainsKey(c))
                {
                    if (charMap[c].Count == 1)
                    {
                        return charMap[c].Index;
                    }
                }
            }

            return -1;
        }
    }

    class CharacterCount
    {
        public int Count { get; set; }
        public int Index { get; set; }
    }
}
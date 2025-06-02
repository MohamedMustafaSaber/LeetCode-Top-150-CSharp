public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char,int> Counts = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!Counts.ContainsKey(s[i]))
                Counts[s[i]] = 0;
            Counts[s[i]]++;

            if (!Counts.ContainsKey(t[i]))
                Counts[t[i]] = 0;
            Counts[t[i]]--;
        }
        foreach (var item in s)
        {
            if (Counts[item] != 0)
            {
                return false;
            }
        }
        return true;
    }
}
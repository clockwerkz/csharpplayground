using System;
using System.Collection.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        Dictionary<string, int> hash = new Dictionary<string, int>();
        for (int i=0; i<word.Length; i++)
        {
            if (hash.ContainsKey(word[i]))
            {
                return false;
            }
            else
                hash.Add(word[i], 1);
        }
        return true;
    }
}

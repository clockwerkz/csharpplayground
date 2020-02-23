using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        Regex rgx = new Regex("[^a-z]");
        string strippedWord= rgx.Replace(word.ToLower(), "");
        Dictionary<char, int> hash = new Dictionary<char, int>();
        for (int i=0; i<strippedWord.Length; i++)
        {
            if (hash.ContainsKey(strippedWord[i]))
            {
                return false;
            }
            else
                hash.Add(strippedWord[i], 1);
        }
        return true;
    }
}

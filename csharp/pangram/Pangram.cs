using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (input.Length < 26) return false;
        input = input.ToLower();
        int[] alphabet = new int[26];

        for (int i=0; i<input.Length; i++)
        {
            int letterIndex = (int)input[i] - 97;
            if (letterIndex >= 0 && letterIndex <= 25)
            {
                alphabet[letterIndex] = 1;
            }
        }
        for (int i=0; i < alphabet.Length; i++)
        {
            if (alphabet[i] == 0) return false;
        }
        return true;
    }
}

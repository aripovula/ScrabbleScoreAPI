using System;
using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        Dictionary<char, int> values = new Dictionary<int, string>()
        {
            {1, "aeioulnrst"},
            {2, "dg"},
            {3, "bcmp"},
            {4, "fhvwy"},
            {5, "k"},
            {8, "jx"},
            {10, "qz"}
      }.SelectMany(kv => kv.Value.Select(c => (c, kv.Key)))
          .ToDictionary(kv => kv.c, kv => kv.Key);

        string word = input.ToLower();
        int score = 0;

        foreach (char letter in word)
        {
                score += values[letter];
        }
        return score;
    }
}
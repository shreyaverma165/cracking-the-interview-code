using System;
using System.Collections.Generic;

public class Solution
{
    // Function to find the longest substring without repeating characters
    public int LongestSubstringWithoutRepetition(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        int start = 0;

        for (int end = 0; end < n; end++)
        {
            char currentChar = s[end];

            if (charIndexMap.ContainsKey(currentChar))
            {
                start = Math.Max(start, charIndexMap[currentChar] + 1);
            }

            charIndexMap[currentChar] = end;
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }

    // Function to find the longest substring with at most two repeating characters
    public int LongestSubstringWithTwoRepeatingCharacters(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        Dictionary<char, int> charCountMap = new Dictionary<char, int>();
        int start = 0;
        int distinctCount = 0;

        for (int end = 0; end < n; end++)
        {
            char currentChar = s[end];

            if (charCountMap.ContainsKey(currentChar))
            {
                charCountMap[currentChar]++;
            }
            else
            {
                charCountMap[currentChar] = 1;
                distinctCount++;
            }

            while (distinctCount > 2)
            {
                char startChar = s[start];
                charCountMap[startChar]--;
                if (charCountMap[startChar] == 0)
                {
                    charCountMap.Remove(startChar);
                    distinctCount--;
                }
                start++;
            }

            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string s = "abcabcbb";
        int resultWithoutRepetition = solution.LongestSubstringWithoutRepetition(s);
        int resultWithTwoRepeating = solution.LongestSubstringWithTwoRepeatingCharacters(s);
        Console.WriteLine(resultWithoutRepetition); // Expected output: 3
        Console.WriteLine(resultWithTwoRepeating); // Expected output: 7
    }
}

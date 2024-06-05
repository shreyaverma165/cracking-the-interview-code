## Description

Imagine you are working on a text processing feature for a text editor that needs to find the longest substring within a given text. You need to implement two functions:
1. One to find the longest substring without repeating characters.
2. One to find the longest substring with at most two repeating characters.

## Requirements

1. **Function Signature:** 
   ```csharp
   public int LongestSubstringWithoutRepetition(string s);
   public int LongestSubstringWithTwoRepeatingCharacters(string s);
   ```

2. **Input:**
   - `s`: A string representing the text to be processed.

3. **Output:**
   - Return an integer representing the length of the longest substring that meets the criteria.

4. **Constraints:**
   - The input string `s` consists of English letters, digits, symbols, and spaces.

**Extra Credit:**
   - Modify the function to handle Unicode characters efficiently.

**Example:**
   ```csharp
   string s = "abcabcbb";
   int resultWithoutRepetition = LongestSubstringWithoutRepetition(s); // Expected output: 3
   int resultWithTwoRepeating = LongestSubstringWithTwoRepeatingCharacters(s); // Expected output: 7
   ```

**The function should return:**
   ```csharp
   int resultWithoutRepetition = LongestSubstringWithoutRepetition(s);
   // Expected output: 3
   int resultWithTwoRepeating = LongestSubstringWithTwoRepeatingCharacters(s);
   // Expected output: 7
   ```

**Hints:**
   - Use a sliding window approach to maintain the current substring.
   - Use a hash set or hash map to track characters in the current window.

**Sample Dataset:**
   ```csharp
   string s = "pwwkew";
   ```

**Expected Output for Sample Dataset:**
   ```csharp
   int resultWithoutRepetition = LongestSubstringWithoutRepetition(s);
   // Expected output: 3
   int resultWithTwoRepeating = LongestSubstringWithTwoRepeatingCharacters(s);
   // Expected output: 4
   ```

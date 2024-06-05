### Longest Substring Without Repetition and With Repeating Characters

#### Problem Statement

Design functions to find the longest substring within a given text:
1. The longest substring without repeating characters.
2. The longest substring with at most two repeating characters.

#### Example Data Set in C#:

```csharp
string s = "abcabcbb";
int resultWithoutRepetition = LongestSubstringWithoutRepetition(s); // Expected output: 3
int resultWithTwoRepeating = LongestSubstringWithTwoRepeatingCharacters(s); // Expected output: 7
```

### Solution Walkthrough

**1. Longest Substring Without Repetition:**

1. **Initialization:**
   - Initialize a dictionary to store the last index of each character.
   - Set the start pointer and maximum length.
   ```csharp
   Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
   int start = 0;
   int maxLength = 0;
   ```

2. **Iterate through the string:**
   - For each character, check if it has been seen before and update the start pointer if necessary.
   - Update the character's last index.
   - Calculate the current substring length and update the maximum length.
   ```csharp
   for (int end = 0; end < s.Length; end++)
   {
       char currentChar = s[end];
       if (charIndexMap.ContainsKey(currentChar))
       {
           start = Math.Max(start, charIndexMap[currentChar] + 1);
       }
       charIndexMap[currentChar] = end;
       maxLength = Math.Max(maxLength, end - start + 1);
   }
   ```

### Expected Result:

```csharp
int resultWithoutRepetition = LongestSubstringWithoutRepetition(s);
// Expected output: 3
```

**2. Longest Substring With Two Repeating Characters:**

1. **Initialization:**
   - Initialize a dictionary to count characters in the current window.
   - Set the start pointer, maximum length, and distinct count.
   ```csharp
   Dictionary<char, int> charCountMap = new Dictionary<char, int>();
   int start = 0;
   int maxLength = 0;
   int distinctCount = 0;
   ```

2. **Iterate through the string:**
   - For each character, update its count in the dictionary.
   - If a new character is added, increase the distinct count.
   - If the distinct count exceeds two, move the start pointer to maintain the constraint.
   - Calculate the current substring length and update the maximum length.
   ```csharp
   for (int end = 0; end < s.Length; end++)
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
   ```

### Expected Result:

```csharp
int resultWithTwoRepeating = LongestSubstringWithTwoRepeatingCharacters(s);
// Expected output: 7
```

### Python Example Data Set:

```python
s = "abcabcbb"
result_without_repetition = Solution().longest_substring_without_repetition(s)  # Expected output: 3
result_with_two_repeating = Solution().longest_substring_with_two_repeating_characters(s)  # Expected output: 7
```

### Solution Walkthrough in Python

**1. Longest Substring Without Repetition:**

1. **Initialization:**
   - Initialize a dictionary to store the last index of each character.
   - Set the start pointer and maximum length.
   ```python
   char_index_map = {}
   start = 0
   max_length = 0
   ```

2. **Iterate through the string:**
   - For each character, check if it has been seen before and update the start pointer if necessary.
   - Update the character's last index.
   - Calculate the current substring length and update the maximum length.
   ```python
   for end in range(len(s)):
       current_char = s[end]
       if current_char in char_index_map:
           start = max(start, char_index_map[current_char] + 1)
       char_index_map[current_char] = end
       max_length = max(max_length, end - start + 1)
   ```

### Expected Result:

```python
result_without_repetition = Solution().longest_substring_without_repetition(s)
# Expected output: 3
```

**2. Longest Substring With Two Repeating Characters:**

1. **Initialization:**
   - Initialize a dictionary to count characters in the current window.
   - Set the start pointer, maximum length, and distinct count.
   ```python
   char_count_map = {}
   start = 0
   max_length = 0
   distinct_count = 0
   ```

2. **Iterate through the string:**
   - For each character, update its count in the dictionary.
   - If a new character is added, increase the distinct count.
   - If the distinct count exceeds two, move the start pointer to maintain the constraint.
   - Calculate the current substring length and update the maximum length.
   ```python
   for end in range(len(s)):
       current_char = s[end]
       if current_char in char_count_map:
           char_count_map[current_char] += 1
       else:
           char_count_map[current_char] = 1
           distinct_count += 1
       while distinct_count > 2:
           start_char = s[start]
           char_count_map[start_char] -= 1
           if char_count_map[start_char] == 0:
               del char_count_map[start_char]
               distinct_count -= 1
           start += 1
       max_length = max(max_length, end - start + 1)
   ```

### Expected Result:

```python
result_with_two_repeating = Solution().longest_substring_with_two_repeating_characters(s)
# Expected output: 7
```

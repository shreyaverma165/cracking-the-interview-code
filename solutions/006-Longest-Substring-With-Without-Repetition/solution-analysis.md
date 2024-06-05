## Longest Substring Without Repetition and With Repeating Characters

### Data Structure Brainstorm

| Data Structure | Pros | Cons | Expected Time Complexity | Expected Space Complexity |
|----------------|------|------|--------------------------|---------------------------|
| **Array** | Simple and straightforward | Inefficient for dynamic substring management | Linear scan: O(n) | O(n) |
| **Hash Set** | Fast lookups and dynamic management of unique characters | Does not track character indices | Insertion: O(1) Deletion: O(1) | O(n) |
| **Hash Map** | Fast lookups, dynamic management, and tracking character indices | Slightly more complex than hash set | Insertion: O(1) Deletion: O(1) | O(n) |
| **Queue** | Efficient for maintaining order of characters | Inefficient for direct index access | Insertion: O(1) Deletion: O(1) | O(n) |
| **Stack** | Useful for backtracking | Not suitable for maintaining unique characters in substring | Insertion: O(1) Deletion: O(1) | O(n) |
| **Sliding Window with Hash Map** | Efficient for maintaining dynamic substrings and character indices | More complex to implement | Insertion: O(1) Deletion: O(1) | O(n) |

### Summary

For the problems of finding the longest substring without repeating characters and with at most two repeating characters, the sliding window approach combined with a hash map is the most efficient solution. It allows for dynamic management of substrings, fast lookups, and tracking of character indices, ensuring linear time complexity with minimal space overhead.

---

### Solution Description

The problem involves finding the longest substring within a given text, with one function to find the longest substring without repeating characters and another to find the longest substring with at most two repeating characters. The sliding window technique is employed, where a window is moved across the string to maintain the current substring. A hash map is used to track the characters and their indices, enabling efficient updates and checks.

### Time Complexity

- **Sliding Window with Hash Map:**
  - **Longest Substring Without Repetition:** O(n)
  - **Longest Substring With Two Repeating Characters:** O(n)

Overall time complexity: O(n).

### Space Complexity

- **Space:** O(n) - The space complexity is proportional to the number of unique characters in the substring.

Overall space complexity: O(n).

---


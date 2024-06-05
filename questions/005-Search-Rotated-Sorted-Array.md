## Description

Imagine you are working on a search feature for an inventory system that needs to find products in a rotated sorted array. The array has been sorted in ascending order, but then it was rotated at some pivot unknown to you beforehand. You need to implement an efficient search function to find the index of a target product ID.

## Requirements

1. **Function Signature:** 
   ```csharp
   public int Search(int[] nums, int target);
   ```

2. **Input:**
   - `nums`: An array of integers representing the rotated sorted array.
   - `target`: An integer representing the target product ID to search for.

3. **Output:**
   - Return an integer representing the index of the target in the array. If the target is not found, return -1.

4. **Constraints:**
   - You must write an algorithm with O(log n) runtime complexity.
   - The array `nums` may contain duplicates.

**Extra Credit:**
   - Modify the function to handle arrays with duplicates efficiently.

**Example:**
   ```csharp
   int[] nums = {4,5,6,7,0,1,2};
   int target = 0;
   int result = Search(nums, target); // Expected output: 4
   ```

**The function should return:**
   ```csharp
   int result = Search(nums, target);
   // Expected output: 4
   ```

**Hints:**
   - Use a modified binary search to achieve O(log n) complexity.
   - Consider the different scenarios where the pivot affects the position of the target.

**Sample Dataset:**
   ```csharp
   int[] nums = {4,5,6,7,0,1,2};
   int target = 3;
   ```

**Expected Output for Sample Dataset:**
   ```csharp
   int result = Search(nums, target);
   // Expected output: -1
   ```

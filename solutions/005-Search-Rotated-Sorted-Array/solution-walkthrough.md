### Search in Rotated Sorted Array

#### Problem Statement

Design a function to find the index of a target element in a rotated sorted array. The array has been sorted in ascending order but then rotated at some pivot unknown beforehand.

#### Example Data Set in C#:

```csharp
int[] nums = {4, 5, 6, 7, 0, 1, 2};
int target = 0;
int result = Search(nums, target); // Expected output: 4
```

### Solution Walkthrough

1. **Initialization:**
   - Set the initial values for left and right pointers.
   ```csharp
   int left = 0;
   int right = nums.Length - 1;
   ```

2. **First Iteration:**
   - Calculate the mid-point.
   - Check if the mid element is the target.
   - Determine which side is sorted.
   - Adjust the search range based on the sorted side.
   ```csharp
   int mid = left + (right - left) / 2; // mid = 3
   if (nums[mid] == target) return mid; // nums[3] != 0
   if (nums[left] <= nums[mid]) {
       if (nums[left] <= target && target < nums[mid]) {
           right = mid - 1; // Adjust right
       } else {
           left = mid + 1; // Adjust left
       }
   }
   ```

3. **Second Iteration:**
   - Calculate the new mid-point.
   - Check if the mid element is the target.
   - Determine which side is sorted.
   - Adjust the search range based on the sorted side.
   ```csharp
   mid = left + (right - left) / 2; // mid = 5
   if (nums[mid] == target) return mid; // nums[5] != 0
   if (nums[left] <= nums[mid]) {
       if (nums[left] <= target && target < nums[mid]) {
           right = mid - 1; // Adjust right
       } else {
           left = mid + 1; // Adjust left
       }
   }
   ```

4. **Third Iteration:**
   - Calculate the new mid-point.
   - Check if the mid element is the target.
   - Determine which side is sorted.
   - Adjust the search range based on the sorted side.
   ```csharp
   mid = left + (right - left) / 2; // mid = 4
   if (nums[mid] == target) return mid; // nums[4] == 0, return 4
   ```

### Expected Result:

```csharp
int result = Search(nums, target);
// Expected output: 4
```

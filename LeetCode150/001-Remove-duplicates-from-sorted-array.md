## Problem Statememt

Given an integer array `nums` **sorted in non-decreasing order**, remove the duplicates **in-place** such that each unique element appears only once. The relative order of the elements should be kept the same.

Then return the number of unique elements in `nums`.

> Consider the number of unique elements of `nums` to be `k`, to get accepted, you need to:
> 
> - Change the array `nums` such that the first `k` elements contain the unique elements in the same order as they were initially.
> - Return `k`.
> 
> The elements beyond index `k` do not matter.

### Input:
`nums = [0,0,1,1,1,2,2,3,3,4]`

### Output:
`k = 5, nums = [0,1,2,3,4,,,,,_]`

## 🔍 Constraints

- `1 <= nums.length <= 30,000`
- `-100 <= nums[i] <= 100`
- The array is already **sorted in non-decreasing order**

---

## 💻 C# Solution with Embedded Example Walkthrough

Since the array is **sorted**, all duplicates will be **adjacent**. We can iterate through the array and keep track of the **next position to place a unique element** using a **two-pointer** technique.

### ⚙️ Strategy:
- Use two pointers:  
  - `i` → Scans the entire array  
  - `k` → Points to the index where the next unique element should go
- Initialize `k = 1` (we assume the first element is always unique).
- For every `nums[i]`:
  - If `nums[i] != nums[k - 1]` → it's a new unique number → copy to `nums[k]` and increment `k`.

## ⏱️ Time & Space Complexity

- **Time Complexity:** O(n) — One pass through the array
- **Space Complexity:** O(1) — In-place, no extra data structures used
  
```csharp
public class Solution {
    // Removes duplicates from a sorted array in-place and returns count of unique elements
    // Example Input: nums = [0,0,1,1,1,2,2,3,3,4]
    public int RemoveDuplicates(int[] nums) {
        
        // Edge case: empty array
        if (nums.Length == 0) 
            return 0;

        // Pointer `k` represents the position to place the next unique element.
        // We start from index 1, assuming the first element is always unique.
        int k = 1;

        // Step-by-step walkthrough with example nums = [0,0,1,1,1,2,2,3,3,4]
        // Initial: nums[0] = 0 is unique → k = 1
        for (int i = 1; i < nums.Length; i++) {
            // i = 1 → nums[1] == nums[0] → skip (duplicate)
            // i = 2 → nums[2] != nums[0] → nums[1] = 1, k = 2
            // i = 3 → nums[3] == nums[1] → skip (duplicate)
            // i = 4 → nums[4] == nums[1] → skip
            // i = 5 → nums[5] != nums[1] → nums[2] = 2, k = 3
            // i = 6 → nums[6] == nums[2] → skip
            // i = 7 → nums[7] != nums[2] → nums[3] = 3, k = 4
            // i = 8 → nums[8] == nums[3] → skip
            // i = 9 → nums[9] != nums[3] → nums[4] = 4, k = 5

            if (nums[i] != nums[k - 1]) 
            {
                nums[k] = nums[i]; // Place it at the next unique position
                k++; // Move the unique pointer
            }
        }

        // At the end of the loop:
        // nums = [0,1,2,3,4,2,2,3,3,4] (first 5 elements are unique)
        // k = 5 → return value

        // Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        return k;
    }
}
```

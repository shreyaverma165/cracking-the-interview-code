using System;

public class Solution
{
    // Function to search in a rotated sorted array
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        // Perform binary search
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if the mid element is the target
            if (nums[mid] == target)
            {
                return mid;
            }

            // Determine which side is properly sorted
            if (nums[left] <= nums[mid])
            {
                // Left side is sorted
                if (nums[left] <= target && target < nums[mid])
                {
                    right = mid - 1; // Target is in the left side
                }
                else
                {
                    left = mid + 1; // Target is in the right side
                }
            }
            else
            {
                // Right side is sorted
                if (nums[mid] < target && target <= nums[right])
                {
                    left = mid + 1; // Target is in the right side
                }
                else
                {
                    right = mid - 1; // Target is in the left side
                }
            }
        }

        // Target not found
        return -1;
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = {4, 5, 6, 7, 0, 1, 2};
        int target = 0;
        int result = solution.Search(nums, target);
        Console.WriteLine(result); // Expected output: 4
    }
}

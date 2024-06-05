from typing import List

class Solution:
    def search(self, nums: List[int], target: int) -> int:
        left, right = 0, len(nums) - 1

        # Perform binary search
        while left <= right:
            mid = left + (right - left) // 2

            # Check if the mid element is the target
            if nums[mid] == target:
                return mid

            # Determine which side is properly sorted
            if nums[left] <= nums[mid]:
                # Left side is sorted
                if nums[left] <= target < nums[mid]:
                    right = mid - 1  # Target is in the left side
                else:
                    left = mid + 1  # Target is in the right side
            else:
                # Right side is sorted
                if nums[mid] < target <= nums[right]:
                    left = mid + 1  # Target is in the right side
                else:
                    right = mid - 1  # Target is in the left side

        # Target not found
        return -1

# Example usage
if __name__ == "__main__":
    solution = Solution()
    nums = [4, 5, 6, 7, 0, 1, 2]
    target = 0
    result = solution.search(nums, target)
    print(result)  # Expected output: 4

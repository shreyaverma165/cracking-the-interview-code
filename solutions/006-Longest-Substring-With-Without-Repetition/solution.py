from typing import Dict

class Solution:
    def longest_substring_without_repetition(self, s: str) -> int:
        n = len(s)
        max_length = 0
        char_index_map: Dict[str, int] = {}
        start = 0

        for end in range(n):
            current_char = s[end]

            if current_char in char_index_map:
                start = max(start, char_index_map[current_char] + 1)

            char_index_map[current_char] = end
            max_length = max(max_length, end - start + 1)

        return max_length

    def longest_substring_with_two_repeating_characters(self, s: str) -> int:
        n = len(s)
        max_length = 0
        char_count_map: Dict[str, int] = {}
        start = 0
        distinct_count = 0

        for end in range(n):
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

        return max_length

# Example usage
if __name__ == "__main__":
    solution = Solution()
    s = "abcabcbb"
    result_without_repetition = solution.longest_substring_without_repetition(s)
    result_with_two_repeating = solution.longest_substring_with_two_repeating_characters(s)
    print(result_without_repetition)  # Expected output: 3
    print(result_with_two_repeating)  # Expected output: 7

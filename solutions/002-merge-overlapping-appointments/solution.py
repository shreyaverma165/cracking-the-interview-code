from typing import List

class Interval:
    def __init__(self, start: int, end: int):
        self.start = start
        self.end = end

    def __repr__(self):
        return f'[{self.start}, {self.end}]'

class Solution:
    def mergeIntervals(self, intervals: List[Interval]) -> List[Interval]:
        if not intervals:
            return []

        # Sort intervals based on the start time
        intervals.sort(key=lambda x: x.start)
        merged = []

        # Initialize the first interval as the starting point
        current = intervals[0]

        # Iterate through each interval
        for interval in intervals:
            # If the current interval overlaps with the next interval, merge them
            if current.end >= interval.start:
                current.end = max(current.end, interval.end)
            else:
                # Otherwise, add the current interval to the merged list and move to the next interval
                merged.append(current)
                current = interval

        # Add the last interval
        merged.append(current)

        return merged

# Example usage
if __name__ == "__main__":
    intervals = [
        Interval(1, 3),
        Interval(2, 6),
        Interval(8, 10),
        Interval(15, 18)
    ]

    solution = Solution()
    result = solution.mergeIntervals(intervals)

    for interval in result:
        print(interval)

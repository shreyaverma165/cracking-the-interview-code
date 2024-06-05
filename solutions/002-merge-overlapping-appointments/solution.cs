using System;
using System.Collections.Generic;
using System.Linq;

public class Interval
{
    public int Start { get; set; }
    public int End { get; set; }

    public Interval(int start, int end)
    {
        Start = start;
        End = end;
    }

    public override string ToString()
    {
        return $"[{Start}, {End}]";
    }
}

public class Solution
{
    public List<Interval> MergeIntervals(List<Interval> intervals)
    {
        if (intervals == null || intervals.Count == 0)
            return new List<Interval>();

        // Sort the intervals by their start time
        intervals.Sort((a, b) => a.Start.CompareTo(b.Start));
        var merged = new List<Interval>();

        // Initialize the first interval as the starting point
        var current = intervals[0];

        // Iterate through each interval
        foreach (var interval in intervals)
        {
            // If the current interval overlaps with the next interval, merge them
            if (current.End >= interval.Start)
            {
                current.End = Math.Max(current.End, interval.End);
            }
            else
            {
                // Otherwise, add the current interval to the merged list and move to the next interval
                merged.Add(current);
                current = interval;
            }
        }

        // Add the last interval
        merged.Add(current);

        return merged;
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        List<Interval> intervals = new List<Interval>
        {
            new Interval(1, 3),
            new Interval(2, 6),
            new Interval(8, 10),
            new Interval(15, 18)
        };

        Solution solution = new Solution();
        List<Interval> result = solution.MergeIntervals(intervals);

        foreach (var interval in result)
        {
            Console.WriteLine(interval);
        }
    }
}

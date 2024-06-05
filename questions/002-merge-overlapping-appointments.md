## Merge Overlapping Appointments

### Description

Imagine you are working for a hospital that manages appointments for patients. Each appointment is represented by an interval indicating the start and end times. The hospital wants to merge overlapping appointments to optimize room utilization and scheduling. Your task is to implement a feature that merges overlapping appointment intervals.

### Requirements

1. **Function Signature:** 
   ```csharp
   public List<Interval> MergeIntervals(List<Interval> intervals);
   ```

2. **Input:**
   - `intervals`: A list of intervals where each interval is represented as a class with two integers `Start` and `End`.

3. **Output:**
   - Return a list of merged intervals where overlapping intervals are combined into a single interval.

4. **Constraints:**
   - The intervals may not be sorted initially.
   - All intervals are positive integers.

**Extra Credit:**
   - Implement the solution to handle edge cases such as empty intervals list, intervals with the same start and end times, etc.

**Example:**

Given the following list of intervals:

```csharp
public class Interval
{
    public int Start { get; set; }
    public int End { get; set; }

    public Interval(int start, int end)
    {
        Start = start;
        End = end;
    }
}

// Example usage
List<Interval> intervals = new List<Interval>
{
    new Interval(1, 3),
    new Interval(2, 6),
    new Interval(8, 10),
    new Interval(15, 18)
};
```

**The function should return:**

```csharp
List<Interval> result = MergeIntervals(intervals);
// Expected output: [[1, 6], [8, 10], [15, 18]]
```

**Hints:**

- Consider sorting the list of intervals based on the start times before attempting to merge them.
- Use a list to keep track of merged intervals, iterating through the sorted intervals and merging them as needed.

**Sample Dataset:**

```csharp
List<Interval> intervals = new List<Interval>
{
    new Interval(1, 4),
    new Interval(4, 5)
};
```

**Expected Output for Sample Dataset:**

```csharp
List<Interval> result = MergeIntervals(intervals);
// Expected output: [[1, 5]]
```

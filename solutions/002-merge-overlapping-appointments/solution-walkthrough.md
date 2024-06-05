### Solution Walkthrough

1. **Initialization and Sorting:**
   - The list of intervals is sorted based on the start time of each interval.
   - **Sorted Intervals:** `[[1, 3], [2, 6], [8, 10], [15, 18]]`

2. **Merging Intervals:**
   - Initialize the first interval as the `current` interval.
   - **Current Interval:** `[1, 3]`
   - Iterate through the sorted list of intervals:
     - **Next Interval:** `[2, 6]`
     - Since the `current` interval `[1, 3]` overlaps with `[2, 6]`, merge them into `[1, 6]`.
     - **Updated Current Interval:** `[1, 6]`
     - **Next Interval:** `[8, 10]`
     - Since `[1, 6]` does not overlap with `[8, 10]`, add `[1, 6]` to the result and update the `current` interval to `[8, 10]`.
     - **Updated Current Interval:** `[8, 10]`
     - **Next Interval:** `[15, 18]`
     - Since `[8, 10]` does not overlap with `[15, 18]`, add `[8, 10]` to the result and update the `current` interval to `[15, 18]`.
     - **Updated Current Interval:** `[15, 18]`

3. **Final Step:**
   - Add the last `current` interval `[15, 18]` to the result list.

#### Expected Result:

```csharp
List<Interval> result = MergeIntervals(intervals);
// Expected output: [[1, 6], [8, 10], [15, 18]]
```

#### Code Visualization

**Initial Intervals:**
```
[1, 3], [2, 6], [8, 10], [15, 18]
```

**Step-by-Step Merging Process:**

1. **Sort Intervals:**
   ```
   [1, 3], [2, 6], [8, 10], [15, 18]
   ```

2. **Initialize Current Interval:**
   ```
   Current: [1, 3]
   ```

3. **Process Next Interval:**
   ```
   Current: [1, 6] (Merged with [2, 6])
   ```

4. **Add to Result and Update Current:**
   ```
   Result: [[1, 6]]
   Current: [8, 10]
   ```

5. **Process Next Interval:**
   ```
   Result: [[1, 6], [8, 10]]
   Current: [15, 18]
   ```

6. **Final Result:**
   ```
   Result: [[1, 6], [8, 10], [15, 18]]
   ```

The code efficiently merges overlapping intervals by first sorting the intervals and then using a linear scan to merge them as needed.

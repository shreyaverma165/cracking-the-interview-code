
## Course Scheduler I

### Description

Imagine you are working at a university that offers multiple courses. Each course has certain prerequisites that must be completed before it can be taken. Your task is to determine if it is possible for a student to finish all courses given the list of prerequisites.

### Requirements

1. **Function Signature:** 
   ```csharp
   public bool CanFinish(int numCourses, int[][] prerequisites);
   ```

2. **Input:**
   - `numCourses`: An integer representing the total number of courses.
   - `prerequisites`: A list of pairs where each pair `[a, b]` indicates that course `a` must be taken after course `b`.

3. **Output:**
   - Return a boolean value indicating whether it is possible to finish all courses.

4. **Constraints:**
   - The input may contain duplicate pairs.
   - The number of courses and prerequisites are non-negative integers.

**Extra Credit:**
   - Optimize the solution to handle large datasets efficiently.

**Example:**
   ```csharp
   int numCourses = 2;
   int[][] prerequisites = new int[][] { new int[] { 1, 0 } };
   ```

**The function should return:**
   ```csharp
   bool result = CanFinish(numCourses, prerequisites);
   // Expected output: true
   ```

**Hints:**
   - Use topological sorting to detect cycles in the graph of courses.

**Sample Dataset:**
   ```csharp
   int numCourses = 3;
   int[][] prerequisites = new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 2, 0 } };
   ```

**Expected Output for Sample Dataset:**
   ```csharp
   bool result = CanFinish(numCourses, prerequisites);
   // Expected output: false
   ```

---

## Course Scheduler II

### Description

Continuing from Course Scheduler I, you now need to find an order in which the courses should be taken to finish all courses. If there are multiple valid orders, return any one of them. If it is impossible to finish all courses, return an empty array.

### Requirements

1. **Function Signature:** 
   ```csharp
   public int[] FindOrder(int numCourses, int[][] prerequisites);
   ```

2. **Input:**
   - `numCourses`: An integer representing the total number of courses.
   - `prerequisites`: A list of pairs where each pair `[a, b]` indicates that course `a` must be taken after course `b`.

3. **Output:**
   - Return an array of integers representing the order in which courses should be taken.

4. **Constraints:**
   - The input may contain duplicate pairs.
   - The number of courses and prerequisites are non-negative integers.

**Extra Credit:**
   - Optimize the solution to handle large datasets efficiently.

**Example:**
   ```csharp
   int numCourses = 4;
   int[][] prerequisites = new int[][] { new int[] { 1, 0 }, new int[] { 2, 0 }, new int[] { 3, 1 }, new int[] { 3, 2 } };
   ```

**The function should return:**
   ```csharp
   int[] result = FindOrder(numCourses, prerequisites);
   // Expected output: [0, 1, 2, 3] or any other valid order
   ```

**Hints:**
   - Use topological sorting to determine the order of courses.

**Sample Dataset:**
   ```csharp
   int numCourses = 2;
   int[][] prerequisites = new int[][] { new int[] { 1, 0 } };
   ```

**Expected Output for Sample Dataset:**
   ```csharp
   int[] result = FindOrder(numCourses, prerequisites);
   // Expected output: [0, 1]
   ```

---

## Course Scheduler III

### Description

You are given `n` courses to take, each with a duration and a last day by which it must be completed. Your task is to find the maximum number of courses that can be taken without exceeding the deadlines.

### Requirements

1. **Function Signature:** 
   ```csharp
   public int ScheduleCourse(int[][] courses);
   ```

2. **Input:**
   - `courses`: A list of courses where each course is represented as a pair `[duration, lastDay]`.

3. **Output:**
   - Return the maximum number of courses that can be taken.

4. **Constraints:**
   - Each course has a positive duration and a positive last day.

**Extra Credit:**
   - Optimize the solution to handle large datasets efficiently.

**Example:**
   ```csharp
   int[][] courses = new int[][] { new int[] { 100, 200 }, new int[] { 200, 1300 }, new int[] { 1000, 1250 }, new int[] { 2000, 3200 } };
   ```

**The function should return:**
   ```csharp
   int result = ScheduleCourse(courses);
   // Expected output: 3
   ```

**Hints:**
   - Use a greedy algorithm with a max heap to optimize the number of courses taken.

**Sample Dataset:**
   ```csharp
   int[][] courses = new int[][] { new int[] { 5, 5 }, new int[] { 4, 6 }, new int[] { 2, 6 } };
   ```

**Expected Output for Sample Dataset:**
   ```csharp
   int result = ScheduleCourse(courses);
   // Expected output: 2
   ```

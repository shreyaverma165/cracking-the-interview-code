
## Solution Walkthrough and Visualization

## Course Scheduler I

### Problem Statement

Given the number of courses and a list of prerequisites, determine if it is possible to finish all courses.

### Example Data Set in C#:

```csharp
int numCourses = 2;
int[][] prerequisites = new int[][] { new int[] { 1, 0 } };

// Expected output: true
bool result = CanFinish(numCourses, prerequisites);
```

### Solution Walkthrough

1. **Graph Representation:**
   - Create an adjacency list to represent the graph:
     ```
     graph = [[], [0]]
     ```

2. **Cycle Detection:**
   - Use a `visited` array to track the state of each node:
     ```
     visited = [0, 0]
     ```

3. **DFS Traversal:**
   - Start DFS from node 0:
     ```
     visited = [1, 0]
     visited = [2, 0]
     ```
   - Start DFS from node 1:
     ```
     visited = [2, 1]
     visited = [2, 2]
     ```

### Expected Result:

```csharp
bool result = CanFinish(numCourses, prerequisites);
// Expected output: true
```

---

## Course Scheduler II

### Problem Statement

Given the number of courses and a list of prerequisites, find an order in which courses should be taken to finish all courses.

### Example Data Set in C#:

```csharp
int numCourses = 4;
int[][] prerequisites = new int[][] { new int[] { 1, 0 }, new int[] { 2, 0 }, new int[] { 3, 1 }, new int[] { 3, 2 } };

// Expected output: [0, 1, 2, 3] or any other valid order
int[] result = FindOrder(numCourses, prerequisites);
```

### Solution Walkthrough

1. **Graph Representation:**
   - Create an adjacency list to represent the graph:
     ```
     graph = [[1, 2], [], [3], [3]]
     ```

2. **In-degree Calculation:**
   - Calculate the in-degree of each node:
     ```
     indegree = [0, 1, 1, 2]
     ```

3. **Topological Sorting:**
   - Initialize the queue with nodes having in-degree 0:
     ```
     queue = [0]
     ```
   - Process nodes in the queue:
     ```
     order = [0]
     queue = [1, 2]
     order = [0, 1]
     queue = [2, 3]
     order = [0, 1, 2]
     queue = [3]
     order = [0, 1, 2, 3]
     ```

### Expected Result:

```csharp
int[] result = FindOrder(numCourses, prerequisites);
// Expected output: [0, 1, 2, 3]
```

---

## Course Scheduler III

### Problem Statement

Given a list of courses with their durations and last days, find the maximum number of courses that can be taken without exceeding the deadlines.

### Example Data Set in C#:

```csharp
int[][] courses = new int[][] { new int[] { 100, 200 }, new int[] { 200, 1300 }, new int[] { 1000, 1250 }, new int[] { 2000, 3200 } };

// Expected output: 3
int result = ScheduleCourse(courses);
```

### Solution Walkthrough

1. **Course Sorting:**
   - Sort courses by their end times:
     ```
     courses = [[100, 200], [1000, 1250], [200, 1300], [2000, 3200]]
     ```

2. **Greedy Algorithm with Max Heap:**
   - Initialize the current time and max heap:
     ```
     currentTime = 0
     maxHeap = []
     ```
   - Process each course:
     - Add course [100, 200]:
       ```
       currentTime = 100
       maxHeap = [100]
       ```
     - Add course [1000, 1250]:
       ```
       currentTime = 1100
       maxHeap = [100, 1000]
       ```
     - Replace course in max heap with [200, 1300]:
       ```
       currentTime = 1300
       maxHeap = [200, 1000]
       ```
     - Add course [2000, 3200]:
       ```
       currentTime = 3300
       maxHeap = [200, 1000, 2000]
       ```

### Expected Result:

```csharp
int result = ScheduleCourse(courses);
// Expected output: 3
```

The code efficiently schedules the maximum number of courses by using a greedy algorithm with a max heap, ensuring that the total duration of selected courses does not exceed the deadlines.

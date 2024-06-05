using System;
using System.Collections.Generic;

public class Solution
{
    // Course Scheduler I
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        // Create an adjacency list to represent the graph
        List<int>[] graph = new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++)
            graph[i] = new List<int>();

        // Fill the adjacency list with the prerequisites
        foreach (var pre in prerequisites)
            graph[pre[1]].Add(pre[0]);

        // Array to keep track of visited nodes
        int[] visited = new int[numCourses];

        // Perform DFS to detect cycles
        for (int i = 0; i < numCourses; i++)
        {
            if (HasCycle(graph, visited, i))
                return false; // If a cycle is detected, return false
        }

        return true; // If no cycles are detected, return true
    }

    private bool HasCycle(List<int>[] graph, int[] visited, int course)
    {
        if (visited[course] == 1)
            return true; // Cycle detected
        if (visited[course] == 2)
            return false; // Already visited node

        visited[course] = 1; // Mark the node as visiting

        foreach (var neighbor in graph[course])
        {
            if (HasCycle(graph, visited, neighbor))
                return true; // If a cycle is detected, return true
        }

        visited[course] = 2; // Mark the node as visited
        return false; // No cycle detected
    }

    // Course Scheduler II
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        // Create an adjacency list to represent the graph
        List<int>[] graph = new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++)
            graph[i] = new List<int>();

        // Array to keep track of the in-degree of each node
        int[] indegree = new int[numCourses];
        foreach (var pre in prerequisites)
        {
            graph[pre[1]].Add(pre[0]);
            indegree[pre[0]]++;
        }

        // Queue to perform BFS
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++)
        {
            if (indegree[i] == 0)
                queue.Enqueue(i); // Add nodes with 0 in-degree to the queue
        }

        List<int> order = new List<int>();
        while (queue.Count > 0)
        {
            int course = queue.Dequeue();
            order.Add(course); // Add the node to the order
            foreach (var neighbor in graph[course])
            {
                indegree[neighbor]--;
                if (indegree[neighbor] == 0)
                    queue.Enqueue(neighbor); // Add nodes with 0 in-degree to the queue
            }
        }

        if (order.Count == numCourses)
            return order.ToArray(); // If all nodes are added, return the order
        else
            return new int[0]; // If not all nodes are added, return an empty array
    }

    // Course Scheduler III
    public int ScheduleCourse(int[][] courses)
    {
        // Sort courses by their end times
        Array.Sort(courses, (a, b) => a[1] - b[1]);
        
        // Max heap to keep track of course durations
        PriorityQueue<int> maxHeap = new PriorityQueue<int>(Comparer<int>.Create((a, b) => b - a));
        
        int currentTime = 0; // Initialize the current time

        foreach (var course in courses)
        {
            if (currentTime + course[0] <= course[1])
            {
                currentTime += course[0]; // Add course duration to current time
                maxHeap.Enqueue(course[0]); // Add course duration to the max heap
            }
            else if (maxHeap.Count > 0 && maxHeap.Peek() > course[0])
            {
                currentTime += course[0] - maxHeap.Dequeue(); // Replace the longest course with the current one
                maxHeap.Enqueue(course[0]); // Add current course duration to the max heap
            }
        }

        return maxHeap.Count; // Return the number of courses that can be taken
    }
}

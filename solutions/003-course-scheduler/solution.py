from collections import deque
from typing import List
import heapq

class Solution:
    # Course Scheduler I
    def canFinish(self, numCourses: int, prerequisites: List[List[int]]) -> bool:
        # Create an adjacency list to represent the graph
        graph = [[] for _ in range(numCourses)]
        for pre in prerequisites:
            graph[pre[1]].append(pre[0])
        
        # Array to keep track of visited nodes
        visited = [0] * numCourses

        def hasCycle(course: int) -> bool:
            if visited[course] == 1:
                return True  # Cycle detected
            if visited[course] == 2:
                return False  # Already visited node
            
            visited[course] = 1  # Mark the node as visiting
            for neighbor in graph[course]:
                if hasCycle(neighbor):
                    return True
            visited[course] = 2  # Mark the node as visited
            return False

        for i in range(numCourses):
            if hasCycle(i):
                return False

        return True

    # Course Scheduler II
    def findOrder(self, numCourses: int, prerequisites: List[List[int]]) -> List[int]:
        # Create an adjacency list to represent the graph
        graph = [[] for _ in range(numCourses)]
        indegree = [0] * numCourses
        for pre in prerequisites:
            graph[pre[1]].append(pre[0])
            indegree[pre[0]] += 1
        
        # Queue to perform BFS
        queue = deque([i for i in range(numCourses) if indegree[i] == 0])
        order = []

        while queue:
            course = queue.popleft()
            order.append(course)  # Add the node to the order
            for neighbor in graph[course]:
                indegree[neighbor] -= 1
                if indegree[neighbor] == 0:
                    queue.append(neighbor)  # Add nodes with 0 in-degree to the queue

        if len(order) == numCourses:
            return order  # If all nodes are added, return the order
        else:
            return []  # If not all nodes are added, return an empty array

    # Course Scheduler III
    def scheduleCourse(self, courses: List[List[int]]) -> int:
        # Sort courses by their end times
        courses.sort(key=lambda x: x[1])
        
        # Max heap to keep track of course durations
        max_heap = []
        current_time = 0  # Initialize the current time

        for duration, last_day in courses:
            if current_time + duration <= last_day:
                current_time += duration  # Add course duration to current time
                heapq.heappush(max_heap, -duration)  # Add course duration to the max heap
            elif max_heap and -max_heap[0] > duration:
                current_time += duration + heapq.heappop(max_heap)  # Replace the longest course with the current one
                heapq.heappush(max_heap, -duration)  # Add current course duration to the max heap

        return len(max_heap)  # Return the number of courses that can be taken

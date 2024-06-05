## Data Structures Cheat Sheet
Here is a list of 10 common data structures, their time and space complexities for various operations along with their typical applications.

| Data Structure | Access    | Search    | Insertion | Deletion | Space   | Explanation |
|----------------|-----------|-----------|-----------|----------|---------|-------------|
| **Array**      | O(1)      | O(n)      | O(n)      | O(n)     | O(n)    | Arrays provide direct access to elements via indices but require shifting elements for insertions and deletions, leading to linear time complexities for those operations. |
| **LinkedList** | O(n)      | O(n)      | O(1)      | O(1)     | O(n)    | Linked lists consist of nodes that point to the next node, allowing efficient insertions and deletions but requiring traversal for access and search operations. |
| **Stack**      | O(n)      | O(n)      | O(1)      | O(1)     | O(n)    | Stacks follow a Last-In-First-Out (LIFO) principle, making push and pop operations efficient while access and search operations are linear. |
| **Queue**      | O(n)      | O(n)      | O(1)      | O(1)     | O(n)    | Queues follow a First-In-First-Out (FIFO) principle, making enqueue and dequeue operations efficient while access and search operations are linear. |
| **Hash Table** | O(1)      | O(1)      | O(1)      | O(1)     | O(n)    | Hash tables use a hash function to map keys to indices, allowing for average constant-time operations. Poor hash functions or high load factors can degrade performance. |
| **Heap**       | O(1)      | O(n)      | O(log n)  | O(log n) | O(n)    | Heaps are complete binary trees that allow efficient retrieval of the minimum (or maximum) element and efficient insertions and deletions while maintaining the heap property. |
| **Graph**      | O(1)      | O(V+E)    | O(1)      | O(V+E)   | O(V+E)  | Graphs represent relationships between entities, with operations often involving traversal of vertices and edges. |
| **Tree**       | O(log n)  | O(log n)  | O(log n)  | O(log n) | O(n)    | Binary search trees allow efficient searching, insertion, and deletion, with operations depending on the tree's height. |
| **Trie**       | O(m)      | O(m)      | O(m)      | O(m)     | O(ALPHABET_SIZE * n) | Tries are specialized trees used for storing strings, where each node represents a character. Operations depend on the length of the string. |
| **Segment Tree** | O(n)  | O(log n)  | O(log n)  | O(log n) | O(n)    | Segment trees allow efficient range queries and updates, with operations depending on the height of the tree. |

### Applications

#### Array
1. Sorting algorithms (Quick Sort, Merge Sort)
2. Binary Search
3. Storing data in a fixed-size collection
4. Implementing other data structures (e.g., hash tables, heaps)
5. Dynamic programming

#### LinkedList
1. Dynamic memory allocation
2. Implementing stacks and queues
3. Maintaining an ordered collection with frequent insertions/deletions
4. Undo functionality in applications
5. Navigation in photo viewers

#### Stack
1. Expression evaluation (postfix evaluation)
2. Function call management (recursion)
3. Depth-First Search (DFS)
4. Backtracking algorithms
5. Parsing expressions

#### Queue
1. Order processing systems
2. Breadth-First Search (BFS)
3. Scheduling tasks (e.g., CPU scheduling)
4. Handling requests in web servers
5. Printer task scheduling

#### Hash Table
1. Implementing associative arrays
2. Caching and indexing
3. Counting frequency of elements
4. Removing duplicates
5. Implementing sets and maps

#### Heap
1. Priority queues
2. Scheduling algorithms
3. Finding the k largest/smallest elements
4. Merge k sorted lists
5. Implementing Dijkstra's shortest path algorithm

#### Graph
1. Network routing
2. Social network analysis
3. Finding shortest paths
4. Detecting cycles
5. Representing connections in a network (e.g., road maps)

#### Tree
1. Hierarchical data representation
2. Database indexing (e.g., B-trees)
3. Implementing search trees (e.g., Binary Search Tree, AVL Tree, Red-Black Tree)
4. Parsing expressions
5. File system structures

#### Trie
1. Implementing dictionaries for spell checking
2. Auto-complete features
3. IP routing (Longest Prefix Matching)
4. Storing a predictive text model
5. Searching for patterns in text

#### Segment Tree
1. Range queries (sum, minimum, maximum)
2. Interval problems
3. Implementing range updates
4. Finding the minimum or maximum of a range
5. Lazy propagation

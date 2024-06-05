# Finding Unique Triplets in Transactions

## Description

Imagine your microservice is part of an intelligent transaction analysis system that helps in identifying unusual spending patterns. By identifying these triplets, the system can trigger alerts for potential fraudulent activity or target customers for high-value promotions. Efficient processing and handling of large datasets are critical for real-time analysis and decision-making.

Your task is to develop a microservice to analyze these transactions and identify specific spending patterns. One key requirement is to identify all unique sets of three transactions that sum up to a specified target value. This functionality is crucial for detecting high-value transaction patterns and triggering corresponding business logic, such as fraud detection or personalized promotions.

## Requirements

1. **Function Signature:** 
   ```csharp
   public List<List<int>> FindTransactionTriplets(List<int> transactions, int target);

2. **Input:**
   transactions: A list of integers where each integer represents the amount of a transaction.
   target: An integer representing the target sum for the triplet of transactions.

3. **Output:**
   Return a list of lists, where each inner list contains three integers that sum up to the target value. The triplets should be unique, meaning no two triplets should contain the same three elements, even in different order.

4. **Constraints:**
   The solution should efficiently handle a large list of transactions.
   Avoid duplicate triplets in the result.
   Implement logging to track the processing steps.
   Use appropriate caching mechanisms to optimize performance if the function is called frequently with the same dataset.

**Extra Credit:**
  Implement robust exception handling to manage potential errors such as null inputs, insufficient data, or storage access issues.

**Example:**
  Given the following list of transactions and a target sum:

  ```csharp
  List<int> transactions = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
  int target = 100;
  ```

**The function should return:**

  ```csharp
  List<List<int>> result = FindTransactionTriplets(transactions, target);
  // Expected output: [[10, 30, 60], [10, 40, 50], [20, 30, 50]]
  ```

**Hints:**
  Consider using a sorted list and a two-pointer approach to optimize the search for triplets.
  Implement logging at various stages of processing to help with debugging and monitoring.
  Use caching to store and quickly retrieve results for frequently queried datasets.

**Sample Dataset:**

Here is a sample dataset to test your function:

```csharp
List<int> transactions = new List<int> { 15, 10, 25, 30, 45, 60, 75, 90, 105, 120 };
int target = 100;
```

Expected Output for Sample Dataset:

```csharp
List<List<int>> result = FindTransactionTriplets(transactions, target);
// Expected output: [[15, 25, 60], [10, 30, 60]]
```

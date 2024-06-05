
## Description

Imagine you are designing a rate limiter for an API that ensures no more than a certain number of requests are processed within a sliding time window. This rate limiter is crucial for preventing abuse and ensuring fair usage of the API.

## Requirements

1. **Function Signature:** 
   ```csharp
   public bool IsAllowed(string userId, int timestamp);
   ```

2. **Input:**
   - `userId`: A string representing the unique identifier of the user making the request.
   - `timestamp`: An integer representing the current timestamp of the request.

3. **Output:**
   - Return a boolean value indicating whether the request is allowed under the rate limiting rules.

4. **Constraints:**
   - The time window and maximum number of requests are pre-defined constants.
   - The function should efficiently handle a high volume of requests.

**Extra Credit:**
   - Implement the rate limiter to handle multiple API endpoints with different rate limiting rules.

**Example:**
   ```csharp
   // Assuming a rate limit of 5 requests per 10 seconds
   SlidingWindowRateLimiter rateLimiter = new SlidingWindowRateLimiter();
   rateLimiter.SetLimit("user1", 5, 10); // 5 requests per 10 seconds

   bool result1 = rateLimiter.IsAllowed("user1", 1);
   bool result2 = rateLimiter.IsAllowed("user1", 2);
   bool result3 = rateLimiter.IsAllowed("user1", 3);
   bool result4 = rateLimiter.IsAllowed("user1", 4);
   bool result5 = rateLimiter.IsAllowed("user1", 5);
   bool result6 = rateLimiter.IsAllowed("user1", 6); // Should return false as it exceeds the rate limit
   ```

**The function should return:**
   ```csharp
   bool result = rateLimiter.IsAllowed("user1", 6);
   // Expected output: false
   ```

**Hints:**
   - Use a queue or deque to efficiently manage timestamps of requests.
   - Ensure the rate limiter can handle concurrent requests efficiently.

**Sample Dataset:**
   ```csharp
   // Assuming a rate limit of 3 requests per 5 seconds
   SlidingWindowRateLimiter rateLimiter = new SlidingWindowRateLimiter();
   rateLimiter.SetLimit("user1", 3, 5); // 3 requests per 5 seconds

   bool result1 = rateLimiter.IsAllowed("user1", 1);
   bool result2 = rateLimiter.IsAllowed("user1", 2);
   bool result3 = rateLimiter.IsAllowed("user1", 3);
   bool result4 = rateLimiter.IsAllowed("user1", 4); // Should return false as it exceeds the rate limit
   ```

**Expected Output for Sample Dataset:**
   ```csharp
   bool result = rateLimiter.IsAllowed("user1", 4);
   // Expected output: false
   ```

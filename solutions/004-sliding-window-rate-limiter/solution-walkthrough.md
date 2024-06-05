### Sliding Window Rate Limiter

#### Problem Statement

Design a rate limiter that ensures no more than a certain number of requests are processed within a sliding time window. 

#### Example DataSet in C#:

```csharp
// Assuming a rate limit of 3 requests per 5 seconds
SlidingWindowRateLimiter rateLimiter = new SlidingWindowRateLimiter();
rateLimiter.SetLimit("user1", 3, 5); // 3 requests per 5 seconds

bool result1 = rateLimiter.IsAllowed("user1", 1);
bool result2 = rateLimiter.IsAllowed("user1", 2);
bool result3 = rateLimiter.IsAllowed("user1", 3);
bool result4 = rateLimiter.IsAllowed("user1", 4); // Should return false as it exceeds the rate limit

// Expected output: [true, true, true, false]
```

### Solution Walkthrough

1. **Initialization:**
   - Set the rate limit for user1 to 3 requests per 5 seconds.
   ```csharp
   rateLimiter.SetLimit("user1", 3, 5);
   ```

2. **First Request:**
   - Timestamp: 1
   - Action: Allow the request and add the timestamp to the queue.
   - Queue State: [1]
   - Result: true
   ```csharp
   bool result1 = rateLimiter.IsAllowed("user1", 1);
   ```

3. **Second Request:**
   - Timestamp: 2
   - Action: Allow the request and add the timestamp to the queue.
   - Queue State: [1, 2]
   - Result: true
   ```csharp
   bool result2 = rateLimiter.IsAllowed("user1", 2);
   ```

4. **Third Request:**
   - Timestamp: 3
   - Action: Allow the request and add the timestamp to the queue.
   - Queue State: [1, 2, 3]
   - Result: true
   ```csharp
   bool result3 = rateLimiter.IsAllowed("user1", 3);
   ```

5. **Fourth Request:**
   - Timestamp: 4
   - Action: Remove outdated timestamps (none in this case) and check the queue size. Deny the request as the queue size exceeds the limit.
   - Queue State: [1, 2, 3]
   - Result: false
   ```csharp
   bool result4 = rateLimiter.IsAllowed("user1", 4);
   ```

### Expected Result:

```csharp
bool[] results = { result1, result2, result3, result4 };
// Expected output: [true, true, true, false]
```

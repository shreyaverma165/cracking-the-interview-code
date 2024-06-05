using System;
using System.Collections.Generic;

public class SlidingWindowRateLimiter
{
    private class RateLimit
    {
        public int MaxRequests { get; set; }
        public int TimeWindow { get; set; }
        public Queue<int> Timestamps { get; set; }

        public RateLimit(int maxRequests, int timeWindow)
        {
            MaxRequests = maxRequests;
            TimeWindow = timeWindow;
            Timestamps = new Queue<int>();
        }
    }

    private Dictionary<string, RateLimit> userRateLimits = new Dictionary<string, RateLimit>();

    // Sets the rate limit for a user
    public void SetLimit(string userId, int maxRequests, int timeWindow)
    {
        if (userRateLimits.ContainsKey(userId))
        {
            userRateLimits[userId].MaxRequests = maxRequests;
            userRateLimits[userId].TimeWindow = timeWindow;
        }
        else
        {
            userRateLimits[userId] = new RateLimit(maxRequests, timeWindow);
        }
    }

    // Checks if a request is allowed for a user at a given timestamp
    public bool IsAllowed(string userId, int timestamp)
    {
        if (!userRateLimits.ContainsKey(userId))
        {
            throw new ArgumentException("User ID not found");
        }

        RateLimit rateLimit = userRateLimits[userId];
        Queue<int> timestamps = rateLimit.Timestamps;

        // Remove timestamps that are outside the time window
        while (timestamps.Count > 0 && timestamp - timestamps.Peek() >= rateLimit.TimeWindow)
        {
            timestamps.Dequeue();
        }

        // Check if the request can be allowed
        if (timestamps.Count < rateLimit.MaxRequests)
        {
            timestamps.Enqueue(timestamp);
            return true;
        }
        else
        {
            return false;
        }
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        SlidingWindowRateLimiter rateLimiter = new SlidingWindowRateLimiter();
        rateLimiter.SetLimit("user1", 3, 5); // 3 requests per 5 seconds

        bool result1 = rateLimiter.IsAllowed("user1", 1);
        bool result2 = rateLimiter.IsAllowed("user1", 2);
        bool result3 = rateLimiter.IsAllowed("user1", 3);
        bool result4 = rateLimiter.IsAllowed("user1", 4); // Should return false as it exceeds the rate limit

        Console.WriteLine(result1); // Expected: true
        Console.WriteLine(result2); // Expected: true
        Console.WriteLine(result3); // Expected: true
        Console.WriteLine(result4); // Expected: false
    }
}

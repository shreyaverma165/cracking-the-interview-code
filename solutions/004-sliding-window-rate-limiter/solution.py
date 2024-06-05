from collections import deque
from typing import Dict

class SlidingWindowRateLimiter:
    def __init__(self):
        self.user_rate_limits: Dict[str, dict] = {}

    def set_limit(self, user_id: str, max_requests: int, time_window: int):
        if user_id in self.user_rate_limits:
            self.user_rate_limits[user_id]['max_requests'] = max_requests
            self.user_rate_limits[user_id]['time_window'] = time_window
        else:
            self.user_rate_limits[user_id] = {
                'max_requests': max_requests,
                'time_window': time_window,
                'timestamps': deque()
            }

    def is_allowed(self, user_id: str, timestamp: int) -> bool:
        if user_id not in self.user_rate_limits:
            raise ValueError("User ID not found")

        rate_limit = self.user_rate_limits[user_id]
        timestamps = rate_limit['timestamps']

        # Remove timestamps that are outside the time window
        while timestamps and timestamp - timestamps[0] >= rate_limit['time_window']:
            timestamps.popleft()

        # Check if the request can be allowed
        if len(timestamps) < rate_limit['max_requests']:
            timestamps.append(timestamp)
            return True
        else:
            return False

# Example usage
if __name__ == "__main__":
    rate_limiter = SlidingWindowRateLimiter()
    rate_limiter.set_limit("user1", 3, 5)  # 3 requests per 5 seconds

    result1 = rate_limiter.is_allowed("user1", 1)
    result2 = rate_limiter.is_allowed("user1", 2)
    result3 = rate_limiter.is_allowed("user1", 3)
    result4 = rate_limiter.is_allowed("user1", 4)  # Should return false as it exceeds the rate limit

    print(result1)  # Expected: True
    print(result2)  # Expected: True
    print(result3)  # Expected: True
    print(result4)  # Expected: False

using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;

public class TransactionAnalyzer
{
    private readonly ILogger<TransactionAnalyzer> _logger;
    private readonly IMemoryCache _cache;

    public TransactionAnalyzer(ILogger<TransactionAnalyzer> logger, IMemoryCache cache)
    {
        _logger = logger;
        _cache = cache;
    }

    public List<List<int>> FindTransactionTriplets(List<int> transactions, int target)
    {
        try
        {
            _logger.LogInformation("Starting to find transaction triplets.");

            // Check if the transactions list is null
            if (transactions == null)
            {
                _logger.LogError("Transactions list is null.");
                throw new ArgumentNullException(nameof(transactions), "Transactions list cannot be null.");
            }

            // Check if the transactions list has less than 3 elements
            if (transactions.Count < 3)
            {
                _logger.LogError("Insufficient number of transactions provided.");
                throw new ArgumentException("The transactions list must contain at least three elements.");
            }

            // Create a cache key based on the transactions and target
            var cacheKey = $"{string.Join(",", transactions)}-{target}";
            if (_cache.TryGetValue(cacheKey, out List<List<int>> cachedResult))
            {
                _logger.LogInformation("Returning cached result.");
                return cachedResult;
            }

            List<List<int>> result = new List<List<int>>();
            transactions.Sort(); // Sort the transactions list

            // Loop through the transactions list to find triplets
            for (int i = 0; i < transactions.Count - 2; i++)
            {
                // Skip duplicate elements to avoid duplicate triplets
                if (i > 0 && transactions[i] == transactions[i - 1])
                    continue;

                int left = i + 1; // Initialize the left pointer
                int right = transactions.Count - 1; // Initialize the right pointer

                // Use a two-pointer approach to find triplets that sum up to the target
                while (left < right)
                {
                    int sum = transactions[i] + transactions[left] + transactions[right];

                    if (sum == target)
                    {
                        // Add the triplet to the result list
                        result.Add(new List<int> { transactions[i], transactions[left], transactions[right] });

                        // Skip duplicate elements
                        while (left < right && transactions[left] == transactions[left + 1])
                            left++;
                        while (left < right && transactions[right] == transactions[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            // Cache the result to improve performance for repeated queries
            _cache.Set(cacheKey, result, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10)
            });

            _logger.LogInformation("Transaction triplets finding completed.");
            return result;
        }
        catch (ArgumentNullException ex)
        {
            _logger.LogError(ex, "An error occurred due to null transactions list.");
            throw;
        }
        catch (ArgumentException ex)
        {
            _logger.LogError(ex, "An error occurred due to invalid arguments.");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unexpected error occurred.");
            throw;
        }
    }
}

from typing import List
import logging
from functools import lru_cache

# Configure logging
logging.basicConfig(level=logging.INFO)
logger = logging.getLogger()

class TransactionAnalyzer:
    @lru_cache(maxsize=None)
    def find_transaction_triplets(self, transactions: tuple, target: int) -> List[List[int]]:
        # Convert tuple back to list for processing
        transactions = list(transactions)
        logger.info("Starting to find transaction triplets.")
        
        # Validate the input
        if not transactions or len(transactions) < 3:
            logger.error("Invalid transaction list provided.")
            raise ValueError("The transactions list must contain at least three elements.")
        
        # Sort the transactions list to facilitate the two-pointer approach
        transactions.sort()
        result = []
        
        # Iterate through each transaction
        for i in range(len(transactions) - 2):
            # Skip duplicate elements to avoid duplicate triplets
            if i > 0 and transactions[i] == transactions[i - 1]:
                continue
            
            # Initialize the left and right pointers
            left, right = i + 1, len(transactions) - 1
            
            # Use two-pointer technique to find triplets that sum up to the target
            while left < right:
                current_sum = transactions[i] + transactions[left] + transactions[right]
                
                if current_sum == target:
                    # If the sum matches the target, add the triplet to the result list
                    result.append([transactions[i], transactions[left], transactions[right]])
                    
                    # Move the left pointer to the right, skipping duplicate elements
                    while left < right and transactions[left] == transactions[left + 1]:
                        left += 1
                    # Move the right pointer to the left, skipping duplicate elements
                    while left < right and transactions[right] == transactions[right - 1]:
                        right -= 1
                    
                    # Adjust pointers after finding a valid triplet
                    left += 1
                    right -= 1
                elif current_sum < target:
                    # If the sum is less than the target, move the left pointer to the right
                    left += 1
                else:
                    # If the sum is greater than the target, move the right pointer to the left
                    right -= 1
        
        logger.info("Transaction triplets finding completed.")
        return result

# Example usage
transactions = [10, 20, 30, 40, 50, 60, 70, 80, 90]
target = 100
analyzer = TransactionAnalyzer()
result = analyzer.find_transaction_triplets(tuple(transactions), target)
print("Result:", result)

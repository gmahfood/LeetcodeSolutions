// Problem: Top K Frequent Elements
// Difficulty: Medium
// Category: Arrays & Hashing
// Link: https://leetcode.com/problems/top-k-frequent-elements/

// Given an integer array nums and an integer k, return the k most
// frequent elements. You may return the answer in any order.
//
// Example 1:
//   Input:  nums = [1,2,2,3,3,3], k = 2
//   Output: [2,3]
//
// Example 2:
//   Input:  nums = [7,7,7,1,2], k = 1
//   Output: [7]

// Approach: Dictionary frequency count then sort by frequency
// Build a frequency dictionary by counting how many times each number appears.
// Then sort the dictionary keys by their frequency from highest to lowest
// and take only the top k elements.
//
// Time:  O(n log n) - sorting the dictionary keys
// Space: O(n) - storing every element in the dictionary

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            freq[num] = freq.GetValueOrDefault(num, 0) + 1; // count how many times each number appears
        }

        // sort keys by frequency from highest to lowest, take top k, return as array
        return freq.Keys.OrderByDescending(n => freq[n]).Take(k).ToArray();
    }
}

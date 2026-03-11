// ============================================================
// Problem: Contains Duplicate
// Difficulty: Easy
// Category: Arrays & Hashing
// Link: https://leetcode.com/problems/contains-duplicate/
// ============================================================

// PROBLEM DESCRIPTION:
// Given an integer array nums, return true if any value appears
// more than once in the array, otherwise return false.
//
// Example 1:
//   Input:  nums = [1, 2, 3, 3]
//   Output: true
//
// Example 2:
//   Input:  nums = [1, 2, 3, 4]
//   Output: false

// ============================================================
// APPROACH: HashSet
// ============================================================
// - Create an empty HashSet called "seen" to track numbers we've visited
// - Loop through every number in the array
// - If the number is already in the HashSet → duplicate found, return true
// - If not, add it to the HashSet and keep going
// - If I finish the loop with no duplicates found, return false

// TIME COMPLEXITY:  O(n) — I visit each element once
// SPACE COMPLEXITY: O(n) — in the worst case I store every element in the set

// ============================================================
// SOLUTION
// ============================================================

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var seen = new HashSet<int>(); // empty notebook to track seen numbers

        foreach (int num in nums)
        {
            if (seen.Contains(num))  // have we seen this number before?
                return true;         // yes, then duplicate found, stop and return true

            seen.Add(num);           // no, then write it in the notebook, keep going
        }

        return false; // finished the whole array with no duplicates
    }
}

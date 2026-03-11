// Problem: Two Sum
// Difficulty: Easy
// Category: Arrays & Hashing
// Link: https://leetcode.com/problems/two-sum/

// Given an array of integers nums and an integer target, return
// the indexes of the two numbers that add up to the target.
// You may assume that each input has exactly one solution, and
// you may not use the same element twice.
//
// Example 1:
//   Input:  nums = [2, 7, 11, 15], target = 9
//   Output: [0, 1] because nums[0] + nums[1] = 2 + 7 = 9
//
// Example 2:
//   Input:  nums = [3, 4, 2], target = 6
//   Output: [1, 2] because nums[1] + nums[2] = 4 + 2 = 6

// Approach: Dictionary One Pass
// For every number calculate its complement (target minus current).
// Check if that complement already exists in the Dictionary.
// If it does return both indexes. If not store the current number
// and its index and keep going. This avoids the slow two loop approach.
//
// Time:  O(n) - single pass through the array
// Space: O(n) - worst case store every element in the dictionary

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>(); // number -> index

        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];       // the number we are looking at right now
            int need = target - current; // the complement we need to reach the target

            if (map.ContainsKey(need))   // have we already seen the number we need?
            {
                return new int[] { map[need], i }; // yes! return both indexes
            }

            map[current] = i; // no, save current number and its index and keep going
        }

        return new int[] {}; // C# requires this even though it will never reach here
    }
}

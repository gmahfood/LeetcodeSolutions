// ============================================================
// Problem: Valid Anagram
// Difficulty: Easy
// Category: Arrays & Hashing
// Link: https://leetcode.com/problems/valid-anagram/
// ============================================================

// PROBLEM DESCRIPTION:
// Given two strings s and t, return true if t is an anagram
// of s, and false otherwise. An anagram is a word formed by
// rearranging the letters of another word using all original
// letters exactly once.
//
// Example 1:
//   Input:  s = "anagram", t = "nagaram"
//   Output: true
//
// Example 2:
//   Input:  s = "rat", t = "car"
//   Output: false

// ============================================================
// APPROACH: Dictionary Frequency Count
// ============================================================
// Count the frequency of each letter in s, then subtract the
// frequency of each letter in t. If all counts equal zero at
// the end, both strings use the exact same letters the same
// number of times meaning they are anagrams of each other.

// TIME COMPLEXITY:  O(n) — we loop through both strings once
// SPACE COMPLEXITY: O(n) — we store each unique character in the dictionary

// ============================================================
// SOLUTION
// ============================================================

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // if lengths differ they cannot be anagrams, no need to go further
        if (s.Length != t.Length)
            return false;

        // dictionary maps each character to how many times it appears
        var count = new Dictionary<char, int>();

        // loop through s and build up the frequency count for each letter
        foreach (char c in s)
            count[c] = count.GetValueOrDefault(c, 0) + 1;

        // loop through t and subtract from the frequency count for each letter
        foreach (char c in t)
            count[c] = count.GetValueOrDefault(c, 0) - 1;

        // if any character count is not zero the strings are not anagrams
        foreach (var pair in count)
            if (pair.Value != 0)
                return false;

        // all counts balanced out to zero meaning both strings match perfectly
        return true;
    }
}

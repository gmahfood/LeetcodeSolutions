// Problem: Roman to Integer
// Difficulty: Easy
// Category: Arrays & Hashing
// Link: https://leetcode.com/problems/roman-to-integer/

// Given a roman numeral string, convert it to an integer.
// Roman numerals are represented by seven symbols with fixed values.
// When a smaller value appears before a larger value it is subtracted
// rather than added.
//
// Example 1:
//   Input:  s = "III"
//   Output: 3
//
// Example 2:
//   Input:  s = "XIV"
//   Output: 14  (10 - 1 + 5)
//
// Example 3:
//   Input:  s = "MCMXCIV"
//   Output: 1994

// Approach: Dictionary lookup with left to right traversal
// Store each roman numeral and its value in a Dictionary.
// Loop through the string using a for loop so we can compare
// the current character to the next one. If the current value
// is less than the next value subtract it, otherwise add it.
// Check that a next character exists before comparing to avoid
// an index out of bounds error on the last character.
//
// Time:  O(n) - single pass through the string
// Space: O(1) - dictionary is fixed size of 7 entries

public class Solution
{
    public int RomanToInt(string s)
    {
        var roman = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // check next character exists before comparing to avoid index out of bounds
            if (i + 1 < s.Length && roman[s[i]] < roman[s[i + 1]])
            {
                result -= roman[s[i]]; // current is less than next so subtract
            }
            else
            {
                result += roman[s[i]]; // current is greater or equal so add
            }
        }

        return result;
    }
}

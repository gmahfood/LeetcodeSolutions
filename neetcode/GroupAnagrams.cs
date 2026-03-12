// Problem: Group Anagrams
// Difficulty: Medium
// Category: Arrays & Hashing
// Link: https://leetcode.com/problems/group-anagrams/

// Given an array of strings strs, group all anagrams together into sublists.
// You may return the output in any order.
//
// Example 1:
//   Input:  strs = ["act","pots","tops","cat","stop","hat"]
//   Output: [["hat"],["act","cat"],["stop","pots","tops"]]
//
// Example 2:
//   Input:  strs = ["x"]
//   Output: [["x"]]

// Approach: Dictionary with Sorted Signature as Key
// Sort each word alphabetically to get a signature that all anagrams share.
// For example "act" and "cat" both sort to "act" giving them the same key.
// Group all words that share the same signature into a list under that key.
// At the end return all the values from the dictionary as the grouped lists.
//
// Time:  O(n * k log k) - n is number of words, k is length of longest word
// Space: O(n) - store every word in the dictionary

public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var sorter = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            // sort the word to get its signature key that all anagrams share
            string key = new string(word.ToCharArray().OrderBy(c => c).ToArray());

            if (!sorter.ContainsKey(key))
            {
                sorter[key] = new List<string>(); // create empty list for this key
            }

            sorter[key].Add(word); // add current word to the list at this key
        }

        return new List<List<string>>(sorter.Values); // return all grouped lists
    }
}

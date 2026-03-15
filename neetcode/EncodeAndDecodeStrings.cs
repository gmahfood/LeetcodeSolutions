// Problem: Encode and Decode Strings
// Difficulty: Medium
// Category: Arrays & Hashing
// Link: https://neetcode.io/problems/string-encode-and-decode/question

// Design an algorithm to encode a list of strings to a single string
// and decode that single string back to the original list of strings.
//
// Example:
//   Input:  ["hello", "world"]
//   Encode: "5#hello5#world"
//   Decode: ["hello", "world"]

// Approach: Length prefix encoding
// For each word store its length followed by '#' then the word itself.
// This way during decode we always know exactly how many characters
// to grab regardless of what characters are inside the word.
// Find '#' to get the length, grab that many characters after '#',
// then move the position forward to the start of the next encoded word.
//
// Time:  O(n) - single pass for both encode and decode
// Space: O(n) - storing the encoded string and decoded list

public class Solution
{
    public string Encode(IList<string> strs)
    {
        string result = "";

        foreach (string word in strs)
        {
            result += word.Length + "#" + word; // "hello" becomes "5#hello"
        }

        return result;
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = s.IndexOf('#', i);                    // find the '#' from current position
            int length = int.Parse(s.Substring(i, j - i)); // grab everything from i to '#' as the length
            string word = s.Substring(j + 1, length);      // grab the word right after '#'
            result.Add(word);                               // add word to result list
            i = j + 1 + length;                            // move i forward to start of next encoded word
        }

        return result;
    }
}

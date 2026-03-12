# LeetCode/NeetCode Solutions
Personal collection of LeetCode problem solutions written in **C#**.

![Problems Solved](https://img.shields.io/badge/Problems%20Solved-4-brightgreen)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Runtime](https://img.shields.io/badge/Best%20Runtime-0ms%20%7C%20Beats%20100%25-gold)

---

## Structure
```
LeetcodeSolutions/
├── LeetCode/
│   └── 88_MergeSortedArray/
│       └── Solution88.cs
├── neetcode/
│   ├── ContainsDuplicate.cs
│   ├── ValidAnagram.cs
│   └── TwoSum.cs
```

---

## Solutions

### LeetCode
| # | Problem | Difficulty | Language | Runtime | Memory | Notes |
|---|---------|------------|----------|---------|--------|-------|
| 88 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | 🟢 Easy | C# | 0ms (beats 100%) | 46.53MB (beats 99.02%) | Two-pointer from end |

### NeetCode
| # | Problem | Difficulty | Language | Notes |
|---|---------|------------|----------|-------|
| 1 | [Contains Duplicate](https://leetcode.com/problems/contains-duplicate/) | 🟢 Easy | C# | HashSet |
| 2 | [Valid Anagram](https://leetcode.com/problems/valid-anagram/) | 🟢 Easy | C# | Dictionary frequency count |
| 3 | [Two Sum](https://leetcode.com/problems/two-sum/) | 🟢 Easy | C# | Dictionary one pass |

---

## Approach Highlights

### #88 — Merge Sorted Array
- **Strategy:** Two-pointer traversal starting from the **end** of both arrays
- Avoids overwriting unprocessed elements in `nums1`
- Time complexity: **O(m + n)** — single pass
- Space complexity: **O(1)** — in-place

### #1 — Contains Duplicate
- **Strategy:** HashSet to track previously seen numbers
- Loop through array, if number already in set a duplicate was found
- Time complexity: **O(n)** — single pass
- Space complexity: **O(n)** — worst case store every element

### #2 — Valid Anagram
- **Strategy:** Dictionary to count letter frequencies in s, then subtract frequencies from t
- If all counts balance to zero both strings use the exact same letters
- Time complexity: **O(n)** — loop through both strings once
- Space complexity: **O(n)** — store each unique character in the dictionary

### #3 — Two Sum
- **Strategy:** Dictionary to map each number to its index as we loop through once
- For every number calculate its complement (target minus current) and check if already seen
- Time complexity: **O(n)** — single pass through the array
- Space complexity: **O(n)** — worst case store every element in the dictionary

---

*Profile: [gsr_mahfood on LeetCode](https://leetcode.com/u/gsr_mahfood/)*
*Profile: [George Mahfood on NeetCode](https://neetcode.io/profile)*

# LeetCode/NeetCode Solutions
Personal collection of LeetCode problem solutions written in **C#**.

![Problems Solved](https://img.shields.io/badge/Problems%20Solved-2-brightgreen)
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
│   └── ContainsDuplicate.cs
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

---

## Approach Highlights

### #88 — Merge Sorted Array
- **Strategy:** Two-pointer traversal starting from the **end** of both arrays
- Avoids overwriting unprocessed elements in `nums1`
- Time complexity: **O(m + n)** — single pass
- Space complexity: **O(1)** — in-place

### #1 — Contains Duplicate
- **Strategy:** HashSet to track previously seen numbers
- Loop through array — if number already in set, duplicate found
- Time complexity: **O(n)** — single pass
- Space complexity: **O(n)** — worst case store every element

---

*Profile: [gsr_mahfood on LeetCode](https://leetcode.com/u/gsr_mahfood/)*
*Profile: [George Mahfood on NeetCode](https://neetcode.io/profile)*

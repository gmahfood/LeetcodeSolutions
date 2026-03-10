# 88. Merge Sorted Array

**Difficulty:** Easy  
**Language:** C#  
**Runtime:** 0ms (beats 100%)  
**Memory:** 46.53MB (beats 99.02%)

---

## Problem Statement

You are given two integer arrays `nums1` and `nums2`, sorted in non-decreasing order, and two integers `m` and `n`, representing the number of elements in `nums1` and `nums2` respectively.

Merge `nums2` into `nums1` as one sorted array in non-decreasing order.

**Note:** The final sorted array should not be returned by the function, but instead be stored inside the array `nums1`. To accommodate this, `nums1` has a length of `m + n`, where the first `m` elements denote the elements that should be merged, and the last `n` elements are set to 0 and should be ignored. `nums2` has a length of `n`.

---

## Examples

**Example 1:**
```
Input:  nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
```

**Example 2:**
```
Input:  nums1 = [1], m = 1, nums2 = [], n = 0
Output: [1]
```

**Example 3:**
```
Input:  nums1 = [0], m = 0, nums2 = [1], n = 1
Output: [1]
```

---

## Approach

- Use two pointers starting from the **end** of both arrays
- Compare and place the larger element at the back of `nums1`
- Avoids overwriting elements that haven't been read yet
- If any elements remain in `nums2`, copy them over

---

## Complexity

| | Complexity |
|---|---|
| Time | O(m + n) |
| Space | O(1) |
```

```
## Folder Structure
```
88_MergeSortedArray/
├── README.md       <- problem statement & approach
└── Solution88.cs  <- your code
```

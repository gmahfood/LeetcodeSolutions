
public class Solution
{
    static void Main(string[] args)
    {
        var solution = new Solution();

        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        solution.Merge(nums1, 3, nums2, 3);
        Console.WriteLine(string.Join(", ", nums1));
        // Expected: 1, 2, 2, 3, 5, 6
    }

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;         // last real element in nums1
        int j = n - 1;         // last real element in nums2
        int k = m + n - 1;     // last index of nums1

        // Compare from the end so we never overwrite elements we haven't read yet
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];  // nums1 element is larger, place it at the back
                i--;
            }
            else
            {
                nums1[k] = nums2[j];  // nums2 element is larger or equal, place it at the back
                j--;
            }
            k--;  // move the placement pointer left
        }

        // If there are still more elements in nums2[] copy them
        // (if i >= 0, those elements are already in place in nums1, so no action needed)
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }
}
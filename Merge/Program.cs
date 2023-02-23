using System;

namespace Merge//合并两个有序数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int m = 3, n = 3;
            Merge(nums1, m, nums2, n);

            Console.WriteLine();

            int[] nums3 = { 2, 0 };
            int[] nums4 = { 1 };
            int c = 1, k = 1;
            Merge(nums3, c, nums4, k);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p = m - 1, q = n - 1, k = nums1.Length - 1;
            while (p >= 0 && q >= 0)
            {
                if (nums1[p] > nums2[q])
                    nums1[k--] = nums1[p--];
                else
                    nums1[k--] = nums2[q--];
            }
            while (q >= 0)
                nums1[k--] = nums2[q--];
            for (int i = 0; i < nums1.Length; i++)
                Console.WriteLine(nums1[i]);
        }
    }
}

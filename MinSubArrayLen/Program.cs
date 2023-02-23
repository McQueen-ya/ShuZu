using System;

namespace MinSubArrayLen//长度最小的子数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int[] nums2 = { 1, 4, 4 };
            int[] nums3 = { 1, 1, 1, 1, 1, 1, 1, 1 };

            Console.WriteLine(MinSubArrayLen(7, nums));
            Console.WriteLine(MinSubArrayLen(4, nums2));
            Console.WriteLine(MinSubArrayLen(11, nums3));
        }

        /*public static int MinSubArrayLen(int target, int[] nums) //暴力解法
        {
            int l, r, temp = 0;
            int ans = int.MaxValue; //2 147 483 647
            for (l = 0; l < nums.Length; l++)
            {
                temp = 0;
                for (r = l; r < nums.Length; r++)
                {
                    temp += nums[r];
                    if (temp >= target)
                    {
                        ans = Math.Min(ans, r - l + 1);
                        break;
                    }
                }
            }
            return ans == int.MaxValue ? 0 : ans;
        }*/

        public static int MinSubArrayLen(int target, int[] nums) //滑动窗口
        {
            int n = nums.Length;
            if (n == 0)
                return 0;

            int ans = int.MaxValue;
            int start = 0, end = 0;
            int sum = 0;
            while (end < n)
            {
                sum += nums[end];
                while (sum >= target)
                {
                    ans = Math.Min(ans, end - start + 1);
                    sum -= nums[start]; //注意不是清空而是-start
                    ++start;
                }
                ++end;
            }
            return ans == int.MaxValue ? 0 : ans;
        }
    }
}

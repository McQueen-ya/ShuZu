using System;

namespace RemoveElement//移除指定数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4] { 3, 2, 2, 3 };
            RemoveElement(arr, 3);
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    nums[index++] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            Console.Write(index);

            return index;
        }
    }
}

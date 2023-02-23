using System;

namespace RemoveDuplicates //删除超过两个的重复数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] arr2 = new int[9] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            RemoveDuplicates(arr);
            RemoveDuplicates2(arr2);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int index = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[index] != nums[i])
                    nums[++index] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(index + 1);
            return index + 1;
        }

        public static int RemoveDuplicates2(int[] nums)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (index < 2 || nums[i] != nums[index - 2])
                    nums[index++] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(index);
            return index;
        }
    }
}

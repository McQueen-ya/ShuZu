using System;

namespace MoveZeroes//移动零
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 0, 1, 0, 3, 12 };
            MoveZeroes(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;

            int index = 0;

            //不为0则覆盖到原数组
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[index++] = nums[i];
            }

            //将0的数量添加到末尾          
            while (index < nums.Length)
                nums[index++] = 0;
        }
    }
}

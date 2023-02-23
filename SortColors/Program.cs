using System;
using System.Collections.Generic;

namespace SortColors//颜色分类
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 0, 2, 1, 1, 0 };
            SortColors(nums);
        }

        /*public static void SortColors(int[] nums)//使用List的库函数Sort
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                list.Add(nums[i]);
            list.Sort();
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }*/

        

        /*public static void SortColors(int[] nums)//使用冒泡排序
        {
            bool isSort = false;
            int temp;

            for (int i = 0; i < nums.Length; i++)
            {
                isSort = false;
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        isSort = true;
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }

                if (!isSort)
                    break;
            }

            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i]);
        }*/

        public static void SortColors(int []arr)//使用双指针
        {
            int p0 = 0, p1 = 0, temp;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    temp = arr[i];
                    arr[i] = arr[p1];
                    arr[p1] = temp;
                    p1++;
                }
                else if (arr[i] == 0)
                {
                    temp = arr[i];
                    arr[i] = arr[p0];
                    arr[p0] = temp;
                    if (p0 < p1)
                    {
                        temp = arr[i];
                        arr[i] = arr[p1];
                        arr[p1] = temp;
                    }
                    p0++;
                    p1++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}

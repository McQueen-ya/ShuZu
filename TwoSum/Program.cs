using System;
using System.Collections.Generic;

namespace TwoSum//两数之和 II - 输入有序数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 7, 11, 15, 17, 20 };
            int target = 28;
            int[] num = TwoSum(numbers, target);
            for (int i = 0; i < num.Length; i++)
                Console.Write(num[i] + " ");
        }

        /*public static int[] TwoSum(int[] numbers, int target)//暴力解法 双指针
        {
            int[] array = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        array[0] = i + 1;
                        array[1] = j + 1;
                        return array;
                    }
                }
            }
            return null;
        }*/

        /*public static int[] TwoSum(int[] numbers, int target)//对撞指针法
        {
            int[] array = new int[2];
            int Left = 0, right = numbers.Length - 1;
            while (Left < right)
            {
                if (numbers[Left] + numbers[right] == target)
                {
                    array[0] = Left + 1;
                    array[1] = right + 1;
                    return array;
                }
                else if (numbers[Left] + numbers[right] > target)
                    right--;
                else
                    Left++;
            }
            return null;
        }*/

        /*public static int[] TwoSum(int[] numbers, int target)//二分法
        {
            int[] array = new int[2];
            int low = 0, high = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                low = i + 1;
                high = numbers.Length - 1;

                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    if ((target - numbers[i]) < numbers[mid])
                    {
                        high = mid - 1;
                    }
                    else if ((target - numbers[i]) > numbers[mid])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        array[0] = i + 1;
                        array[1] = mid + 1;
                        return array;
                    }
                }
            }
            return null;
        }*/

        static int[] TwoSum(int[] numbers, int target)//内存换性能 字典法
        {
            int[] array = new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsKey(numbers[i]))
                {
                    array[0] = i;
                    array[1] = dic[numbers[i]];
                    return array;
                }
                dic.Add(target - numbers[i], i);
            }
            return null;
        }
    }
}


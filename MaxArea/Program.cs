using System;

namespace MaxArea//盛水最多的容器
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] height2 = new int[] { 1, 1 };
            Console.WriteLine(MaxArea(height));
            Console.WriteLine(MaxArea(height2));
        }

        public static int MaxArea(int[] height)
        {
            int Max = 0, area = 0, left = 0, right = height.Length - 1;
            while (left < right)
            {
                area = Math.Min(height[left], height[right]) * (right - left);
                Max = Math.Max(Max, area);
                if (height[left] < height[right]) //将更短的那一边向中间移动,因为后续另外一边无论在哪儿,Max的值都已经确定了
                    left++;
                else
                    right--;
            }
            return Max;
        }
    }
}

//笔记
//Math.Min函数可以替代 temp = height[left] < height[right] ? height[left] : height[right] 做法

//以下方法可以打印运行时间
//DateTime begainTime = DateTime.Now;
//DateTime endTime = DateTime.Now;
//TimeSpan oTime = endTime.Subtract(begainTime);
//Console.WriteLine(oTime.TotalSeconds);
//Console.WriteLine(oTime.TotalMilliseconds);
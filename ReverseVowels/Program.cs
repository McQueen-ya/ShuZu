using System;

namespace ReverseVowels//反转字符串中的元音字母
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string str2 = "leetcode";
            string s = ReverseVowels(str);
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
            s = ReverseVowels(str2);
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
        }

        public static String ReverseVowels(String s)
        {
            char[] target = s.ToCharArray();
            int start = 0, end = target.Length - 1;
            while (start < end)
            {
                while (start < end && !isvowel(target[start]))
                    start++;
                while (end > start && !isvowel(target[end]))
                    end--;
                Swap(target, start, end);
                start++;
                end--;
            }
            return new String(target);
        }

        //交换函数
        private static void Swap(char[] target, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            char temp = target[start];
            target[start] = target[end];
            target[end] = temp;
        }

        //判断是否为元音字母
        private static bool isvowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                return true;
            else
                return false;
        }
    }
}

//笔记
//string数组中的元素只能读，不能修改，所以要将其专成char数组才能进行交换值操作

//判断是否为元音字母还有一个方法是用string里的public int IndexOf( char value )
//返回指定 Unicode 字符在当前字符串中第一次出现的索引，索引从 0 开始。
//public bool IsVowel(char ch)
//  return "aeiouAEIOU".IndexOf(ch) >= 0; 如果返回的值小于0则为false

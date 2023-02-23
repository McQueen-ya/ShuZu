using System;

namespace IsPalindrome//验证回文串
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "0P";
            string s1 = "race a car";
            string s2 = " ";
            string s3 = "A man, a plan, a canal: Panama";
            Console.WriteLine(IsPalindrome(s));
            Console.WriteLine(IsPalindrome(s1));
            Console.WriteLine(IsPalindrome(s2));
            Console.WriteLine(IsPalindrome(s3));
        }

        public static bool IsPalindrome(string s)
        {
            string str;
            str = s.ToLower();
            int left = 0, right = str.Length - 1;
            while (left < right)
            {
                if (str[left] < 48 || str[left] > 57 && str[left] < 97 || str[left] > 122)
                {
                    left++;
                    continue;
                }
                if (str[right] < 48 || str[right] > 57 && str[right] < 97 || str[right] > 122)
                {
                    right--;
                    continue;
                }
                else
                {
                    if (str[left] != str[right])
                        return false;
                    left++;
                    right--;
                }
            }
            return true;
        }
    }
}

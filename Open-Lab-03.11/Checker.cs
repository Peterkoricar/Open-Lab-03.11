using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string rev = "";
            for (int a = str.Length - 1; a >= 0; a--)
            {
                rev = rev + str[a];
            }
            return str == rev;
        } 
    }
}

﻿#pragma warning disable
using System;
using System.Reflection;

class program
{
    static void Main()
    {
        static string rs(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        string[] n = Console.ReadLine().Split();
        string a = rs(n[0]);
        string b = rs(n[1]);
        string res = "";
        int len = Math.Max(a.Length, b.Length), up = 0;

        for(int i = 0; i < len; i++)
        {
            int ap = i < a.Length ? a[i] - '0' : 0;
            int bp = i < b.Length ? b[i] - '0' : 0;
            int sum = ap + bp + up;

            if (sum >= 10)
            {
                up = 1;
                sum -= 10;
            }
            else
            {
                up = 0;
            }

            res += sum.ToString();
        }

        if (up == 1)
        {
            res += "1";
        }

        Console.WriteLine(rs(res));
    }
}
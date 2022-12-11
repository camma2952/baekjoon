#pragma warning disable
using System;

class program
{
    static bool checkpr(int n)
    {
        if (n == 1)
        {
            return false;
        }

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
    static bool[] ert(int n)
    {
        bool[] c = Enumerable.Repeat<bool>(false, n + 5).ToArray<bool>();
        c[1] = true;

        for (int i = 2; i <= n; i++)
        {
            if (c[i] == false)
            {
                for (int j = i + i; j <= n; j = j + i)
                {
                    c[j] = true;
                }
            }
        }

        return c;
    }

    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine()), cnt = 0;
            bool[] prime = ert(n);

            if (n == 0)
            {
                break;
            }

            for(int i = n; i <= n * 2; i++)
            {
                if (prime[i])
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
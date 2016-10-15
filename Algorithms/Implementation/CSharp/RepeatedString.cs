using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine(RepeatedString(s, n))
    }

    public static int RepeatedString(string s, long n)
    {
		int sLen = s.Length;
		long r = n % sLen;
		long fs = n / sLen;

		int numA = 0;
		int numAr = 0;
		int t = 1;
		bool containsA = false;

        for (int i = 0; i < sLen; i++)
        {
            if (s[i] == 'a')
            {
                numA++;
                containsA = true;

                if (t <= r)
                    numAr++;
            }
            t++;
        }

        if (!containsA)
            return 0;

        long totalA = numA * fs;
        totalA += numAr;
        return totalA;
    }
}

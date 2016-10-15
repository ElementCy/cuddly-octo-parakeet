using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
    
        Console.WriteLine(SockMerchant(n, c));
    }

    public static int SockMerchant(int n, int[] c)
    {
        int numPairs = 0;
        HashSet<int> socks = new HashSet<int>();

        for(int i = 0; i < n; i++)
        {
            if(!socks.Add(c[i]))
            {
                numPairs++;
                socks.Remove(c[i]);
            }
        }

        return numPairs;
    }
}
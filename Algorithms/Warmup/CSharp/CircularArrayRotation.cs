using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args)
    {
        int n, k, q;
        string[] ap = Console.ReadLine().Split(' ');
        n = Int32.Parse(ap[0]);
        k = Int32.Parse(ap[1]);
        q = Int32.Parse(ap[2]);
        
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        k = k % n;
        
        for(int i = 0; i < q; i++)
        {
            int pos = Int32.Parse(Console.ReadLine());
            Console.WriteLine(arr[(Math.Abs(pos + n - k))%n]);
        }
    }
}
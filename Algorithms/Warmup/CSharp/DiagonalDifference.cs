using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        
        int j = 0;
        int k = n-1;
        
        int pd = 0;
        int sd = 0;
        
        for(int i = 0; i < n; i++)
        {
            pd += a[i][j++];
            sd += a[i][k--];
        }
        
        Console.WriteLine(Math.Abs(pd - sd));
    }
}

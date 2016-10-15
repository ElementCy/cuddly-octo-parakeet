using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        string[] c = Console.ReadLine().Split(' ');
        int b = Int32.Parse(Console.ReadLine());

        BonAppetit(Int32.Parse(s[0]), Int32.Parse(s[1]), Array.ConvertAll(c, Int32.Parse), b);
    }
    
    public static void BonAppetit(int n, int k, int[] c, int b)
    {
        int totalCost = 0;
        int bActual = 0;

        for (int i = 0; i < c.Length; i++)
        {
            if (i != k)
                totalCost += c[i];
        }

        bActual = totalCost / 2;

        if (bActual == b)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(b - bActual);
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        long t = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine(StrangeCounter(t));
    }
    
    // Because, Maths!
    public static long StrangeCounter(long t)
    {
        long pow = (long)Math.Pow(2, Math.Floor(Math.Log((t + 2) / 3, 2)));
        long val = 3 * pow;
        long time = 3 * pow - 2;

        return (val - (t - time));
    }
}
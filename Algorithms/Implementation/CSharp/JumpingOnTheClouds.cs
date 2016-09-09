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
        
        int curPos = 0;
        int steps = 0;

        while(curPos < (n-1))
        {
            if (curPos + 2 < n && curPos + 1 < n)
            {
                if (c[curPos + 2] == 0)
                    curPos += 2;
                else
                    curPos++;
            } else
            {
                if (curPos + 1 < n)
                    curPos++;
            }
            steps++;
        }

        Console.WriteLine(steps);
    }
}
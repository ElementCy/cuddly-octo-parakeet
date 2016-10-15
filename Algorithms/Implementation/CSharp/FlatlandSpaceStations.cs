using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);

        Console.WriteLine(FlatlandSpaceStations(n, m, c));

        Console.ReadKey();
    }

    public static int FlatlandSpaceStations(int n, int m, int[] c)
    {
        int[] points = new int[n];

        for(int i = 0; i < n; i++)
        {
            points[i] = 1;
        }

        for(int i = 0; i < m; i++)
        {
            points[c[i]] = 0;
        }

        int zPoint = Int32.MaxValue;

        for(int i = 0; i < n; i++)
        {
            if(points[i] == 1)
            {
                if(zPoint != Int32.MaxValue)
                {
                    points[i] = i - zPoint;
                }
                else
                {
                    points[i] = Int32.MaxValue;
                }
            }
            else
            {
                zPoint = i;
            }
        }

        zPoint = 0;
        int val = 0;

        for(int i = n-1; i >= 0; i--)
        {
            if (points[i] != 0)
            {
                val = Math.Abs(zPoint - i);
                points[i] = (points[i] < val) ? points[i] : val;
            }
            else
                zPoint = i;
        }

        int maxDist = -1;
        for(int i = 0; i < n; i++)
        {
            if(points[i] > maxDist)
            {
                maxDist = points[i];
            }
        }

        return maxDist;
    }
}

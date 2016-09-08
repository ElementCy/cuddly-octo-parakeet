using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int c = Convert.ToInt32(tokens_n[1]);
            int m = Convert.ToInt32(tokens_n[2]);
            
            int numBars = 0;
            int numWrappers = 0;
            int totalBars = 0;
            
            numBars = n / c;
            do
            {
                numWrappers += numBars;
                totalBars += numBars;

                numBars = numWrappers / m;
                numWrappers -= (numBars * m);

            } while (numBars > 0);
                
            Console.WriteLine(totalBars);
        }
    }
}
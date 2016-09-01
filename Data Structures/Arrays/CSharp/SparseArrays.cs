using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int N, Q;
        List<string> strings = new List<string>();
        
        N = Int32.Parse(Console.ReadLine());
        
        for(int i = 0; i < N; i++)
        {
            strings.Add(Console.ReadLine());
        }
        
        Q = Int32.Parse(Console.ReadLine());
        
        for(int i = 0; i < Q; i++)
        {
            string query = Console.ReadLine();
            int cnt = 0;
            foreach(string s in strings)
            {
                if(s == query)
                    cnt++;
            }
            
            Console.WriteLine(cnt);
        }
    }
}
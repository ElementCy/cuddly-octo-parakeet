using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int[] inputArr = Array.ConvertAll(inputs, Int32.Parse);
        
        int n = inputArr[0];
        int d = inputArr[1];
        
        string[] inArr = Console.ReadLine().Split(' ');
        int[] arrInt = Array.ConvertAll(inArr, Int32.Parse);
        List<int> arr = arrInt.ToList();
        
        for(int i = 0; i < d; i++)
        {
            int first = arr[0];
            arr.RemoveAt(0);
            arr.Add(first);
        }
        
        Console.WriteLine(string.Join(" ", arr));
    }
}
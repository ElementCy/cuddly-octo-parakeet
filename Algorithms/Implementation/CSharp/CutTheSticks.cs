using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] arr_temp = Console.ReadLine().Split(' ');
		int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
		
		CutTheSticks(n, arr);
	}

	public static void CutTheSticks(int n, int[] arr)
	{
		Array.Sort(arr);

		Console.WriteLine(n);

		int cut = arr[0];
		int idx = 1;
		while(idx < n)
		{
			if (cut == arr[idx])
			{
				idx++;
				continue;
			}

			Console.WriteLine(n - idx);
			cut = arr[idx];
			idx++;
		}
	}
}
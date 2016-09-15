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
	
		PlusMinus(n, arr);
	}

	public static void PlusMinus(int n, int[] arr)
	{
		int p = 0;
		int z = 0;
		int v = 0;

		for(int i = 0; i < n; i++)
		{
			if(arr[i] > 0)
				p++;
			else if(arr[i] < 0)
				v++;
			else
				z++;
		}
		
		Console.WriteLine(p/((float)n));
		Console.WriteLine(v/((float)n));
		Console.WriteLine(z/((float)n));
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	static void Main(String[] args)
	{
		string[] tokens_x1 = Console.ReadLine().Split(' ');
		int x1 = Convert.ToInt32(tokens_x1[0]);
		int v1 = Convert.ToInt32(tokens_x1[1]);
		int x2 = Convert.ToInt32(tokens_x1[2]);
		int v2 = Convert.ToInt32(tokens_x1[3]);
		
		Kanaroo(x1, v1, x2, v2);
	}

	public static void Kanaroo(int x1, int v1, int x2, int v2)
	{
		if ((x1 < x2) && (v1 < v2))
		{
			Console.WriteLine("NO");
		}
		else
		{
			int x = Math.Abs(x1 - x2);
			int v = Math.Abs(v1 - v2);

			if (v == 0)
				Console.WriteLine("NO");
			else if ((x % v == 0) && (x / v > 0))
				Console.WriteLine("YES");
			else
				Console.WriteLine("NO");
		}
	}
}
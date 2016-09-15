using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
	static void Main(String[] args)
	{
		int t = Convert.ToInt32(Console.ReadLine());

		for(int i = 0; i < t; i++)
		{
			string[] test = Console.ReadLine().Split(' ');
			int n = Int32.Parse(test[0]);
			int m = Int32.Parse(test[1]);
			int s = Int32.Parse(test[2]);

			Console.WriteLine(WhoGetsPoisoned(n, m, s));

		}
	}
	
	public static int WhoGetsPoisoned(int n, int m, int s)
	{
		int pos = (s - 1) + m;
		if(pos > n)
			pos = pos % n;
		return (pos == 0) ? n : pos;
	}
}
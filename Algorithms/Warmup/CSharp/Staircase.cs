using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		
		Staircase(n);
	}

	public static void Staircase(int n)
	{
		for(int i = (n-1); i >= 0; i--)
		{
			for(int j = 0; j < n; j++)
			{
				if(j < i)
					Console.Write(" ");
				else
					Console.Write("#");
			}
			Console.WriteLine("");
		}
	}
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
	static void Main(String[] args)
	{
		string[] tokens_a0 = Console.ReadLine().Split(' ');
		string[] tokens_b0 = Console.ReadLine().Split(' ');
		
		CompareTheTriplets(tokens_a0, tokens_b0);
	}

	public static void CompareTheTriplets(string[] tokens_a0, string[] tokens_b0)
	{
		
		int a0 = Convert.ToInt32(tokens_a0[0]);
		int a1 = Convert.ToInt32(tokens_a0[1]);
		int a2 = Convert.ToInt32(tokens_a0[2]);

		int b0 = Convert.ToInt32(tokens_b0[0]);
		int b1 = Convert.ToInt32(tokens_b0[1]);
		int b2 = Convert.ToInt32(tokens_b0[2]);

		int aTotal = 0;
		int bTotal = 0;
		
		if(a0 != b0)
		{
			if(a0 > b0)
				aTotal++;
			else
				bTotal++;
		}
		if(a1 != b1)
		{
			if(a1 > b1)
				aTotal++;
			else
				bTotal++;
		}
		if(a2 != b2)
		{
			if(a2 > b2)
				aTotal++;
			else
				bTotal++;
		}
		
		Console.WriteLine(aTotal + " " + bTotal);
	}
}

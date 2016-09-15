using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
	static void Main(String[] args)
	{
		string[] nStr = Console.ReadLine().Split(' ');
		string[] tTmp = Console.ReadLine().Split(' ');
		int[] t = Array.ConvertAll(tTmp, Int32.Parse);

		int n = Int32.Parse(nStr[0]);
		int k = Int32.Parse(nStr[1]);

		Console.WriteLine(LisasWorkbook(n, k, t));
	}
	
	public static int LisasWorkbook(int n, int k, int[] t)
	{
		int curPage = 0;
		int totalSpecial = 0;

		for(int i = 0; i < n; i++)
		{
			int totalPages = (int)Math.Ceiling(t[i] /(float) k);
			
			for(int j = 0; j < totalPages; j++)
			{
				curPage++;
				int low = (j * k) + 1;
				int high = Math.Min(low + k - 1, t[i]);

				if (low <= curPage && high >= curPage)
					totalSpecial++;
			}
		}
		return totalSpecial;
	}
}
using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
	static void Main(String[] args)
	{
		int n = Int32.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			string s = Console.ReadLine();
			Console.WriteLine(PalindromeIndex(s));
		}
	}
	
	public static int PalindromeIndex(string s)
	{
		int x = 0;
		int y = s.Length - 1;

		while(x < y)
		{
			if(s[x] != s[y])
			{
				if (s[x + 1] == s[y] && s[x + 2] == s[y - 1])
					return x;
				else
					return y;
			}

			x++;
			y--;
		}
		return -1;
	}
}
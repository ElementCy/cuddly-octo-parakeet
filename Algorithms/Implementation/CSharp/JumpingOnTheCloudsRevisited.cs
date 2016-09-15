using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
	static void Main(String[] args)
	{
		string[] tokens_n = Console.ReadLine().Split(' ');
		int n = Convert.ToInt32(tokens_n[0]);
		int k = Convert.ToInt32(tokens_n[1]);
		string[] c_temp = Console.ReadLine().Split(' ');
		int[] c = Array.ConvertAll(c_temp,Int32.Parse);
		
		Console.WriteLine(JumpOnCloudsRevisited(n, k, c));
	}
	
	public static int JumpOnCloudsRevisited(int n, int k, int[] clouds)
	{
		int E = 100;
		int curCloud = 0;

		do
		{
			curCloud = (curCloud + k) % n;

			E -= 1;
			
			if (clouds[curCloud] == 1)
				E -= 2;

		} while (curCloud != 0);

		return E;
	}
}
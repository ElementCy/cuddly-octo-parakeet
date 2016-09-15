using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
	static void Main(String[] args)
	{
		string[] tokens_n = Console.ReadLine().Split(' ');
		int n = Convert.ToInt32(tokens_n[0]);
		int k = Convert.ToInt32(tokens_n[1]);
		string[] arr_temp = Console.ReadLine().Split(' ');
		int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

		Console.WriteLine(NonDivisibleSubset(n, k, arr));
	}

	public static int NonDivisibleSubset(int n, int k, int[] arr)
	{
		// Special cases, if k is 0 or 1, we want to return just 1
		if(k == 0 || k == 1)
		{
			return 1;
		}
		
		// Using basic number theory explained here:
		// http://cs.stackexchange.com/questions/57873/maximum-subset-pairwise-not-divisible-by-k
		Dictionary<int, int> remainders = new Dictionary<int, int>();
		int total = 0;

		for(int i = 0; i < n; i++)
		{
			int r = arr[i] % k;
			if(!remainders.ContainsKey(r))
			{
				remainders.Add(r, 1);
			}else
			{
				remainders[r]++;
			}
		}

		for(int i = 1; (i * 2) < k; i++)
		{
			int r1 = (remainders.ContainsKey(i) ? remainders[i] : 0);
			int r2 = (remainders.ContainsKey(k - i) ? remainders[k - i] : 0);
			total += Math.Max(r1, r2);
		}

		if (remainders.ContainsKey(0))
			total++;

		if (k % 2 == 0)
			total++;

		return total;
	}
}
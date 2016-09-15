using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
	static void Main(String[] args)
	{   
		string[] nq = Console.ReadLine().Split(' ');
		int[] nqa = Array.ConvertAll(nq,Int32.Parse);
		
		DynamicArray(nqa[0], nqa[1]);
	}

	public static void DynamicArray(int N, int Q)
	{
		int lastAns = 0;
		List<int>[] seqList = new List<int>[N];
		
		for(int i = 0; i < N; i++)
			seqList[i] = new List<int>();
		
		for(int i = 0; i < Q; i++)
		{
			string[] inputs = Console.ReadLine().Split(' ');
			int[] inputArray = Array.ConvertAll(inputs, Int32.Parse);
			int qType = inputArray[0];
			int x = inputArray[1];
			int y = inputArray[2];
			
			var seq = seqList[(x ^ lastAns) % N];
			if(qType == 1)
			{
				seq.Add(y);
			}else if(qType == 2)
			{
				lastAns = seq[y % (seq.Count)];
				Console.WriteLine(lastAns);
			}
		}
	}
}
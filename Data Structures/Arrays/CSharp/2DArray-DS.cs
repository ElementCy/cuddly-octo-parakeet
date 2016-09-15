using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
	static void Main(String[] args)
	{
		int[][] arr = new int[6][];
		for(int arr_i = 0; arr_i < 6; arr_i++){
		   string[] arr_temp = Console.ReadLine().Split(' ');
		   arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
		}

		Console.Write(Array2DDS(arr));
	}

	public static int Array2DDS(int[][] arr)
	{
		int maxValue = -999999;
		
		for(int x = 0; x < 4; x++)
		{
			for(int y = 0; y < 4; y++)
			{
				int value = arr[y][x] + arr[y][x+1] + arr[y][x+2] + arr[y+1][x+1] + arr[y+2][x] + arr[y+2][x+1] + arr[y+2][x+2];
				if(value > maxValue)
					maxValue = value;
			}
		}
		return maxValue;
	}
}
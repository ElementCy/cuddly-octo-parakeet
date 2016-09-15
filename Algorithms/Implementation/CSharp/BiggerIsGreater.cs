using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());

		for(int i = 0; i < n; i++)
		{
		string word = Console.ReadLine();

		Console.WriteLine(NextLexicographic(word.ToCharArray()));
		}
	}
	
	public static string NextLexicographic(char[] word)
	{
		int wordLen = word.Length;
		int pos = wordLen - 1;

		while(pos > 0 && word[pos-1] >= word[pos])
			pos--;

		if (pos <= 0)
			return "no answer";

		int posR = wordLen - 1;
		while (word[posR] <= word[pos - 1])
			posR--;

		char t = word[pos - 1];
		word[pos - 1] = word[posR];
		word[posR] = t;

		posR = wordLen - 1;
		while(pos < posR)
		{
			t = word[pos];
			word[pos] = word[posR];
			word[posR] = t;
			pos++;
			posR--;
		}

		return new string(word);
	}
}
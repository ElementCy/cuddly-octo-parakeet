using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			string s = Console.ReadLine();
			Console.WriteLine(SherlockAndAnagrams(s));
		}
	}
	
	public static int SherlockAndAnagrams(string s)
	{
		Dictionary<AnagramChars, int> anagrams = new Dictionary<AnagramChars, int>();

		// count dupe strings (based on byte values)
		for(int i = 0; i < s.Length; i++)
		{
			AnagramChars ac = new AnagramChars();
			
			for(int j = i; j < s.Length; j++)
			{
				ac.AddChar(s[j]);
				if (!anagrams.ContainsKey(ac))
					anagrams.Add(new AnagramChars(ac), 1);
				else
					anagrams[ac] += 1;
			}
		}
		// return sum of vertices-edge relationships for the strings we found.
		return anagrams.Values.Sum(v => ((v * (v - 1) / 2)));
	}
}

class AnagramChars
{
	public byte[] CharArray;

	public AnagramChars()
	{
		CharArray = new byte[26];
	}

	public AnagramChars(AnagramChars charCount)
	{
		CharArray = new byte[26];
		for (int i = 0; i < 26; i++)
		{
			CharArray[i] = charCount.CharArray[i];
		}
	}

	public void AddChar(char ch)
	{
		CharArray[ch - 'a']++;
	}

	protected bool Equals(AnagramChars other)
	{
		return Equals(CharArray, other.CharArray);
	}

	public override bool Equals(object obj)
	{
		AnagramChars other = obj as AnagramChars;
		if (obj == null)
		{
			return false;
		}

		for (int i = 0; i < 26; i++)
		{
			int val = CharArray[i].CompareTo(other.CharArray[i]);
			if (val != 0)
			{
				return false;
			}
		}

		return true;
	}

	public override int GetHashCode()
	{
		int hc = CharArray.Length;
		for (int i = 0; i < CharArray.Length; ++i)
		{
			hc = unchecked(hc * 13 + CharArray[i]);
		}
		return hc;
	}
}
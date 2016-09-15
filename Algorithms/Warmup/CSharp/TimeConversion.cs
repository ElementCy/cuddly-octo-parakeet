using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
	static void Main(String[] args)
	{
		string time = Console.ReadLine();
		
		TimeConversion(time);
	}

	public static void TimeConversion(string time)
	{
		int hour = Int32.Parse(time.Substring(0, 2));
		int min = Int32.Parse(time.Substring(3, 2));
		int sec = Int32.Parse(time.Substring(6, 2));
		string apm = time.Substring(8);

		if (apm.ToLower() == "pm" && hour != 12)
			hour += 12;
		else if (apm.ToLower() == "am" && hour == 12)
			hour = 0;

		Console.WriteLine(hour.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2"));
	}
}

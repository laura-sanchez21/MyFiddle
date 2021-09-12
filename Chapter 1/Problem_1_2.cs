using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		string str1 = "hello";
		string str2 = "hel";


		bool result = CheckPermutation(str1, str2);

		if (result)
			Console.WriteLine("String: {0} and string: {1} are permutable strings", str1, str2);
		else
			Console.WriteLine("String: {0} and string: {1} are NOT permutable strings", str1, str2);

	}

	public static bool CheckPermutation(string str1, string str2)
	{
		int result = 0;

		if (str1.Length != str2.Length)
			return false;

		Dictionary<char, int> freqTable = new Dictionary<char, int>();

		foreach (char letter in str1)
		{
			if (!freqTable.ContainsKey(letter))
				freqTable[letter] = 0;

			freqTable[letter]++;
		}

		foreach (char letter in str2)
		{
			if (!freqTable.ContainsKey(letter))
				return false;

			freqTable[letter]--;
		}

		foreach (KeyValuePair<char, int> element in freqTable)
			result = element.Value;

		if (result != 0)
			return false;
		else
			return true;
	}
}
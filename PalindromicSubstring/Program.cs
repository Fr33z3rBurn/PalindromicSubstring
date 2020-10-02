using System;
using System.Linq;

namespace PalindromicSubstring
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "million";
			string input2 = "banana";
			var answer = FindLongestPalendromicSubString(input2);
		}

		private static string FindLongestPalendromicSubString(string input)
		{
			string candidate = "";
			string longestPalindrome = "";

			for (int i = 0; i < input.Length; i++)
			{
				for (int j = 0; j < input.Length; j++)
				{
					if ((i + j) <= input.Length)
					{
						if (input.Substring(i, j) == ReverseString(input.Substring(i, j)))
						{
							//is palendrome check length
							if (input.Substring(i, j).Length > candidate.Length)
							{
								candidate = (input.Substring(i, j));
							}
							if (candidate.Length > longestPalindrome.Length)
							{
								longestPalindrome = candidate;
							}
						}
					}
				}
			}

			return longestPalindrome;
		}

		private static string ReverseString(string stringToReverse)
		{
			char[] array = stringToReverse.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}
	}
}

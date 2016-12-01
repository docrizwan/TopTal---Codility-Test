using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTal___Codility_Test___Task1
{
	class Program
	{

		public static void Main(string[] args)
		{

			Program obj = new Program();

			//int x = obj.CountCharacterOccurrences("(((())((", ')', 0, "(((())((".Length);
			//int x = obj.CountCharacterOccurrences("(((())((", ')', 0, "(((())((".Length);
			//
			//int x = obj.FindingKValue("(())))(");
			int x = obj.FindingKValue("((()(()))(()()()()))(");
			Console.WriteLine(x);
			Console.ReadKey();
		}
		public int FindingKValue(string S)
		{
			for (int k = 1; k < S.Length; k++)
			{
				int openingBs = CountCharacterOccurrences(S, '(', 0, k - 1);
				int x = S.Length - k;
				int closingBs = CountTrailingCharacterOccur(S, ')', k, S.Length - 1);
				if (openingBs == closingBs)
				{
					return k;
				}
			}
			return -1;
		}
		//public bool ValidateInputString()
		//{

		//}

		public int CountCharacterOccurrences(string Input, char Char, int StartIndex, int LastIndex)
		{
			int charCount = 0;
			for (int i = StartIndex; i <= LastIndex; i++)
			{
				if (Input.ElementAt(i) == Char)
				{
					charCount++;
				}
			}
			return charCount;
		}
		public int CountTrailingCharacterOccur(string input, char Char, int start, int last)
		{
			int count = 0;
			/*
			for (int i=last; i >= start; i--)
			{
				if(input.ElementAt(i) == Char)
				{
					count++;
				}

			}
			*/
			for (int i = start; i <= last; i++)
			{
				if (input.ElementAt(i) == Char)
				{
					count++;
				}
			}
			return count;
		}

	}
}


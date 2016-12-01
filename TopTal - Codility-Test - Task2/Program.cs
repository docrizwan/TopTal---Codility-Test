using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTal___Codility_Test___Task2
{
	class Program
	{

		static void Main(string[] args)
		{
			//Console.Write(Convert.ToString(9, -2));
			Program obj = new Program();
			//Console.Write(obj.ConvertToBase10(new int[] { 1,0,0,1,1 }));
			//Console.Write(obj.ConvertToBase10(new int[] { 1, 0, 0, 1, 1, 1 }));

			//Console.Write(obj.ConvertToNegativeBase2(-9));
			//Console.Write(obj.ConvertToNegativeBase2(23));

			//var output = obj.NegativeBase2NumberNegation(new int[] { 1, 0, 0, 1, 1 }); // X = 9

			var output = obj.NegativeBase2NumberNegation(new int[] { 1, 0, 0, 1, 1, 1 }); // X = -23
			Console.WriteLine(output);
			Console.ReadKey();

		}
		public int[] NegativeBase2NumberNegation(int[] input)
		{
			int inp = ConvertToBase10(input);

			return ConvertToNegativeBase2((-1) * inp);
		}

		public int[] ConvertToNegativeBase2(int NegNum)
		{
			List<int> NegBaseNum = new List<int>();

			while (NegNum != 0)
			{
				int remainder = NegNum % -2;
				NegNum = NegNum / -2;

				if (remainder < 0)
				{
					remainder += 2;
					NegNum += 1;
				}

				Console.WriteLine(remainder);
				NegBaseNum.Add(remainder);
			}
			return NegBaseNum.ToArray();
		}
		public int ConvertToBase10(int[] input)
		{
			int sum = 0;
			for (int i = 0; i < input.Length; i++)
			{
				sum += input[i] * (int)Math.Pow(-2, i);
			}


			return sum;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurances
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().ToLower();
			var word = Console.ReadLine().ToLower();
			var count = 0;
			var index = -1;
			while (true)
			{
				index = input.IndexOf(word, index+1);
				if (index >= 0)
				{
					count++;
				}
				else
				{
					break;
				}
			}
			Console.WriteLine(count);
		}
	}
}

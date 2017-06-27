using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
	class Program
	{
		static void Main(string[] args)
		{
			var words = Console.ReadLine()
				.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
				.ToList();
			
			var palindromes = new List<string>();
			foreach (var word in words)
			{
				var reversed = new string(word.Reverse().ToArray());
				if (word.Length == 1 || word == reversed)
				{
					palindromes.Add(word);
				}
			}
			palindromes = palindromes.Distinct().OrderBy(x => x).ToList();
			Console.WriteLine(string.Join(", ", palindromes));
		}
	}
}

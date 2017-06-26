using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();
			string reversed = new string(str.Reverse().ToArray());
			Console.WriteLine(reversed);
		}
	}
}

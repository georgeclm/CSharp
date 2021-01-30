using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaa
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter two numbers.");
			Console.Write("Enter first number =");
			int one = int.Parse(Console.ReadLine());
			Console.Write("Enter second number =");
			int two = int.Parse(Console.ReadLine());
			int final = one;
			if (two > one)
			{
				final = two;
			}
			Console.WriteLine("The Bigger number is = {0}", final);
			Console.ReadLine();

		}
	}
}

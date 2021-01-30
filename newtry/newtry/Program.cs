using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtry
{
	class Program
	{
		static void Main(string[] args)
		{
			// comment biasa
			Console.WriteLine("Hello, What's your name?");
			var a = Console.ReadLine();
			/* cmment yang panjjang
			 sdjaokdmaskm
			*/
			Console.WriteLine("Hello," +a+/*This is new comment inside line */ " Nice to meet u");
			Console.Write("Where do u come from "+a+ " =");
			var b = Console.ReadLine();
			Console.WriteLine("So u are from " + b);
			Console.WriteLine("Thank You");
			Console.WriteLine("Now Let's Save ur data");
			// save age data and c for in class or not
			Console.Write("How Old Are You? =");
			var age = Console.ReadLine();
			Console.Write("Are you in class? =");
			var c = Console.ReadLine();
			Console.WriteLine("Thank You So u are " + age + "years old and you are in class");
			Console.ReadLine();

		}
	}
}

using System;

namespace BooleanVariable
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			bool getString = bool.Parse(Console.ReadLine());

			if (getString == true)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}

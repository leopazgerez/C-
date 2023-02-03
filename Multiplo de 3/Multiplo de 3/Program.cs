using System;

namespace Multiplo_de_3
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= x; i++)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine("*");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
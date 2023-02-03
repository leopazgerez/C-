using System;

namespace Primer_metodo
{
	class Program
	{
		public static void DrawPyrmaid(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = i; j <= n; j++)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= i-1; k++)
				{
					Console.Write("*" + " ");
				}
				Console.WriteLine();
			}
		}
	class Arbolito
        {
			public static void Main(string[] args)
            {
				DrawPyrmaid(15);
            }
        }
	}
}

	  
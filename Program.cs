using System;

public static class Globals
{
	internal static void Main()


	{
		Console.Write("Introduceti cate numere va contine sirul (de la 1 la n)");
		Console.Write("\n");
		Console.Write("n= ");
		int n;
		int s = 1;
		int p = 1;
		n = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i <= n; i++)

		{
			p *= i;
			s += i;
		}
		Console.Write("Suma numerelor de la 1 la "+ n + " = " + s + "\n");
		Console.Write("Produsul numerelor de la 1 la " + n + " = " + p + "\n");

	}
}

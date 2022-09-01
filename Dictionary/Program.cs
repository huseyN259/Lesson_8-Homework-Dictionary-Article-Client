class Program
{
	static void Main()
	{
		// Dictionary
		Dictionary d = new Dictionary();

		d[0] = new string[2] { "computer - ", "komputer" };
		d[1] = new string[2] { "\nwolf - ", "canavar, qurd, yirtici heyvan" };
		d[2] = new string[2] { "\nlanguage - ", "dil" };
		d[3] = new string[2] { "\nyou - ", "sen, siz" };
		d[4] = new string[2] { "\nlove - ", "sevgi, eshq" };
		d[5] = new string[2] { "\npillow - ", "yastiq" };

		for (int i = 0; i < 5; i++)
			for (int j = 0; j < 2; j++)
				Console.Write(d[i][j]);
		Console.WriteLine();

		Console.WriteLine();
		// Article
		Article a1 = new Article("Acer", Guid.NewGuid(), 1700);
		Article a2 = new Article("HP", Guid.NewGuid(), 1800.50);

		Console.WriteLine(a1 < a2);
		Console.WriteLine(a1 + a2);
		Console.WriteLine(a1 == a2);

		Console.WriteLine();
		// Client
		Client c1 = new Client(Guid.NewGuid(), "Huseyn", "Baku", "0550000000", 9, 259);
		Client c2 = new Client(Guid.NewGuid(), "Nuran", "Baku", "0700000000", 25, 925);

		Console.WriteLine(c1++);
		Console.WriteLine(c2--);
		Console.WriteLine(c1 != c2);
	}
}
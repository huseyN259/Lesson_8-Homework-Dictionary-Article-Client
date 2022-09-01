using System.Data.Common;

class Article
{
	public string ProductName { get; set; } = default!;
	public Guid ProductCode { get; set; }
	public double Price { get; set; }

	public Article(string productName, Guid productCode, double price)
	{
		ProductName = productName;
		ProductCode = productCode;
		Price = price;
	}

	public static double operator +(Article a1, Article a2)
		=> a1.Price + a2.Price;

	public static double operator -(Article a1, Article a2)
		=> a1.Price - a2.Price;

	public static double operator *(Article a1, Article a2)
		=> a1.Price * a2.Price;

	public static double operator /(Article a1, Article a2)
	{
		if (a2.Price != 0)
			return a1.Price / a2.Price;

		throw new DivideByZeroException();
	}

	public static bool operator ==(Article a1, Article a2)
		=> a1.Price == a2.Price;

	public static bool operator !=(Article a1, Article a2)
		=> a1.Price != a2.Price;

	public static bool operator >(Article a1, Article a2)
		=> a1.Price > a2.Price;

	public static bool operator <(Article a1, Article a2)
		=> a1.Price < a2.Price;

	public static Article operator ++(Article a)
	{
		a.Price++;

		return a;
	}

	public static Article operator --(Article a)
	{
		a.Price--;

		return a;
	}

	public override string ToString()
		=> $"Product Name : {ProductName}\nProduct Code : {ProductCode}\nPrice : {Price}";
}
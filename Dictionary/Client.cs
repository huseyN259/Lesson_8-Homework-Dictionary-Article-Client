class Client
{
	public Guid ClientCode { get; set; }
	public string Fullname { get; set; } = default!;
	public string Address { get; set; } = default!;
	public string Phone { get; set; } = default!;
	public int NumberOfOrder { get; set; }
	public int TotalAmount { get; set; }

	public Client(Guid clientCode, string fullname, string address, string phone, int numberOfOrder, int totalAmount)
	{
		ClientCode = clientCode;
		Fullname = fullname;
		Address = address;
		Phone = phone;
		NumberOfOrder = numberOfOrder;
		TotalAmount = totalAmount;
	}

	public static double operator +(Client c1, Client c2)
		=> c1.TotalAmount + c2.TotalAmount;

	public static double operator -(Client c1, Client c2)
		=> c1.TotalAmount - c2.TotalAmount;

	public static double operator *(Client c1, Client c2)
		=> c1.TotalAmount * c2.TotalAmount;

	public static double operator /(Client c1, Client c2)
	{
		if (c2.TotalAmount != 0)
			return c1.TotalAmount / c2.TotalAmount;

		throw new DivideByZeroException();
	}

	public static bool operator ==(Client c1, Client c2)
		=> c1.TotalAmount == c2.TotalAmount;

	public static bool operator !=(Client c1, Client c2)
		=> c1.TotalAmount != c2.TotalAmount;

	public static bool operator >(Client c1, Client c2)
		=> c1.TotalAmount > c2.TotalAmount;

	public static bool operator <(Client c1, Client c2)
		=> c1.TotalAmount < c2.TotalAmount;

	public static Client operator ++(Client c)
	{
		c.TotalAmount++;

		return c;
	}

	public static Client operator --(Client c)
	{
		c.TotalAmount--;

		return c;
	}

	public override string ToString()
		=> $"Client Code : {ClientCode}\nFullname : {Fullname}\nAddres : {Address}\nPhone : {Phone}\nNumber of Order : {NumberOfOrder}\nTotal Amount : {TotalAmount}";
}
class Dictionary
{
	public string[][] Dict { get; set; } = default!;

	public Dictionary()
	{
		Dict = new string[6][];
	}

	public string[] this[int index]
	{
		get => Dict[index];
		set => Dict[index] = value;
	}
}
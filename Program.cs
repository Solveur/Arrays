// 1
int MaxRepeats(int[] nums)
{
	int maxRepeats = 0;
	int repeats = 0;
	foreach (int num in nums)
	{
		if (num == 1)
			repeats++;
		else
			repeats = 0;
		
		maxRepeats = Math.Max(repeats, maxRepeats);
	}
	return maxRepeats;
}

Console.WriteLine(MaxRepeats(new[] {1,1,0,1,1,1}));
Console.WriteLine(MaxRepeats(new[] {1,0,1,1,0,1}));
Console.WriteLine();

// 2
int EvenDigits(int[] nums)
{
	int digits = 0;
	foreach (int num in nums)
	{
		string n = num.ToString();
		if (n.Length % 2 == 0)
			digits++;
	}
	return digits;
}

Console.WriteLine(EvenDigits(new[] {12, 345, 2, 6, 7896}));
Console.WriteLine(EvenDigits(new[] {555, 901, 482, 1771}));
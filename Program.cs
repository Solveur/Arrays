using System.Collections;
using System.Reflection;
using Arrays;

internal class Program
{
	private static void Main(string[] args)
	{
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

		Console.WriteLine("Task 1:");
		Console.WriteLine(MaxRepeats([1, 1, 0, 1, 1, 1]));
		Console.WriteLine(MaxRepeats([1, 0, 1, 1, 0, 1]));
		Console.WriteLine();

		// 2
		int EvenDigits(int[] nums)
		{
			int evenDigitNums = 0;
			foreach (int num in nums)
			{
				string numStr = num.ToString();
				if (numStr.Length % 2 == 0)
					evenDigitNums++;
			}
			return evenDigitNums;
		}


		Console.WriteLine("Task 2:");
		Console.WriteLine(EvenDigits([12, 345, 2, 6, 7896]));
		Console.WriteLine(EvenDigits([555, 901, 482, 1771]));
		Console.WriteLine();

		// 3
		int[] Squares(int[] nums)
		{
			int[] squares = new int[nums.Length];
			squares = nums.Select(n => n * n).ToArray();
			Array.Sort(squares);
			return squares;
		}

		Console.WriteLine("Task 3:");
		foreach (var i in Squares([-4, -1, 0, 3, 10]))
		{
			Console.Write($"{i,-3}");
		}
		Console.WriteLine();
		foreach (var i in Squares([-7, -3, 2, 3, 11]))
		{
			Console.Write($"{i,-3}");
		}
		Console.WriteLine();
		Console.WriteLine();

		// 4
		int[] DoubleZeros(int[] arr)
		{
			int[] res = new int[arr.Length];
			int i = 0;
			foreach (int number in arr)
			{
				res[i++] = number;
				if (number == 0 && i < arr.Length) res[i++] = number;
				if (i == arr.Length) break;
			}
			return res;
		}

		Console.WriteLine("Task 4:");
		foreach (int n in DoubleZeros([1, 0, 2, 3, 0, 4, 5, 0]))
		{
			Console.Write($"{n,-3}");
		}
		Console.WriteLine();
		foreach (int n in DoubleZeros([1, 2, 3]))
		{
			Console.Write($"{n,-3}");
		}
		Console.WriteLine();
		Console.WriteLine();

		// 5
		void Join(int[] nums1, int[] nums2, int n, int m)
		{
			foreach (int n2 in nums2)
			{
				int i = 0;
				while (n2 > nums1[i] && i < n) i++;

				for (int j = n + m - 1; j > i; j--)
				{
					nums1[j] = nums1[j - 1];
				}
				nums1[i] = n2;
			}
			Array.Sort(nums1);
		}

		Console.WriteLine("Task 5:");
		int[] nums1 = [1, 2, 3, 0, 0, 0];
		int[] nums2 = [2, 5, 6];
		Join(nums1, nums2, 3, 3);
		foreach (int n in nums1)
		{
			Console.Write($"{n,-3}");
		}
		Console.WriteLine();

		nums1 = [1];
		nums2 = [];
		Join(nums1, nums2, 1, 0);
		foreach (int n in nums1)
		{
			Console.Write($"{n,-3}");
		}
		Console.WriteLine();
		Console.WriteLine();

		nums1 = [0];
		nums2 = [1];
		Join(nums1, nums2, 0, 1);
		foreach (int n in nums1)
		{
			Console.Write($"{n,-3}");
		}
		Console.WriteLine();
		Console.WriteLine();

		// 6
		int Task6(int[] nums)
		{
			List<int> uniques = [];
			for (int i = 0; i < nums.Length; i++)
			{
				if (!uniques.Contains(nums[i]))
				{
					uniques.Add(nums[i]);
					nums.MoveTo(i, uniques.Count - 1);
				}
			}

			foreach (var i in nums)
			{
				Console.Write($"{i,-3}");
			}
			Console.WriteLine();
			return 0;
		}

		Console.WriteLine("Task 6:");
		Task6([1, 1, 2]);
		Task6([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
		Console.WriteLine();

		// 7
		bool Doppelgangers(int[] arr)
		{
			foreach (int i in arr)
				foreach (int j in arr)
					if (i == 2 * j) return true;
			return false;
		}

		Console.WriteLine("Task 7:");
		Console.WriteLine(Doppelgangers([10, 2, 5, 3]));
		Console.WriteLine(Doppelgangers([3, 1, 7, 11]));
		Console.WriteLine();

		//8
		bool MountainArray(int[] arr)
		{
			int i = 0;
			for (i = 1; i < arr.Length; i++)
				if (arr[i - 1] >= arr[i])
					break;

			if (i == arr.Length || i == 1)
				return false;

			for (; i < arr.Length; i++)
				if (arr[i - 1] <= arr[i])
					break;

			return i == arr.Length;
		}

		Console.WriteLine("Task 8:");
		Console.WriteLine(MountainArray([0, 1, 2, 3, 4, 2, 1]));
		Console.WriteLine(MountainArray([0, 2, 3, 3, 5, 2, 1]));
		Console.WriteLine(MountainArray([2, 1]));
		Console.WriteLine(MountainArray([3, 5, 5]));
		Console.WriteLine(MountainArray([0, 3, 2, 1]));
		Console.WriteLine();

		int[] Task9(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int max = 0;
				for (int j = i + 1; j < arr.Length; j++)
				{
					max = Math.Max(max, arr[j]);
				}
				arr[i] = max;
			}
			arr[^1] = -1;
			return arr;
		}

		Console.WriteLine("Task 9:");
		foreach (int n in Task9([17, 18, 5, 4, 6, 1]))
		{
			Console.Write($"{n,-3}");
		}
		Console.WriteLine();

		foreach (int n in Task9([400]))
		{
			Console.Write($"{n,-3}");
		}
		Console.WriteLine();
		Console.WriteLine();

		int[] EvenSort(int[] arr)
		{
			int vacantSpot = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0)
				{
					arr.MoveTo(i, vacantSpot);
					vacantSpot++;
				}
			}
			return arr;
		}

		Console.WriteLine("Task 10:");
		foreach (int n in EvenSort([3, 1, 2, 4]))
		{
			Console.Write($"{n,-3}");
		}
		Console.WriteLine();
	}
}



//static int Karatsuba(int x, int y)
//{
//	int n = x.ToString().Length / 2;
//	if (n == 1)
//		return x * y;

//	int x1 = Convert.ToInt32(x.ToString()[..n]);
//	int x2 = Convert.ToInt32(x.ToString()[n..]);
//	int y1 = Convert.ToInt32(y.ToString()[..n]);
//	int y2 = Convert.ToInt32(y.ToString()[n..]);
//	Console.WriteLine($"{x1}, {x2}, {y1}, {y2}");

//	int x1y1 = Karatsuba(x1, y1);
//	int x2y2 = Karatsuba(x2, y2);
//	int middle = (x1 + x2) * (y1 + y2) - x1y1 - x2y2;
//	int result = Convert.ToInt32(x1y1 * Math.Pow(10, 2 * n) + middle * Math.Pow(10, n) + x2y2);
//	return result;
//}

//Console.WriteLine(Karatsuba(5443, 1001));


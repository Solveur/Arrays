namespace Arrays
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	static class Extensions
	{
		public static void MoveTo(this int[] arr, int from, int to = 0)
		{
			int tempInt;
			for (int i = from; i > to; i--)
			{
				tempInt = arr[i - 1];
				arr[i - 1] = arr[i];
				arr[i] = tempInt;
			}
		}
	}
}

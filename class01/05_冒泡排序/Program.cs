using System;

namespace _05_Avr
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = {9,8,7,6,5,4,3,2,1,0};
			int a = 0;
			for (int i = 0; i < nums.Length - 1; i++)
			{
				for (int j = 0; j < nums.Length - 1 - i; j++)
				{
					if (nums[j] > nums[j + 1])
					{
						a = nums[j];
						nums[j] = nums[j + 1];
						nums[j + 1] = a;
					}
				}
			}
			for (int i = 0; i < nums.Length; i++)
			{
				Console.WriteLine(nums[i]);
			}
			Console.ReadKey();
		}
	}
}
